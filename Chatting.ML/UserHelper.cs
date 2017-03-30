using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatting.ML
{
    //记录登录的用户Id
   public class UserHelper
    {
        public static int loginId;  //登录的用户Id
    }

    //记录用户的个性签名
    public class classTodayFeel
    {
        public string TodayFeel { get; set; }
    }
    //记录用户上次登陆IP
    public class classLastloginIP
    {
        public string LastloginIP { get; set; }
    }

}
