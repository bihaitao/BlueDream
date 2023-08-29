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
    public class OrderController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]       
        public CommonResult GetListByPage(int p_PageSize,int p_PageIndex,string p_SearchKey)
        { 
            CommonResult m_CommonResult = new CommonResult();
            
            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = OrderBll.GetListByPage(p_PageSize, p_PageIndex, p_SearchKey);
            });

            return m_CommonResult;
        }


    }
}


