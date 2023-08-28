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

        /// <summary>
        /// 登录
        /// </summary>
        public static string System_Login = $@"{m_BaseUrl}/System/Login";

        /// <summary>
        /// 权限
        /// </summary>
        public static string System_GetRight = $@"{m_BaseUrl}/System/GetRight";

        /// <summary>
        /// 获取公司列表
        /// </summary>
        public static string Organization_GetOrganization = $@"{m_BaseUrl}/Organization/GetOrganization";
    }
}
