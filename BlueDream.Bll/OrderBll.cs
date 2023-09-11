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
        public static List<OrderEntity> GetListByPage(int p_PageSize,int p_PageIndex,string p_SearchKey)
        {
            int p_TotalCount = 0;
            return OrderDal.GetListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey,ref p_TotalCount);
        }


        public static List<OrderModel> GetListModelByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return OrderDal.GetListModelByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey,ref p_TotalCount);
        }

        public static OrderModel GetModel(int p_OrderID)
        {
            return OrderDal.GetModel(DBHelper.CreateReadOnlyClient(), p_OrderID);
        }
    }
}
