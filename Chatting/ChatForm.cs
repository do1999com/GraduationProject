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
    /// 聊天窗体
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
                case WM_NCHITTEST://鼠标点任意位置后可以拖动窗体

                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        m.Result = new IntPtr(HTCAPTION);
                        return;
                    }
                    break;
                case WM_NCLBUTTONDBLCLK://禁止双击最大化
                    Console.WriteLine(this.WindowState);

                    return;
                    break;
                default:

                    base.WndProc(ref m);
                    break;
            }
        }
        public int friendId;     // 当前聊天的好友号码
        public string nickName;  // 当前聊天的好友昵称
        public int faceId;       // 当前聊天的好友头像Id        

        public ChatForm()
        {
            InitializeComponent();
        }

        // 窗体加载时的动作
        private void ChatForm_Load(object sender, EventArgs e)
        {
            // 设置窗体标题
            this.Text = string.Format("与{0}聊天中",nickName);

            // 设置窗体顶部显示的好友信息
            picFace.Image = ilFaces.Images[faceId];
            lblFriend.Text = string.Format("{0}({1})  ",nickName,friendId)+ GetTodayFeel();
            GetTodayFeel();
            // 读取所有的未读消息，显示在窗体中
            ShowMessage();
        }
        /// <summary>
        /// 获取好友的个性签名
        /// </summary>
        /// <returns></returns>
        private string GetTodayFeel()
        {
            List<classTodayFeel> feelList = new List<classTodayFeel>();
            string sql = "select TodayFeel from Users where Id=@Id";
            bool error = false;    // 标识是否出现错误
            try
            {
                //// 创建Command 对象
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = friendId;
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    classTodayFeel todayFeel = new classTodayFeel();
                    todayFeel.TodayFeel = dataReader["TodayFeel"] == DBNull.Value ? "我太懒了,连个性签名都没有.." : dataReader["TodayFeel"].ToString();
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
            // 出错了
            if (error)
            {
                MessageBox.Show("服务器发生意外错误！请尝试重新登录", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return feelList[0].TodayFeel;
        }

        // 关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChat.Text.Trim() == "") // 不能发送空消息
            {
                MessageBox.Show("不能发送空消息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtChat.Text.Trim().Length > 50)
            {
                MessageBox.Show("消息内容过长，请分为几条发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else  // 发送消息，写入数据库
            {
                // MessageTypeId:1-表示聊天消息，为简化操作没有读取数据表，到S2可以用常量或者枚举实现
                // MessageState:0-表示消息状态是未读
                int result = -1; // 表示操作数据库的结果
                string sql = string.Format(
                    "INSERT INTO Messages (FromUserId, ToUserId, Message, MessageTypeId, MessageState) VALUES ({0},{1},'{2}',{3},{4})",
                    UserHelper.loginId, friendId, txtChat.Text.Trim(), 1, 0);
                try
                {
                    // 执行命令
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
                    MessageBox.Show("服务器出现意外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMessages.Text += "我说:"+DateTime.Now+"\r\n" + "  " + txtChat.Text+ "\r\n";
                if (txtMessages.Text.Length > 800)//防止文字过长影响观看
                {
                    txtMessages.Text = "我说:" + DateTime.Now + "\r\n" + "  "+txtChat.Text + "\r\n";
                }
                txtChat.Text = "";  // 输入消息清空
             
            }
        }
        /// <summary>
        /// 读取所有的未读消息，显示在窗体中
        /// </summary>
        private void ShowMessage()
        {
            string messageIdsString = "";  // 消息的Id组成的字符串
            string message;         // 消息内容
            string messageTime;     // 消息发出的时间

            // 读取消息的SQL语句
            string sql = string.Format(
                "SELECT Id, Message,MessageTime From Messages WHERE FromUserId={0} AND ToUserId={1} AND MessageTypeId=1 AND MessageState=0",
                friendId,UserHelper.loginId);
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // 循环将消息添加到窗体上
                while (reader.Read())
                {
                    messageIdsString += Convert.ToString(reader["Id"]) + "_";
                    message = Convert.ToString(reader["Message"]);
                    messageTime = Convert.ToDateTime(reader["MessageTime"]).ToString(); // 转换为日期类型
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
            // 把显示出的消息置为已读
            if (messageIdsString.Length > 1)
            {
                messageIdsString.Remove(messageIdsString.Length - 1);
                SetMessageRead(messageIdsString, '_');
            }            
        }

        /// <summary>
        /// 把显示出的消息置为已读
        /// </summary>        
        private void SetMessageRead(string messageIdsString, char separator)
        {
            string[] messageIds = messageIdsString.Split(separator);     // 分割出每个消息Id
            string sql = "Update Messages SET MessageState=1 WHERE Id="; // 更新状态的SQL语句的固定部分
            string updateSql;  // 执行的SQL语句
            try
            {
                SqlCommand command = new SqlCommand();     // 创建Command对象
                command.Connection = ML.DBHelper.connection;  // 指定数据库连接
                ML.DBHelper.connection.Open();                // 打开数据库连接
                foreach (string id in messageIds)
                {
                    if (id != "")
                    {
                        updateSql = sql + id;              // 补充完整的SQL语句
                        command.CommandText = updateSql;   // 指定要执行的SQL语句
                        int result = command.ExecuteNonQuery();  // 执行命令
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