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
    /// �������������Ϣ����
    /// </summary>
    public partial class RequestForm : Form
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
        int fromUserId;  // ����������û�Id

        public RequestForm()
        {
            InitializeComponent();
        }

        // �������ʱ��ȡ��������Ϣ��ʾ
        private void RequestForm_Load(object sender, EventArgs e)
        {
            int messageId = 0; // ��Ϣ��Id

            // �ҵ�������ǰ�û���������Ϣ
            string sql = string.Format(
                "SELECT Top 1 Id, FromUserId FROM Messages WHERE ToUserId={0} AND MessageTypeId=2 AND MessageState=0",
                UserHelper.loginId);
            try
            {
                // ����һ��δ����Ϣ
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.Read())                
                {
                    messageId = (int)dataReader["Id"];
                    this.fromUserId = (int)dataReader["FromUserId"];
                }
                dataReader.Close();

                // ����Ϣ״̬��Ϊ�Ѷ�
                sql = "UPDATE Messages SET MessageState =1 WHERE Id="+messageId;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                // ��ȡ�����˵���Ϣ����ʾ�ڴ�����
                sql = "SELECT NickName, FaceId FROM Users WHERE Id="+this.fromUserId;
                command.CommandText = sql;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int faceId = (int)dataReader["FaceId"];
                    string nickName = (string)dataReader["NickName"];
                    this.picIcon.Image = ilIcons.Images[faceId];
                    this.lblMessage.Text = string.Format("{0}({1})���������Ϊ����",
                        nickName, this.fromUserId);
                    this.btnAllow.Visible = true;
                }
                else
                {
                    this.lblMessage.Text = "û��ϵͳ��Ϣ";
                    this.btnAllow.Visible = false;
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

        // ͬ����Ӻ�������
        private void btnAllow_Click(object sender, EventArgs e)
        {
            // �Ȳ����Ƿ��Ѿ���ӹ��ˣ���ֹ�ظ����
            string sql = string.Format(
                "SELECT COUNT(*) FROM Friends WHERE HostId={0} AND FriendId={1}",
                this.fromUserId, UserHelper.loginId);  
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                int num = Convert.ToInt32(command.ExecuteScalar());

                if (num <= 0)  // û�к��Ѽ�¼
                {
                    sql = string.Format(
                        "INSERT INTO Friends (HostId, FriendId) VALUES({0},{1})",
                        this.fromUserId, UserHelper.loginId);
                    command.CommandText = sql;  // ����ָ��SQL���

                    // ִ����Ӳ���
                    command.ExecuteNonQuery();  
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
            this.Close();  // �رմ���
        }

        // �رմ���
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}