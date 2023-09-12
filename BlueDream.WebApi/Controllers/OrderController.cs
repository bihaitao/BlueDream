using BlueDream.Bll;
using BlueDream.Common;
using BlueDream.Model;
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
        public CommonResult GetOrderByID(long p_OrderID)
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                m_CommonResult.ResultObj = OrderBll.GetOrderByID(p_OrderID);
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
        public PageResult GetOrderListByPage(int p_PageSize,int p_PageIndex,string p_SearchKey)
        { 
            PageResult m_PageResult = new PageResult();
            
            SysExTools.TryExec(m_PageResult, () =>
            {
                int p_TotalCount = 0;
                m_PageResult.ResultObj = OrderBll.GetOrderListByPage(p_PageSize, p_PageIndex, p_SearchKey,ref p_TotalCount);
                m_PageResult.TotalCount = p_TotalCount;
            });

            return m_PageResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_PageSize"></param>
        /// <param name="p_PageIndex"></param>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        [HttpPost]
        public CommonResult Save(OrderModel p_OrderModel)
        {
            CommonResult m_CommonResult = new CommonResult();

            SysExTools.TryExec(m_CommonResult, () =>
            {
                OrderBll.Save(p_OrderModel);
            });

            return m_CommonResult;
        }

    }
}


