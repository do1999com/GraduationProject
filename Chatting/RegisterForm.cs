using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatting.ML;

namespace Chatting
{
    public partial class RegisterForm : Form
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
        public RegisterForm()
        {
            InitializeComponent();
        }



        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 输入验证通过，就插入记录到数据库
            if (ValidateInput()&&ValidCode())
            {
                int ChattingID = 0;     // QQ号码
                string message;      // 弹出的消息
                string sex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text; // 获得选中的性别
                string sql = "";     // 查询用的SQL语句
                int starId;          // 星座Id
                int bloodTypeId;     // 血型Id   
                bool error = false;  // 操作数据库是否出错
                int faceId=0;           //头像信息,默认为0

                // 根据星座和血型的选择来分情况确定SQL语句
                if (cboStar.Text != "" && cboBloodType.Text != "")
                {
                    // 获得星座的Id
                    starId = GetStarId();
                    // 获得血型的Id
                    bloodTypeId = GetBloodType();
                    sql = string.Format("INSERT INTO Users (LoginPwd, NickName, Sex, Age, Name, StarId, BloodTypeId,DelFlag,FaceId) values ('{0}','{1}','{2}',{3},'{4}',{5},{6},0,{7})",
                        txtLoginPwd.Text.Trim(), txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), starId, bloodTypeId, picFace.Tag);
                }
                else if (cboStar.Text != "" && cboBloodType.Text == "")
                {
                    // 获得星座的Id
                    starId = GetStarId();
                    sql = string.Format("INSERT INTO Users (LoginPwd, NickName, Sex, Age, Name, StarId,DelFlag,FaceId) values ('{0}','{1}','{2}',{3},'{4}',{5},0,{6})",
                            txtLoginPwd.Text.Trim(), txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), starId, picFace.Tag);
                }
                else if (cboStar.Text == "" && cboBloodType.Text != "")
                {
                    // 获得血型的Id
                    bloodTypeId = GetBloodType();
                    sql = string.Format("INSERT INTO Users (LoginPwd, NickName, Sex, Age, Name, BloodTypeId,DelFlag,FaceId) values ('{0}','{1}','{2}',{3},'{4}', {5},0,{6})",
                            txtLoginPwd.Text.Trim(), txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), bloodTypeId, picFace.Tag);
                }
                else
                {
                    sql = string.Format("INSERT INTO Users (LoginPwd, NickName, Sex, Age, Name,DelFlag,FaceId) values ('{0}','{1}','{2}',{3},'{4}',0,{5})",
                                txtLoginPwd.Text.Trim(), txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), picFace.Tag);
                }

                try
                {
                    // 创建 Command 对象
                    SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                    ML.DBHelper.connection.Open();             // 打开数据库连接
                    int result = command.ExecuteNonQuery(); // 执行插入命令
                    if (result == 1)
                    {
                        sql = "SELECT @@Identity FROM Users";  // 查询新增加的记录的标识号
                        command.CommandText = sql;             // 重新指定 Command 对象的 SQL 语句
                        ChattingID = Convert.ToInt32(command.ExecuteScalar());  // 强制类型转换会出错
                        message = string.Format("注册成功！你的Chatting号码是{0}", ChattingID);
                    }
                    else
                    {
                        message = "注册失败，请重试！";
                    }
                }
                catch (Exception ex)
                {
                    error = true;
                    message = "服务器出现意外错误！请稍候再试！";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ML.DBHelper.connection.Close();  // 关闭数据库连接
                }

                // 显示注册结果
                if (error)
                {
                    MessageBox.Show(message, "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }
        public static string num = "";//定义验证码
        // 窗体加载时，添加星座和血型组合框中的项
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            picFace.Tag = 0;
            // 查询星座用的sql语句
            string sql = "SELECT Star FROM Star";

            bool error = false;   // 标识操作数据库是否会出错

            try
            {
                // 添加星座组合框中的项                
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader reader = command.ExecuteReader();  // 执行查询

                while (reader.Read())
                {
                    cboStar.Items.Add((string)reader[0]);
                }
                reader.Close();

                // 添加血型组合框中的项
                sql = "SELECT BloodType FROM BloodType";  // 修改查询语句，查询血型
                command.CommandText = sql;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cboBloodType.Items.Add((string)reader[0]);
                }
                reader.Close();
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
                MessageBox.Show("服务器出现以外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          ML.ValidCodeHelper _validCode = new ValidCodeHelper(5, ValidCodeHelper.CodeType.Numbers);
            picValidCode.Image = Bitmap.FromStream(_validCode.CreateCheckCodeImage());
            num = _validCode.CheckCode;

        }
        /// <summary>
        /// 验证用户的输入
        /// </summary>        
        private bool ValidateInput()
        {
            if (picFace.Tag.ToString() == "0")
            {
                MessageBox.Show("请选择头像！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return false;
            }
            if (txtNickName.Text.Trim() == "")
            {
                MessageBox.Show("请输入昵称！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("请选择性别！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSex.Focus();
                return false;
            }
            if (txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            if (txtLoginPwdAgain.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwdAgain.Focus();
                return false;
            }
            if (txtLoginPwd.Text.Trim() != txtLoginPwdAgain.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一样！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwdAgain.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 取得星座的 Id
        /// </summary>        
        private int GetStarId()
        {
            int starId = -1;  // 返回值
            // 查询星座Id的 SQL 语句
            string sql = string.Format("SELECT Id FROM Star WHERE Star = '{0}'", cboStar.Text);
            try
            {
                // 创建 Command 对象
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();  // 打开数据库连接
                starId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }

            if (starId > 0)
            {
                return starId;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 取得血型的 Id
        /// </summary>        
        private int GetBloodType()
        {
            int bloodTypeId = -1;  // 返回值

            // 查询星座Id的 SQL 语句
            string sql = string.Format("SELECT Id FROM BloodType WHERE BloodType = '{0}'", cboBloodType.Text);
            try
            {
                // 创建 Command 对象
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();  // 打开数据库连接
                bloodTypeId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            if (bloodTypeId > 0)
            {
                return bloodTypeId;
            }
            else
            {
                return -1;
            }
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            FacesForm facefrm = new FacesForm();
            facefrm.registerForm = this;
            facefrm.ShowDialog(); 
        }
        /// <summary>
        /// 处理显示的头像
        /// </summary>
        public void ShowFace(int currentFaceId)
        {
            picFace.Image = ilFaces.Images[currentFaceId];
            picFace.Tag = currentFaceId;
        }
        /// <summary>
        /// 用户退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您似乎还没有注册,是否坚持退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                    DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picValidCode_Click(object sender, EventArgs e)
        {
            ML.ValidCodeHelper _validCode = new ValidCodeHelper(5, ValidCodeHelper.CodeType.Numbers);
            picValidCode.Image = Bitmap.FromStream(_validCode.CreateCheckCodeImage());
            num = _validCode.CheckCode;
        }

   
        //验证码验证
        private bool ValidCode()
        {
            if (txtValidCode.Text.Equals(num))

            {
                return true;
            }
            else if(string.IsNullOrEmpty(txtValidCode.Text))
            {
                MessageBox.Show("验证码必填!", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValidCode.Focus();
                return false;
            }
            else
            {
                MessageBox.Show("输入值与验证码不匹配请重新输入!", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValidCode.Focus();
                return false;
            }
        }

        private void txtValidCode_TextChanged(object sender, EventArgs e)
        {
            ValidCode();
        }
    }
}
