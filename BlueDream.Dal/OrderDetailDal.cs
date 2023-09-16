using BlueDream.Common;
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
        public static void Save(DBClient p_DBClient, List<OrderDetailEntity> p_OrderDetailList)
        {
            //查询原有订单项，并删除
            List<OrderDetailEntity> m_OldList = GetOrderDetailList(p_DBClient, p_OrderDetailList[0].OrderItemID);
            p_DBClient.Instance.Deleteable(m_OldList).ExecuteCommand();

            //将新数据插入表 
            p_DBClient.Instance.Insertable(p_OrderDetailList).ExecuteCommand();

            //将删除的订单项转移到删除表
            List<OrderDetailDelEntity> m_DelList = new List<OrderDetailDelEntity>();

            foreach (OrderDetailEntity t_OrderDetailEntity in m_OldList)
            {
                OrderDetailDelEntity m_OrderDetailDelEntity = JsonTools.ToObject<OrderDetailDelEntity>(t_OrderDetailEntity); 
                m_OrderDetailDelEntity.DataState = DataStateEnum.Delete;
                m_OrderDetailDelEntity.UpdateTime = DateTime.Now;
                m_OrderDetailDelEntity.UpdateUser = "";
                m_OrderDetailDelEntity.UpdateUserID = 0;
                m_DelList.Add(m_OrderDetailDelEntity);
            }

            p_DBClient.Instance.Insertable(m_DelList).ExecuteCommand();
        }

         
    }
}
