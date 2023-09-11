using BlueDream.Dal;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class OrderBll
    {
        /// <summary>
        /// 获取订单
        /// </summary>
        /// <param name="p_OrderID"></param>
        /// <returns></returns>
        public static OrderModel GetOrderByID(long p_OrderID)
        {
            return OrderDal.GetOrderByID(DBHelper.CreateReadOnlyClient(), p_OrderID);
        }

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="p_PageSize"></param>
        /// <param name="p_PageIndex"></param>
        /// <param name="p_SearchKey"></param>
        /// <param name="p_TotalCount"></param>
        /// <returns></returns>
        public static List<OrderModel> GetOrderListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return OrderDal.GetOrderListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey,ref p_TotalCount);
        }

      
    }
}
