using Aptech.UI;
using Chatting.GetMyCityName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatting.ML;

namespace Chatting
{
    public partial class MainForm : Form
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
        int fromUserId;  　// 消息的发起者
        int friendFaceId;  // 发消息的好友的头像Id  
        bool IconFlag = true;//用来标识任务栏图标闪动
        int messageImageIndex = 0;  // 工具栏中的消息图标的索引
        public MainForm()
        {
            InitializeComponent();
        }
        public void ShowSelfInfo()
        {
            string nickName = "";  // 昵称
            int faceId = 0;        // 头像索引
            bool error = false;    // 标识是否出现错误

            // 取得当前用户的昵称、头像
            string sql = string.Format(
                "SELECT NickName, FaceId FROM Users WHERE Id={0}",
                UserHelper.loginId);
            try
            {
                // 查询
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    if (!(dataReader["NickName"] is DBNull))  // 判断数据库类型是否为空
                    {
                        nickName = Convert.ToString(dataReader["NickName"]);
                    }
                    faceId = Convert.ToInt32(dataReader["FaceId"]);
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

            // 根据操作数据库结果进行不同的操作
            if (error)
            {
                MessageBox.Show("服务器请求失败！请重新登录！", "意外错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                // 在窗体标题显示登录的昵称、号码
                this.Text = "欢迎您:"+UserHelper.loginId.ToString();
                this.picFace.Image = ilFaces.Images[faceId];
                this.lblLoginId.Text = string.Format("{0}({1})", nickName, UserHelper.loginId.ToString());
            }
        
        }
 

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // 工具栏的消息图标
            tsbtnMessageReading.Image = ilMessage.Images[0];
            //显示个人信息
            ShowSelfInfo();
            // 添加 SideBar 的两个组
            sbFriends.AddGroup("我的好友");
            sbFriends.AddGroup("陌生人");
            sbFriends.AddGroup("Chatting群");
           
            // 向我的好友组中添加我的好友列表
            ShowFriendList();
            //在系统托盘中显示图标
            string startup = Application.ExecutablePath;       // 取得程序路径   
            int pp = startup.LastIndexOf("\\");
            startup = startup.Substring(0, pp);
            string icon = startup + "\\logo.ico";

            //3. 一定为 notifyIcon1 其设置图标，否则无法显示在通知栏。或者在其属性中设置
            niTaskIcon.Icon = new Icon(icon);
            try
            {
                //显示天气信息
                ShowWeatherInfo(); //有时候webservice会因为网络服务挂掉,这样用户就有一场了
               // int a = Convert.ToInt32("s") ;
            }
            catch
            {
                if (MessageBox.Show("天气服务器连接异常,是否继续?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                    DialogResult.No)
                {
                    Application.Exit();
                }
            }
           // MessageBox.Show(ShowCityByIP());
        }
        /// <summary>
        /// 显示天气信息
        /// </summary>
        private void ShowWeatherInfo()
        {
            string myCityName = ShowCityByIP();
            Weather.WeatherWebService wwssc = new Weather.WeatherWebService();
            // 把 webservice 当做一个类来操作  
            string[] s = new string[23];// 声明 string 数组存放返回结果  
            string city = myCityName;// 获得文本框录入的查询城市  先写死
            s = wwssc.getWeatherbyCityName(city);
            // 以文本框内容为变量实现方法 getWeatherbyCityName  
            if (s[4] == ""||s[5] == ""||s[7] == "")
            {
                lbShowWeather.Text = "暂无该城市的信息!";
            }
            else
            {
                lbWeatherMessage.Text = "今日是:"+s[6];
            }
            string weatherMessage = "今日:"+s[6]+"\r\n气温:"+s[5]+"\r\n风向:"+s[7]+"\r\n您的IP:"+ GetMyIpFromMyServer()+ "\r\n";
            weatherMessage += "上次登陆IP:"+ ShowTimeAndIP();
            tTWeatherMessage.SetToolTip(lbShowWeather, weatherMessage);
        }
        /// <summary>
        /// 从服务器获得本地的外网IP
        /// </summary>
        /// <returns></returns>
        public static string GetMyIpFromMyServer()
        {                    //http://115.159.107.202:2511/whatismyip.ashx
            string serverIP = "http://ip.duwenink.cn:2511/whatismyip.ashx";//架设在服务器上的iis,放了一个返回ip的页面
            string myTencentCould = "http://www.duwenink.cn/whatismyip";//服务器ip:115.159.126.99,备用一下,linux+php
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(serverIP);
                }
            }
            catch
            {//备用方案
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(myTencentCould);
                }
            }
        }
        //根据城市显示ip信息
        public static string ShowCityByIP()
        {
            GetMyCityName.IpAddressSearchWebService iss = new IpAddressSearchWebService();
            string myIP = GetMyIpFromMyServer();
            string[] str = iss.getCountryCityByIp(myIP);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    //Console.WriteLine("s{0}是:{1}", i, str[i]);
            //    /*s0是:114.222.129.93
            //      s1是:江苏省南京市 电信*/
            //}
            int startIndex = str[1].IndexOf('省')+1;
            int endIndex = str[1].IndexOf('市');
            string cityName = str[1].Substring(startIndex, endIndex - startIndex);
            return cityName;//切割字符串最后返回城市名 如 南京
        }

        /// <summary>
        /// 显示个性签名
        /// </summary>
        private void ShowTodayFeel()
        {
            List<classTodayFeel> feelList = new List<classTodayFeel>();
            string sql = "select TodayFeel from Users where Id=@Id";
            bool error = false;    // 标识是否出现错误
            try
            {
               //// 创建Command 对象
            SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = UserHelper.loginId;
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    classTodayFeel todayFeel = new classTodayFeel();
                    todayFeel.TodayFeel= dataReader["TodayFeel"] == DBNull.Value ? "在这里写下您的个性签名.." : dataReader["TodayFeel"].ToString();
                    feelList.Add(todayFeel);
                }
                txtFeel.Text = feelList[0].TodayFeel;
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

        }

        /// <summary>
        /// 向我的好友组中添加我的好友列表
        /// </summary>
        private void ShowFriendList()
        {
            // 清空原来的列表
            sbFriends.Groups[0].Items.Clear();

            bool error = false;   // 标识数据库是否出错

            // 查找有哪些好友
            string sql = string.Format(
                "SELECT FriendId,NickName,FaceId FROM Users,Friends WHERE Friends.HostId={0} AND Users.Id=Friends.FriendId",
                UserHelper.loginId);
            try
            {
                // 执行查询
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                // 循环添加好友列表
                while (dataReader.Read())
                {
                    // 创建一个SideBar项
                    SbItem item = new SbItem((string)dataReader["NickName"], (int)dataReader["FaceId"]);
                    item.Tag = (int)dataReader["FriendId"]; // 将号码放在Tag属性中

                    // SideBar中的组可以通过数组的方式访问，按照添加的顺序索引从0开始
                    // Groups[0]表示SideBar中的第一个组，也就是“我的好友”组
                    sbFriends.Groups[0].Items.Add(item); // 向SideBar的“我的好友”组中添加项
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
        }

 
        /// <summary>
        /// 判断发消息的人是否在列表中
        /// </summary>        
        private bool HasShowUser(int loginId)
        {
            bool find = false;  // 表示是否在当前显示出的用户列表中找到了该用户

            // 循环 SideBar 中的2个组，寻找发消息的人是否在列表中
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < sbFriends.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(sbFriends.Groups[i].Items[j].Tag) == loginId)
                    {
                        find = true;
                    }
                }
            }
            return find;
        }

        /// <summary>
        /// 更新陌生人列表
        /// </summary>        
        private void UpdateStranger(int loginId)
        {
            // 选出这个人的基本信息
            string sql = "SELECT NickName, FaceId FROM Users WHERE Id=" + loginId;
            bool error = false; // 用来标识是否出现错误
            try
            {
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader(); // 查询
                if (dataReader.Read())
                {
                    SbItem item = new SbItem((string)dataReader["NickName"], (int)dataReader["FaceId"]);
                    item.Tag = this.fromUserId;           // 将Id记录在Tag属性中
                    sbFriends.Groups[1].Items.Add(item);  // 向陌生人组中添加项
                }
                sbFriends.VisibleGroup = sbFriends.Groups[1];  // 设定陌生人组为可见组
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
                MessageBox.Show("服务器出现意外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFeel_TextChanged(object sender, EventArgs e)
        {
            UpdateFeel(txtFeel.Text);
        }
        //更新个性签名
        private void UpdateFeel(string todayFeel)
        {
            todayFeel = txtFeel.Text.Trim();
            if (todayFeel.Length > 30)
            {
                MessageBox.Show("字数只能在30字以内,请返回修改!");
                txtFeel.Text = todayFeel.Substring(0, 28);
                
                //txtFeel.Focus();
                txtFeel.SelectionStart = txtFeel.TextLength;
                //UpdateFeel(txtFeel.Text);


            }
            else { 
            try
            {
                if (!string.IsNullOrEmpty(todayFeel))//判断用户是否有输入
                {
                    // 查询用的sql语句

                    string sql = "update Users set TodayFeel=@TodayFeel where id=@id";

                    //// 创建Command 对象
                    SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                    command.Parameters.Add("@TodayFeel", SqlDbType.Text).Value = todayFeel;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = UserHelper.loginId;

                    ML.DBHelper.connection.Open();  // 打开数据库连接
                    command.ExecuteNonQuery();

                }
            }
            catch
            {
                //  MessageBox.Show("此功能可能异常了,请联系管理员,谢谢!");
            }
            finally
            {
                ML.DBHelper.connection.Close();

            }
            }
        }

        //更新个性签名
        private void UpdateLastLoginIP()
        {
            string lastLoginIP = GetMyIpFromMyServer();
           
                try
                {
                    if (!string.IsNullOrEmpty(lastLoginIP))//判断用户是否有输入
                    {
                        // 查询用的sql语句

                        string sql = "update Users set LastLoginIP=@LastLoginIP where id=@id";

                        //// 创建Command 对象
                        SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                        command.Parameters.Add("@LastLoginIP", SqlDbType.Text).Value = lastLoginIP;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = UserHelper.loginId;

                        ML.DBHelper.connection.Open();  // 打开数据库连接
                        command.ExecuteNonQuery();

                    }
                }
                catch
                {
                    //  MessageBox.Show("此功能可能异常了,请联系管理员,谢谢!");
                }
                finally
                {
                    ML.DBHelper.connection.Close();

                }
            
        }
        //退出
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确实要退出吗？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // 双击一项，弹出聊天窗体 
        private void sbFriends_ItemDoubleClick(SbItemEventArgs e)
        {
            // 消息timer停止运行
            if (tmrChatRequest.Enabled)
            {
                tmrChatRequest.Stop();
                e.Item.ImageIndex = friendFaceId;
            }

            // 显示聊天窗体
            ChatForm chatForm = new ChatForm();
            chatForm.friendId = Convert.ToInt32(e.Item.Tag); // 号码
            chatForm.nickName = e.Item.Text;  // 昵称
            chatForm.faceId = e.Item.ImageIndex;  // 头像
            chatForm.Show();
        }
        // 可见组发生变化时，发出声音
        private void sbFriends_VisibleGroupChanged(SbGroupEventArgs e)
        {
            SoundPlayer player = new SoundPlayer("folder.wav");
            player.Play();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //显示个性签名
            ShowTodayFeel();
            //显示登录时间,以及上次登陆ip
            // ShowTimeAndIP();
            UpdateLastLoginIP();
        }
        //显示上次登陆时间,以及上次登陆ip
        private static string ShowTimeAndIP()
        {
            List<classLastloginIP> LastLoginIPList = new List<classLastloginIP>();
            string sql = "select LastLoginIP from Users where Id=@Id";
            bool error = false;    // 标识是否出现错误
            try
            {
                //// 创建Command 对象
                SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = UserHelper.loginId;
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    classLastloginIP lastLoginIP = new classLastloginIP();
                    lastLoginIP.LastloginIP = dataReader["LastLoginIP"] == DBNull.Value ? "抱歉,上一次IP信息丢失" : dataReader["LastLoginIP"].ToString();
                    LastLoginIPList.Add(lastLoginIP);
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
            return LastLoginIPList[0].LastloginIP;
        }

        // 显示个人信息窗体
        private void tsbtnPersonalInfo_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfoForm = new PersonalInfoForm();
            personalInfoForm.mainForm = this;  // 将当前窗体本身传给个人信息窗体
            personalInfoForm.ShowDialog();
        }
        // 显示查找好友窗体
        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            SearchFriendForm searchFriendForm = new SearchFriendForm();
            searchFriendForm.ShowDialog();
        }
        //显示大小头像切换
        private void tsmiView_Click(object sender, EventArgs e)
        {
            if (sbFriends.View == SbView.LargeIcon)
            {
                sbFriends.View = SbView.SmallIcon;
                tsmiView.Text = "松散模式";
            }
            else if (sbFriends.View == SbView.SmallIcon)
            {
                sbFriends.View = SbView.LargeIcon;
                tsmiView.Text = "紧凑模式";
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;   // 对话框结果
            int deleteResult = 0;  // 操作结果
            if (sbFriends.SeletedItem != null)
            {
                result = MessageBox.Show("确实要删除该好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) // 确认删除
                {
                    if (sbFriends.VisibleGroup == sbFriends.Groups[0])
                    {
                        string sql = string.Format(
                            "DELETE FROM Friends WHERE HostId={0} AND FriendId={1}",
                            UserHelper.loginId, Convert.ToInt32(sbFriends.SeletedItem.Tag));

                        try
                        {
                            SqlCommand command = new SqlCommand(sql, ML.DBHelper.connection);
                            ML.DBHelper.connection.Open();
                            deleteResult = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            ML.DBHelper.connection.Close();
                        }
                        if (deleteResult == 1)
                        {
                            MessageBox.Show("好友已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sbFriends.SeletedItem.Parent.Items.Remove(sbFriends.SeletedItem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("好友已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sbFriends.SeletedItem.Parent.Items.Remove(sbFriends.SeletedItem);
                    }
                }
            }
        }

        private void tsmiAddFriend_Click(object sender, EventArgs e)
        {
            int result = 0;  // 操作结果
            string sql = string.Format(
                "INSERT INTO Friends (HostId, FriendId) VALUES({0},{1})",
                UserHelper.loginId, Convert.ToInt32(sbFriends.SeletedItem.Tag));

            try
            {
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
            if (result == 1)
            {
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sbFriends.SeletedItem.Parent.Items.Remove(sbFriends.SeletedItem);
                ShowFriendList();   // 更新好友列表             
            }
            else
            {
                MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmrAddFriend.Stop();  // 消息timer停止运行 
            // 图片恢复正常
            messageImageIndex = 0;
            tsbtnMessageReading.Image = ilMessage.Images[messageImageIndex];

            // 显示系统消息窗体
            RequestForm requestForm = new RequestForm();
            requestForm.ShowDialog();
        }
        //定时扫描数据库,找到未读消息
        private void tmrMessage_Tick(object sender, EventArgs e)
        {
            ShowFriendList();       // 刷新好友列表
            int messageTypeId = 1;  // 消息类型
            int messageState = 1;   // 消息状态

            // 找出未读消息对应的好友Id
            string sql = string.Format(
                "SELECT Top 1 FromUserId, MessageTypeId, MessageState FROM Messages WHERE ToUserId={0} AND MessageState=0", UserHelper.loginId);
            SqlCommand command;

            // 消息有两种类型：聊天消息、添加好友消息
            try
            {
                command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                // 循环读出一个未读消息
                if (dataReader.Read())
                {
                    this.fromUserId = (int)dataReader["FromUserId"];
                    messageTypeId = (int)dataReader["MessageTypeId"];
                    messageState = (int)dataReader["MessageState"];
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }

            // 判断消息类型，如果是添加好友消息，就启动喇叭timer，让小喇叭闪烁
            if (messageTypeId == 2 && messageState == 0)
            {
                SoundPlayer player = new SoundPlayer("system.wav");
                player.Play();
                tmrAddFriend.Start();
            }
            // 如果是聊天消息，就启动聊天timer，让好友头像闪烁
            else if (messageTypeId == 1 && messageState == 0)
            {
                // 获得发消息的人的头像Id
                sql = "SELECT FaceId FROM Users WHERE Id=" + this.fromUserId;
                try
                {
                    command = new SqlCommand(sql, ML.DBHelper.connection);
                    ML.DBHelper.connection.Open();
                    this.friendFaceId = Convert.ToInt32(command.ExecuteScalar());   // 设置发消息的好友的头像索引
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    ML.DBHelper.connection.Close();
                }

                // 如果发消息的人没有在列表中就添加到陌生人列表中
                if (!HasShowUser(fromUserId))
                {
                    UpdateStranger(fromUserId);
                }
                SoundPlayer player = new SoundPlayer("msg.wav");
                player.Play();
                tmrChatRequest.Start();  // 启动闪烁头像定时器
                
            }
        }
        //控制喇叭闪烁
        private void tmrAddFriend_Tick(object sender, EventArgs e)
        {
            // 反复修改它的图像
            messageImageIndex = messageImageIndex == 0 ? 1 : 0;
            tsbtnMessageReading.Image = ilMessage.Images[messageImageIndex];
        }

        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void cmsFriendList_Opening(object sender, CancelEventArgs e)
        {
            // 如果没有选中的项
            if (sbFriends.SeletedItem == null)
            {
                tsmiDelete.Visible = false;
            }
            else
            {
                tsmiDelete.Visible = true;
            }

            // 如果选中的是陌生人，显示加为好友菜单
            if (sbFriends.SeletedItem != null && sbFriends.SeletedItem.Parent == sbFriends.Groups[1])
            {
                tsmiAddFriend.Visible = true;
            }
            else
            {
                tsmiAddFriend.Visible = false;
            }
        }

        private void tmrChatRequest_Tick(object sender, EventArgs e)
        {
            // 循环好友列表两个组中的每个item，找到发消息的好友，让他的头像闪烁
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < sbFriends.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(sbFriends.Groups[i].Items[j].Tag) == this.fromUserId)
                    {
                        if (sbFriends.Groups[i].Items[j].ImageIndex < 51)
                        {
                            sbFriends.Groups[i].Items[j].ImageIndex = 51;// 索引为51的图片是一个空白图片
                        }
                        else
                        {
                            sbFriends.Groups[i].Items[j].ImageIndex = this.friendFaceId;
                        }
                        sbFriends.Invalidate();  // 重新绘制
                        
                    }
                }
            }
            // niTaskIcon.Icon = ilFaces.Images[fromUserId]
            //System.IO.MemoryStream mStream = new System.IO.MemoryStream();// 创建内存流 
            //ilFaces.Images[friendFaceId].Save(mStream,System.Drawing.Imaging.ImageFormat.Icon);
            //niTaskIcon.Icon = Icon.FromHandle(new Bitmap(mStream).GetHicon());
            //mStream.Close();//因为image到icon不能强转,所以只能内存转换,此路不通

            tmrTaskIcon.Start();
            

        }

        /// <summary>
        /// 转换Image为Icon
        /// </summary>
        /// <param name="image">要转换为图标的Image对象</param>
        /// <param name="nullTonull">当image为null时是否返回null。false则抛空引用异常</param>
        /// <exception cref="ArgumentNullException" />
        public static Icon ConvertToIcon(Image image, bool nullTonull = false)
        {
            if (image == null)
            {
                if (nullTonull) { return null; }
                throw new ArgumentNullException("image");
            }

            using (MemoryStream msImg = new MemoryStream()
                              , msIco = new MemoryStream())
            {
                image.Save(msImg, ImageFormat.Png);

                using (var bin = new BinaryWriter(msIco))
                {
                    //写图标头部
                    bin.Write((short)0);           //0-1保留
                    bin.Write((short)1);           //2-3文件类型。1=图标, 2=光标
                    bin.Write((short)1);           //4-5图像数量（图标可以包含多个图像）

                    bin.Write((byte)image.Width);  //6图标宽度
                    bin.Write((byte)image.Height); //7图标高度
                    bin.Write((byte)0);            //8颜色数（若像素位深>=8，填0。这是显然的，达到8bpp的颜色数最少是256，byte不够表示）
                    bin.Write((byte)0);            //9保留。必须为0
                    bin.Write((short)0);           //10-11调色板
                    bin.Write((short)32);          //12-13位深
                    bin.Write((int)msImg.Length);  //14-17位图数据大小
                    bin.Write(22);                 //18-21位图数据起始字节

                    //写图像数据
                    bin.Write(msImg.ToArray());

                    bin.Flush();
                    bin.Seek(0, SeekOrigin.Begin);
                    return new Icon(msIco);
                }
            }
        }
        private void sbFriends_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("aa");
        }
        //页面最小化的时候
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); // 或者是 this.Visible = false;
                this.niTaskIcon.Visible = true;
            }
        }
        //任务栏退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出Chatting吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                niTaskIcon.Visible = false;
                this.Close();
                this.Dispose();
                
                Application.Exit();
            }
        }
        //任务栏添加好友
        private void AddFriendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchFriendForm searchFriendForm = new SearchFriendForm();
            searchFriendForm.ShowDialog();
        }
        //任务栏显示个人信息
        private void perosonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfoForm = new PersonalInfoForm();
            personalInfoForm.mainForm = this;  // 将当前窗体本身传给个人信息窗体
            personalInfoForm.ShowDialog();
        }

        private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAddFriend.Stop();  // 消息timer停止运行 
            // 图片恢复正常
            messageImageIndex = 0;
            tsbtnMessageReading.Image = ilMessage.Images[messageImageIndex];

            // 显示系统消息窗体
            RequestForm requestForm = new RequestForm();
            requestForm.ShowDialog();
        }

        private void tmrTaskIcon_Tick(object sender, EventArgs e)
        {
            //niTaskIcon.Icon = ConvertToIcon(ilFaces.Images[friendFaceId]);
            //FlashWindow(this.Handle, true);
          
            int messageTypeId = 1;  // 消息类型
            int messageState = 1;   // 消息状态

            // 找出未读消息对应的好友Id
            string sql = string.Format(
                "SELECT Top 1 FromUserId, MessageTypeId, MessageState FROM Messages WHERE ToUserId={0} AND MessageState=0", UserHelper.loginId);
            SqlCommand command;

            // 消息有两种类型：聊天消息、添加好友消息
            try
            {
                command = new SqlCommand(sql, ML.DBHelper.connection);
                ML.DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                // 循环读出一个未读消息
                if (dataReader.Read())
                {
                    this.fromUserId = (int)dataReader["FromUserId"];
                    messageTypeId = (int)dataReader["MessageTypeId"];
                    messageState = (int)dataReader["MessageState"];
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ML.DBHelper.connection.Close();
            }
            // 如果是聊天消息，就启动聊天timer，让好友头像闪烁
            if (messageTypeId == 1 && messageState == 0 && IconFlag)
            {
                // 获得发消息的人的头像Id
                sql = "SELECT FaceId FROM Users WHERE Id=" + this.fromUserId;
                try
                {
                    command = new SqlCommand(sql, ML.DBHelper.connection);
                    ML.DBHelper.connection.Open();
                    this.friendFaceId = Convert.ToInt32(command.ExecuteScalar()); // 设置发消息的好友的头像索引
                    niTaskIcon.Icon = ConvertToIcon(ilFaces.Images[friendFaceId]); //设定托盘控件taskBarIcon的图标
                    IconFlag = false; //修改该值为假
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
            else //当该值为假时
            {
                niTaskIcon.Icon = Icon; //设定托盘控件taskBarIcon的图标
                IconFlag = true; //修改该值为真
            }

        }

        private void tsmSuggestions_Click(object sender, EventArgs e)
        {
            BrowserHelper.OpenBrowserUrl("http://ip.duwenink.cn:2511/Suggestions/Login.aspx");
        }
    }
      
    }



