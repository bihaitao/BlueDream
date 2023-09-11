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
        public static string Organization_GetOrganizationByID = $@"{m_BaseUrl}/Organization/GetOrganizationByID";

        /// <summary>
        /// 获取组织
        /// </summary>
        public static string Organization_GetOrganizationListByPage = $@"{m_BaseUrl}/Organization/GetOrganizationListByPage";

        /// <summary>
        /// 获取订单 
        /// </summary>
        public static string Order_GetOrderByID = $@"{m_BaseUrl}/Order/GetOrderByID";

        /// <summary>
        /// 获取订单列表(分页)
        /// </summary>
        public static string Order_GetOrderListByPage = $@"{m_BaseUrl}/Order/GetOrderListByPage";
     

        /// <summary>
        /// 获取品牌
        /// </summary>
        public static string Brand_GetBrandByID = $@"{m_BaseUrl}/Brand/GetBrandByID";

        /// <summary>
        /// 获取品牌
        /// </summary>
        public static string Brand_GetBrandListByPage = $@"{m_BaseUrl}/Brand/GetBrandListByPage";

        /// <summary>
        /// 获取用户
        /// </summary>
        public static string User_GetUserByID = $@"{m_BaseUrl}/User/GetUserByID";

        /// <summary>
        /// 获取用户
        /// </summary>
        public static string User_GetUserListByPage = $@"{m_BaseUrl}/User/GetUserListByPage";
 
        /// <summary>
        /// 获取货币
        /// </summary>
        public static string Dic_GetCurrencyList = $@"{m_BaseUrl}/Dic/GetCurrencyList";
    }
}
