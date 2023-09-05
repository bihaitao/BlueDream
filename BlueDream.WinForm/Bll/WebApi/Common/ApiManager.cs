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
         
        /// <summary>
        /// 获取订单列表(分页)
        /// </summary>
        public static string Order_GetListModelByPage = $@"{m_BaseUrl}/Order/GetListModelByPage";

        /// <summary>
        /// 获取品牌
        /// </summary>
        public static string Brand_GetTop10 = $@"{m_BaseUrl}/Brand/GetTop10";
        /// <summary>
        /// 获取品牌
        /// </summary>
        public static string Brand_GetListModelByPage = $@"{m_BaseUrl}/Brand/GetListModelByPage";

        /// <summary>
        /// 获取用户
        /// </summary>
        public static string User_GetTop10 = $@"{m_BaseUrl}/User/GetTop10";

        /// <summary>
        /// 获取组织
        /// </summary>
        public static string Organization_GetTop10 = $@"{m_BaseUrl}/Organization/GetTop10";
    }
}
