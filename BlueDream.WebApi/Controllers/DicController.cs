using BlueDream.Bll;
using BlueDream.Common; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BlueDream.WebApi
{

    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class DicController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public CommonResult GetCurrencyList()
        {
            CommonResult m_CommonResult = new PageResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = DicBll.GetCurrencyModels();
            });

            return m_CommonResult;
        }
    }
}