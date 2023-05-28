using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiManager
    {
        private static string m_BaseUrl = ConfigManager.Server;
        //登录
        public static string System_Login = $@"{m_BaseUrl}/System/Login";
        //权限
        public static string System_GetRight = $@"{m_BaseUrl}/System/GetRight";
    }
}
