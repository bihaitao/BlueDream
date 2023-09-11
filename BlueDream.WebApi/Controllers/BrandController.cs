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
        public CommonResult GetBrandByID(long p_BrandID)
        {
            CommonResult m_CommonResult = new PageResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = BrandBll.GetBrandByID(p_BrandID);
            });

            return m_CommonResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PageResult GetBrandListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey)
        {
            PageResult m_PageResult = new PageResult();

            SysExTools.TryExec(m_PageResult, () =>
            {
                int p_TotalCount = 0;
                m_PageResult.ResultObj = BrandBll.GetBrandListByPage(p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
                m_PageResult.TotalCount = p_TotalCount;
            });

            return m_PageResult;
        }


       
    }
}


