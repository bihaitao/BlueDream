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
    public class OrganizationController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]       
        public CommonResult GetOrganization(string p_SearchKey)
        { 
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = CompanyBll.GetOrganization(p_SearchKey);
            });

            return m_CommonResult;
        }


    }
}


