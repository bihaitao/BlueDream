
using BlueDream.Bll;
using BlueDream.Common;
using BlueDream.Model; 
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 授权帮助类
    /// </summary>
    public class LoginHelper
    {
        /// <summary>
        /// 常量HttpHeaders请求头
        /// </summary>
        public const string LoginKey = "LoginKey";

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginHelper() { }

        /// <summary>
        /// 校验用户权限
        /// </summary>
        /// <param name="p_HttpContext">请求信息</param>
        public static void IsLogin(HttpContext p_HttpContext)
        {
            //获取请求的认证信息
            string p_EnCodeString = p_HttpContext.Request.Headers[LoginKey];

            if (string.IsNullOrWhiteSpace(p_EnCodeString))
            {
                SysExTools.Throw_LoginEx("请求认证Key不存在!", "HttpContext.Request.Headers[LoginKey] 为空!");
            }

            //校验权限
            LoginUserModel m_LoginUserModel = UserBll.GetLoginUserByEnCodeString(p_EnCodeString);

            //判断是否超过授权时间
            if (m_LoginUserModel.LoginOutTime < DateTime.Now)
            {
                if (string.IsNullOrWhiteSpace(p_EnCodeString))
                {
                    SysExTools.Throw_LoginEx("请求已过期!", $"{m_LoginUserModel.ToString()}", $"{m_LoginUserModel.UserID}");
                }
            }
        }


     

       
    }
}
