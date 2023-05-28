using BlueDream.Bll;
using BlueDream.Common;
using BlueDream.Model; 
using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace BlueDream.WebApi
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SystemController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public CommonResult GetRight()
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = "mmss";
            });

            return m_CommonResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_RsaID"></param>
        /// <returns></returns>
        [HttpPost]
        public CommonResult Get(Int64 p_RsaID)
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj =  RsaKeyBll.GetByID(p_RsaID); 
            });

            return m_CommonResult;
        }

        /// <summary>
        ///  登录
        /// </summary>
        /// <param name="p_UserName">用户名</param>
        /// <param name="p_Password">密码</param>
        /// <param name="p_VerifyCode">验证码</param>
        /// <returns></returns>
        [HttpPost]
        public CommonResult Login(Param_Login_VM p_Param_Login_VM)
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                //string m_VerifCode = HttpContext.Session.GetString("VerifyCode");

                //if(string.IsNullOrWhiteSpace(m_VerifCode))
                //{
                //    SysExTools.Throw_LoginEx("验证码不正确", "验证码不正确");
                //}
                 
                //if (m_VerifCode.ToUpper() != p_Param_Login_VM.VerifyCode.ToUpper())
                //{
                //    SysExTools.Throw_LoginEx("验证码不正确", "验证码不正确");
                //}

                m_CommonResult.ResultObj = UserBll.LoginReturnRsaKey(p_Param_Login_VM.UserName, p_Param_Login_VM.Password);
            });

            return m_CommonResult;
        }


        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<FileResult> GetVerifyCode()
        {
        
            string m_OldVerifyCode = HttpContext.Session.GetString("VerifyCode");
            if (!string.IsNullOrWhiteSpace(m_OldVerifyCode))
            {
                HttpContext.Session.SetString("VerifyCode", "");
            }

            VerifyCode m_VerifyCode = VerifyCodeHelper.CreateVerifyCode(4, VerifyCodeType.CHAR);
            HttpContext.Session.SetString("VerifyCode", m_VerifyCode.Code.ToUpper());

            return await Task.Factory.StartNew(() =>
            { 
                return File(m_VerifyCode.Image, @"image/jpeg"); ;
            });
             
        }

        public class Param_Login_VM
        {
            public string UserName { set; get; } = "";
            public string Password { set; get; } = "";
            public string VerifyCode { set; get; } = "";
        }
 
    }

   
}
