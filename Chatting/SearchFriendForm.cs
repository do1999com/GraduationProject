using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Chatting;
using Chatting.ML;

namespace Chatting
{
    /// <summary>
    /// 查找和添加好友窗体
    /// </summary>
    public partial class SearchFriendForm : Form
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
        private DataSet dataSet;  // 数据集
        private SqlDataAdapter dataAdapter;  // 数据适配器
        
        public SearchFriendForm()
        {
            InitializeComponent();
        }

        // 窗体加载时，填充数据集
        private void SearchFriendForm_Load(object sender, EventArgs e)
        {
            // 实例化数据集和数据适配器并填充
            string sql = "SELECT Id, NickName, Age, Sex FROM Users";
            dataAdapter = new SqlDataAdapter(sql, ML.DBHelper.connection);            
            dataSet = new DataSet("Chatting");
            dataAdapter.Fill(dataSet, "Users");

            // 指定DataGridView的数据源
            dgvBasicResult.DataSource = dataSet.Tables[0];
            dgvAdvancedResult.DataSource = dataSet.Tables[0];
        }

        // 点击查找按钮时，查找符合条件的用户
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabSearch.SelectedIndex == 0) // 基本查找选显卡选中
            {
                BasicallySearch();
            }
            else  // 高级查找选项卡选中
            {
                AdvancedSearch();
            }
        }

        // 添加好友
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int friendshipPolicyId = -1;  // 对方的好友策略            

            int friendId = GetSelectedFriendId();  // 获得选中的好友的Id

            // 是否有可添加的好友
            if (friendId == -1)
            {
                MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (friendId == UserHelper.loginId)
            {
                MessageBox.Show("不能加自己为好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (HasAdded(friendId))  // 确认是否需要添加（是否已经是好友了）
            {
                MessageBox.Show("对方已在你的好友列表中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 确认对方能否被加为好友
            friendshipPolicyId = GetFriendshipPolicyId(friendId);
                        
            if (friendshipPolicyId == 3) // 3表示不允许任何人添加，在S2可以使用常量或枚举
            {
                MessageBox.Show("对方不允许任何人加他为好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (friendshipPolicyId == 2) // 2：表示需要身份验证
            {
                int result = SendRequest(friendId);  // 发验证消息
                if (result == 1)
                {
                    MessageBox.Show("对方需要身份验证才能被加为好友，已发出请求！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
            else if (friendshipPolicyId == 1) // 1：表示允许任何人添加为好友
            {
                // 执行添加操作
                int result = AddFriend(friendId);
                if (result == 1)
                {
                    MessageBox.Show("添加成功，请刷新好友列表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 当切换页时，把与查找结果相关的控件都隐藏
        private void tabSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;
            pnlAdvancedResult.Visible = false;
            btnAdd.Visible = false;
            btnBack.Visible = false;
        }

        // 控制精确查找选项是否可见
        private void rdoNicetySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNicetySearch.Checked == true)
            {
                grpBaseCondition.Visible = true;
            }
            else
            {
                grpBaseCondition.Visible = false;
            }
        }

        // 返回到上一步
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;
            pnlAdvancedResult.Visible = false;
            pnlBaseCondition.Visible = true;
            pnlAdvancedCondition.Visible = true;
            btnBack.Visible = false;
            btnAdd.Visible = false;            
        }

        // 关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 基本查找
        /// </summary>
        private void BasicallySearch()
        {
            string sql = "";
            // 查询语句的前半部分
            sql = "SELECT Id,NickName,Age,Sex FROM Users";
            
            // 精确查找
            if (rdoNicetySearch.Checked == true)
            {
                if (txtLoginId.Text.Trim() == "" && txtNickName.Text.Trim() == "")
                {
                    MessageBox.Show("还没有填查询条件呢！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // 按帐号查找
                else if (txtLoginId.Text.Trim() != "")  
                {
                    sql += string.Format(" WHERE Id={0}", int.Parse(txtLoginId.Text.Trim()));
                }
                // 按昵称查找
                else
                {
                    sql += string.Format(" WHERE NickName like '%{0}%'", txtNickName.Text.Trim());
                 }                
            }

            // 重新填充DataSet
            dataSet.Tables[0].Clear();
            dataAdapter.SelectCommand.CommandText = sql;
            dataAdapter.Fill(dataSet,"Users"); 

            // 设置控件可见的属性
            // 调整显示结果的panel的位置，让它和显示条件的Panel的位置相同
            pnlBaseResult.Location = pnlBaseCondition.Location;
            // 使显示结果的panel可见
            pnlBaseResult.Visible = true;
            btnAdd.Visible = true;　　//“加为好友”按钮可见
            btnBack.Visible = true;   //“上一步”按钮可见
        }

        /// <summary>
        /// 高级查找
        /// </summary>
        private void AdvancedSearch()
        {
            string sql = "";
            // 查询语句的前半部分
            sql = "SELECT Id,NickName,Age,Sex FROM Users";

            string ageCondition = "";  // 年龄条件
            string sexCondition = cboSex.Text;  // 性别条件

            // 确定年龄的范围
            switch (cboAge.SelectedIndex)
            { 
                case 1:
                    ageCondition = " Age>=0 AND Age<10";
                    break;
                case 2:
                    ageCondition = " Age>=10 AND Age<20";
                    break;
                case 3:
                    ageCondition = " Age>=20 AND Age<30";
                    break;
                case 4:
                    ageCondition = " Age>=30 AND Age<40";
                    break;
                case 5:
                    ageCondition = " Age>=40 AND Age<50";
                    break;
                case 6:
                    ageCondition = " Age>=50";
                    break;
                default:
                    ageCondition = "";
                    break;
            }

            if (ageCondition == "" && sexCondition == "")
            {
                MessageBox.Show("还没有选择查询条件呢！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                if (ageCondition != "" && sexCondition == "")
                {
                    sql += string.Format(" WHERE {0}", ageCondition);
                }
                else if (ageCondition == "" && sexCondition != "")
                {
                    sql += string.Format(" WHERE Sex='{0}'", sexCondition);
                }
                else
                { 
                    sql += string.Format(" WHERE {0} AND Sex='{1}'",ageCondition,sexCondition);
                }
            }

            // 开始查找
            dataAdapter.SelectCommand.CommandText = sql;
            dataSet.Tables[0].Clear();
            dataAdapter.Fill(dataSet, "Users");

            // 设置控件的属性
            pnlAdvancedResult.Location = pnlAdvancedCondition.Location;
            pnlAdvancedResult.Visible = true;                                  
            btnAdd.Visible = true;
            btnBack.Visible = true;
        }        
        
        /// <summary>
        /// 获得选中的好友的Id
        /// </summary>        
        private int GetSelectedFriendId()
        {
            int friendId = -1;  // 好友的号码

            // 基本查找
            if (tabSearch.SelectedIndex == 0)
            {
                // 没有选中任何一行
                if (dgvBasicResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选择一个好友！", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // 确保第一个单元格有值
                else if (dgvBasicResult.SelectedRows[0].Cells[0] != null)  
                {
                    // 获得DataGridView中选中的行的第一个单元格的值
                    friendId = int.Parse(dgvBasicResult.SelectedRows[0].Cells[0].Value.ToString());                   
                }
            }
            // 高级查找
            else if (tabSearch.SelectedIndex == 1)
            {
                if (dgvAdvancedResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选择一个好友！", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvAdvancedResult.SelectedRows[0].Cells[0] != null)
                {
                    friendId = int.Parse(dgvAdvancedResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }

            return friendId;
        }

        /// <summary>
        /// 确认对方能否被加为好友
        /// </summary>        
        private int GetFriendshipPolicyId(int userId)
        {
            int friendshipPolicyId = 1;  // 好友策略
            string sql = "SELECT FriendshipPolicyId FROM Users WHERE Id=" + userId;
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();

                friendshipPolicyId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            return friendshipPolicyId;
        }

        /// <summary>
        /// 查找好友是否已被添加
        /// </summary>        
        private bool HasAdded(int friendId)
        {
            int result = 0;  // 查找结果
            bool returnValue; // 返回值
            string sql = string.Format(
                "SELECT COUNT(*) FROM Friends WHERE HostId={0} AND FriendId={1}",
                UserHelper.loginId, friendId);
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }

            // 已有记录存在
            returnValue = result > 0 ? true : false;
            return returnValue;
        }

        /// <summary>
        /// 执行添加好友的操作
        /// </summary>        
        private int AddFriend(int friendId)
        {
            int resunlt = 0; // 操作结果
            string sql = string.Format("INSERT INTO FRIENDS (HostId, FriendId) VALUES ({0},{1})",
                UserHelper.loginId, friendId);

            try
            {
                // 执行添加操作
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                resunlt = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            return resunlt;
        }

        /// <summary>
        /// 发出添加好友请求
        /// </summary>        
        private int SendRequest(int friendId)
        {
            int resunlt = 0; // 操作结果
            string sql = string.Format("INSERT INTO Messages (FromUserId, ToUserId, MessageTypeId, MessageState) VALUES ({0},{1},{2},{3})",
                UserHelper.loginId, friendId,2,0);

            try
            {
                // 执行添加操作
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                resunlt = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            return resunlt;
        }
    }
}