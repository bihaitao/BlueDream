using BlueDream.Common;
using BlueDream.Model;
using BuleDream.Bll;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace BlueDream.WebApi
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SystemController : Controller
    {
        [HttpGet]
        public CommonResult GetMenu()
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = "mmss";
            });

            return m_CommonResult;
        }


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
        [HttpGet]
        public CommonResult Login(string p_UserName,string p_Password)
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = RsaKeyBll.GetByID(12);
            });

            return m_CommonResult;
        }
    }
}
