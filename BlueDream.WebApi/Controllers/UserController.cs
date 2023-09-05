using BlueDream.Bll;
using BlueDream.Common; 
using Microsoft.AspNetCore.Mvc;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
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
                m_CommonResult.ResultObj = UserBll.GetTop10(p_SearchKey);
            });

            return m_CommonResult;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PageResult GetListModelByPage(int p_PageSize, int p_PageIndex, string p_SearchKey)
        {
            PageResult m_PageResult = new PageResult();

            SysExTools.TryExec(m_PageResult, () =>
            {
                int p_TotalCount = 0;
                m_PageResult.ResultObj = UserBll.GetListByPage(p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
                m_PageResult.TotalCount = p_TotalCount;
            });

            return m_PageResult;
        }
    }
}
