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
    /// 好友添加请求消息窗体
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
        int fromUserId;  // 发起请求的用户Id

        public RequestForm()
        {
            InitializeComponent();
        }

        // 窗体加载时，取出请求消息显示
        private void RequestForm_Load(object sender, EventArgs e)
        {
            int messageId = 0; // 消息的Id

            // 找到发给当前用户的请求消息
            string sql = string.Format(
                "SELECT Top 1 Id, FromUserId FROM Messages WHERE ToUserId={0} AND MessageTypeId=2 AND MessageState=0",
                UserHelper.loginId);
            try
            {
                // 查找一个未读消息
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.Read())                
                {
                    messageId = (int)dataReader["Id"];
                    this.fromUserId = (int)dataReader["FromUserId"];
                }
                dataReader.Close();

                // 将消息状态置为已读
                sql = "UPDATE Messages SET MessageState =1 WHERE Id="+messageId;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                // 读取请求人的信息，显示在窗体上
                sql = "SELECT NickName, FaceId FROM Users WHERE Id="+this.fromUserId;
                command.CommandText = sql;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int faceId = (int)dataReader["FaceId"];
                    string nickName = (string)dataReader["NickName"];
                    this.picIcon.Image = ilIcons.Images[faceId];
                    this.lblMessage.Text = string.Format("{0}({1})请求添加您为好友",
                        nickName, this.fromUserId);
                    this.btnAllow.Visible = true;
                }
                else
                {
                    this.lblMessage.Text = "没有系统消息";
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

        // 同意添加好友请求
        private void btnAllow_Click(object sender, EventArgs e)
        {
            // 先查找是否已经添加过了，防止重复添加
            string sql = string.Format(
                "SELECT COUNT(*) FROM Friends WHERE HostId={0} AND FriendId={1}",
                this.fromUserId, UserHelper.loginId);  
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                int num = Convert.ToInt32(command.ExecuteScalar());

                if (num <= 0)  // 没有好友记录
                {
                    sql = string.Format(
                        "INSERT INTO Friends (HostId, FriendId) VALUES({0},{1})",
                        this.fromUserId, UserHelper.loginId);
                    command.CommandText = sql;  // 重新指定SQL语句

                    // 执行添加操作
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
            this.Close();  // 关闭窗体
        }

        // 关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}