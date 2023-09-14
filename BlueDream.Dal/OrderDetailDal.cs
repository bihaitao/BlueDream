using BlueDream.Enum;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class OrderDetailDal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_OrderItemID"></param>
        /// <returns></returns>
        public static List<OrderDetailEntity> GetOrderDetailList(DBClient p_DBClient, long p_OrderItemID)
        {
            return p_DBClient.Instance.Queryable<OrderDetailEntity>()
             .Where(t => t.DataState == DataStateEnum.Valid)
             .Where(t => t.OrderItemID == p_OrderItemID)
             .ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_OrderItemList"></param>
        public static void Save(DBClient p_DBClient, List<OrderItemModel> p_OrderItemList)
        { 
            foreach (OrderItemModel t_OrderItemModel in p_OrderItemList)
            {
                Delete(p_DBClient, t_OrderItemModel);
                p_DBClient.Instance.Insertable<OrderDetailEntity>(t_OrderItemModel.OrderDetailList).ExecuteCommand();
            }
        }

        public static void Delete(DBClient p_DBClient, OrderItemEntity p_OrderItemEntity)
        {
            p_DBClient.Instance.Updateable<OrderDetailEntity>()
                   .SetColumns(t => new OrderDetailEntity()
                   {
                       UpdateTime = DateTime.Now,
                       UpdateUser = "",
                       UpdateUserID = 0,
                       DataState = DataStateEnum.Delete
                   })
                   .Where(t => t.OrderItemID == p_OrderItemEntity.OrderItemID)
                   .Where(t => t.DataState == DataStateEnum.Valid)
                   .ExecuteCommand();

        }
    }
}
