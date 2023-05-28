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

        public static string System_Login = $@"{m_BaseUrl}/System/Login";
    }
}
