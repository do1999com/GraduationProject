using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using Chatting.ML;

namespace Chatting
{
   
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
        }


        // 用户输入验证
        private bool ValidateInput()
        {
            // 验证用户输入
            if (txtLoginId.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录的号码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginId.Focus();//光标移到帐号框
                return false;
            }
            else if (txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            return true;
        }
        // 登录按钮事件处理
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = true;//数据库执行
            // 如果输入验证成功，就验证身份，并转到相应的窗体
            if (ValidateInput())
            {
                int num = 0;  // 查看数据库是否有此帐号密码   

                try
                {
                    // 查询用的sql语句  
                    //string sql = string.Format("SELECT COUNT(*) FROM Users WHERE Id={0} AND LoginPwd = '{1}'",
                    //    int.Parse(txtLoginId.Text.Trim()), txtLoginPwd.Text.Trim());

                    //用参数化sql语句
                    string sql = "SELECT COUNT(*) FROM Users WHERE Id=@Id AND LoginPwd = @LoginPwd and DelFlag=0";
                    // 创建Command 对象
                    SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(txtLoginId.Text.Trim());
                    command.Parameters.Add("@LoginPwd", SqlDbType.VarChar).Value = txtLoginPwd.Text.Trim();

                    ML.DBHelper.connection.Open();  // 打开数据库连接
                    num = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ML.DBHelper.connection.Close();  // 关闭数据库连接
                }

                if (success && num == 1)
                {
                    // 设置登录的用户号码
                    UserHelper.loginId = int.Parse(txtLoginId.Text.Trim());
                    // 创建主窗体
                    MainForm mainForm = new MainForm();
                    mainForm.Show();  // 显示窗体
                    this.Visible = false;  // 当前窗体不可见
                }
                else
                {
                    MessageBox.Show("请检查输入或者用户被封禁！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //取消按钮事件处理
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出程序
        }

        //当账号框失焦头像框的事件处理
        private void txtLoginPwd_Enter(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtLoginId.Text.Trim()))//判断用户是否有输入
                {
                    // 查询用的sql语句
                    //string sql = string.Format("SELECT FaceId FROM Users WHERE Id={0}",
                    //    int.Parse(txtLoginId.Text.Trim()));
                    //防止sql注入使用参数sql语句 
                    string sql = "SELECT FaceId FROM Users WHERE Id=@Id";
                    
                    //// 创建Command 对象
                    SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(txtLoginId.Text.Trim());

                    int faceId;
                    ML.DBHelper.connection.Open();  // 打开数据库连接
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read() && !(dataReader["FaceId"] is DBNull))
                    {
                        faceId = Convert.ToInt32(dataReader["FaceId"]);
                        //            //MessageBox.Show(faceId.ToString());
                        this.picFace.Image = ilFaces.Images[faceId];

                    }
                    // ML.DBHelper.connection.Close();//数据库关闭一般要在finnally中
                    dataReader.Close();//此处收尾一定要全部关闭,防止再次循环报错
                }
            }
            catch
            {
                MessageBox.Show("帐号为纯数字,请勿加入非法字符!");
            }
            finally
            {
               ML.DBHelper.connection.Close();
                
            }
        }

        // 打开申请号码界面
        private void llblRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();//注册页面展开
                                ////采用类似qq的网页注册方式
                                // Process ps=new Process();



        }



        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //btnLogin.BackgroundImage = Image.FromFile(@"~\images\btnLoginB.png");
        }


        private void llblMyBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserHelper.OpenBrowserUrl("www.duwenink.cn");
        }
        //密码找回
        private void llblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //远程IIS放置页面:
            BrowserHelper.OpenBrowserUrl("http://ip.duwenink.cn:2511/Suggestions/RegetPassword.aspx");
        }

        private void llblSuggestions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserHelper.OpenBrowserUrl("http://ip.duwenink.cn:2511/Suggestions/Login.aspx");
        }
    }
}
