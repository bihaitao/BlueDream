using BlueDream.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 中间件类
    /// </summary>
    public class AuthorizationMW
    { 
        private readonly RequestDelegate m_RequestDelegate;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_RequestDelegate"></param>
        public AuthorizationMW(RequestDelegate p_RequestDelegate)
        {
            m_RequestDelegate = p_RequestDelegate;
        }

        /// <summary>
        /// 接口请求校验
        /// </summary>
        /// <param name="p_HttpContext"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext p_HttpContext)
        {
            string p_Url = StringTools.GetNotNullString(p_HttpContext.Request.Path.Value).ToLower();

            if (IsWhiteListUrl(p_Url))
            {
                await m_RequestDelegate(p_HttpContext);
                return;
            }
             
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                //校验登录权限
                LoginHelper.IsLogin(p_HttpContext);
            });

            if (m_CommonResult.Success)
            {
                await m_RequestDelegate(p_HttpContext);
                return;
            }
            else
            {
                ResponseWrite(p_HttpContext, JsonTools.GetJson(m_CommonResult));
                return;
            }



        }

        /// <summary>
        /// 判断是否在白名单之内
        /// </summary>
        /// <param name="p_Path"></param>
        /// <returns></returns>
        private bool IsWhiteListUrl(string p_Path)
        {
            p_Path = p_Path.ToLower();
            return m_WhiteListUrl.Where(t => p_Path.IndexOf(t) == 0).Count() > 0;
        }

        /// <summary>
        /// 可以忽略的白名单Api
        /// </summary>
        private readonly string[] m_WhiteListUrl = {
             
            "/swagger/index.html".ToLower(),//swagger,
            "/System/Login".ToLower(),//登录
            "/System/GetVerifyCode".ToLower(),//登录验证码
            "/System/EnumJsFile".ToLower()//枚举
            
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_HttpContext"></param>
        /// <param name="p_ContextTxt"></param>
        private void ResponseWrite(HttpContext p_HttpContext, string p_ContextTxt)
        {
            p_HttpContext.Response.ContentType = "text/plain; charset=utf-8";
            p_HttpContext.Response.WriteAsync(p_ContextTxt, Encoding.UTF8).Wait();
        }
        
    }
}
