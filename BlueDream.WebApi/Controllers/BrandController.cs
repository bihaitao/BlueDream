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
    public class BrandController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]       
        public CommonResult GetTop10(string p_SearchKey)
        { 
            CommonResult m_CommonResult = new PageResult();
            
            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = BrandBll.GetTop10(p_SearchKey); 
            });

            return m_CommonResult;
        }


    }
}


