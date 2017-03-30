using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Chatting.ML
{
    // 数据库帮助类，维护数据库连接字符串和数据库连接对象
   public class DBHelper
    {
        //private static string connString = "Data Source=DUWENINK\\DUWENINK;Initial Catalog=Chat;User ID=sa;Pwd=123456";
        private static string connString = "Data Source=115.159.107.202;Initial Catalog=Chat;User ID=sa;Pwd=sa123456123.0";
        public static SqlConnection connection = new SqlConnection(connString);
    }
}