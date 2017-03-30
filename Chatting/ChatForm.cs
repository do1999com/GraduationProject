using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Chatting.ML;

namespace Chatting
{
    /// <summary>
    /// ���촰��
    /// </summary>
    public partial class ChatForm : Form
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x01;
            const int HTCAPTION = 0x02;
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MAXMIZE = 0xF030;
            const int WM_NCLBUTTONDBLCLK = 0xA3;
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case WM_NCHITTEST://��������λ�ú�����϶�����

                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        m.Result = new IntPtr(HTCAPTION);
                        return;
                    }
                    break;
                case WM_NCLBUTTONDBLCLK://��ֹ˫�����
                    Console.WriteLine(this.WindowState);

                    return;
                    break;
                default:

                    base.WndProc(ref m);
                    break;
            }
        }
        public int friendId;     // ��ǰ����ĺ��Ѻ���
        public string nickName;  // ��ǰ����ĺ����ǳ�
        public int faceId;       // ��ǰ����ĺ���ͷ��Id        

        public ChatForm()
        {
            InitializeComponent();
        }

        // �������ʱ�Ķ���
        private void ChatForm_Load(object sender, EventArgs e)
        {
            // ���ô������
            this.Text = string.Format("��{0}������",nickName);

            // ���ô��嶥����ʾ�ĺ�����Ϣ
            picFace.Image = ilFaces.Images[faceId];
            lblFriend.Text = string.Format("{0}({1})  ",nickName,friendId)+ GetTodayFeel();
            GetTodayFeel();
            // ��ȡ���е�δ����Ϣ����ʾ�ڴ�����
            ShowMessage();
        }
        /// <summary>
        /// ��ȡ���ѵĸ���ǩ��
        /// </summary>
        /// <returns></returns>
        private string GetTodayFeel()
        {
            List<classTodayFeel> feelList = new List<classTodayFeel>();
            string sql = "select TodayFeel from Users where Id=@Id";
            bool error = false;    // ��ʶ�Ƿ���ִ���
            try
            {
                //// ����Command ����
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = friendId;
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    classTodayFeel todayFeel = new classTodayFeel();
                    todayFeel.TodayFeel = dataReader["TodayFeel"] == DBNull.Value ? "��̫����,������ǩ����û��.." : dataReader["TodayFeel"].ToString();
                    feelList.Add(todayFeel);
                }
                dataReader.Close();
                 
            }
            catch (Exception ex)
            {
                error = true;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            // ������
            if (error)
            {
                MessageBox.Show("������������������볢�����µ�¼", "��Ǹ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return feelList[0].TodayFeel;
        }

        // �رմ���
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ������Ϣ
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChat.Text.Trim() == "") // ���ܷ��Ϳ���Ϣ
            {
                MessageBox.Show("���ܷ��Ϳ���Ϣ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtChat.Text.Trim().Length > 50)
            {
                MessageBox.Show("��Ϣ���ݹ��������Ϊ�������ͣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else  // ������Ϣ��д�����ݿ�
            {
                // MessageTypeId:1-��ʾ������Ϣ��Ϊ�򻯲���û�ж�ȡ���ݱ���S2�����ó�������ö��ʵ��
                // MessageState:0-��ʾ��Ϣ״̬��δ��
                int result = -1; // ��ʾ�������ݿ�Ľ��
                string sql = string.Format(
                    "INSERT INTO Messages (FromUserId, ToUserId, Message, MessageTypeId, MessageState) VALUES ({0},{1},'{2}',{3},{4})",
                    UserHelper.loginId, friendId, txtChat.Text.Trim(), 1, 0);
                try
                {
                    // ִ������
                    SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                    ML.DBHelper.connection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ML.DBHelper.connection.Close();
                }
                if (result != 1)
                {
                    MessageBox.Show("�����������������", "��Ǹ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMessages.Text += "��˵:"+DateTime.Now+"\r\n" + "  " + txtChat.Text+ "\r\n";
                if (txtMessages.Text.Length > 800)//��ֹ���ֹ���Ӱ��ۿ�
                {
                    txtMessages.Text = "��˵:" + DateTime.Now + "\r\n" + "  "+txtChat.Text + "\r\n";
                }
                txtChat.Text = "";  // ������Ϣ���
             
            }
        }
        /// <summary>
        /// ��ȡ���е�δ����Ϣ����ʾ�ڴ�����
        /// </summary>
        private void ShowMessage()
        {
            string messageIdsString = "";  // ��Ϣ��Id��ɵ��ַ���
            string message;         // ��Ϣ����
            string messageTime;     // ��Ϣ������ʱ��

            // ��ȡ��Ϣ��SQL���
            string sql = string.Format(
                "SELECT Id, Message,MessageTime From Messages WHERE FromUserId={0} AND ToUserId={1} AND MessageTypeId=1 AND MessageState=0",
                friendId,UserHelper.loginId);
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // ѭ������Ϣ��ӵ�������
                while (reader.Read())
                {
                    messageIdsString += Convert.ToString(reader["Id"]) + "_";
                    message = Convert.ToString(reader["Message"]);
                    messageTime = Convert.ToDateTime(reader["MessageTime"]).ToString(); // ת��Ϊ��������
                    txtMessages.Text += string.Format("\r\n{0}  {1}\r\n  {2}",nickName,messageTime,message);
                    txtMessages.Text += "\r\n";
                }

                reader.Close();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            // ����ʾ������Ϣ��Ϊ�Ѷ�
            if (messageIdsString.Length > 1)
            {
                messageIdsString.Remove(messageIdsString.Length - 1);
                SetMessageRead(messageIdsString, '_');
            }            
        }

        /// <summary>
        /// ����ʾ������Ϣ��Ϊ�Ѷ�
        /// </summary>        
        private void SetMessageRead(string messageIdsString, char separator)
        {
            string[] messageIds = messageIdsString.Split(separator);     // �ָ��ÿ����ϢId
            string sql = "Update Messages SET MessageState=1 WHERE Id="; // ����״̬��SQL���Ĺ̶�����
            string updateSql;  // ִ�е�SQL���
            try
            {
                SqlCommand command = new SqlCommand();     // ����Command����
                command.Connection = ML.DBHelper.connection;  // ָ�����ݿ�����
                ML.DBHelper.connection.Open();                // �����ݿ�����
                foreach (string id in messageIds)
                {
                    if (id != "")
                    {
                        updateSql = sql + id;              // ����������SQL���
                        command.CommandText = updateSql;   // ָ��Ҫִ�е�SQL���
                        int result = command.ExecuteNonQuery();  // ִ������
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
        }

        private void lblMessagesReader_Tick(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void txtMessages_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMessages_TextChanged(object sender, EventArgs e)
        {
            txtMessages.SelectionStart = txtMessages.Text.Length;
            txtMessages.ScrollToCaret();
        }

        private void ChatForm_Activated(object sender, EventArgs e)
        {
            this.txtChat.Focus();
        }
    }
  
}