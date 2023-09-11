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
        public CommonResult GetOrganizationByID(long p_OrganizationID)
        {
            CommonResult m_CommonResult = new PageResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = OrganizationBll.GetOrganizationByID(p_OrganizationID);
            });

            return m_CommonResult;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_PageSize"></param>
        /// <param name="p_PageIndex"></param>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        [HttpGet]
        public PageResult GetOrganizationListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey)
        {
            PageResult m_PageResult = new PageResult();

            SysExTools.TryExec(m_PageResult, () =>
            {
                int p_TotalCount = 0;
                m_PageResult.ResultObj = OrganizationBll.GetOrganizationListByPage(p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
                m_PageResult.TotalCount = p_TotalCount;
            });

            return m_PageResult;
        }

    }
}


