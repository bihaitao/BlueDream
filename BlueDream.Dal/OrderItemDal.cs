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
    public class OrderItemDal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_OrderID"></param>
        /// <returns></returns>
        public static List<OrderItemEntity> GetOrderItemList(DBClient p_DBClient, long p_OrderID)
        { 
            return p_DBClient.Instance.Queryable<OrderItemEntity>()
             .Where(t => t.DataState == DataStateEnum.Valid)
             .Where(t => t.OrderID == p_OrderID)
             .ToList(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_OrderItemList"></param>
        public static void Save(DBClient p_DBClient, List<OrderItemModel> p_OrderItemList)
        {
            //查询原有订单项，并删除
            List<OrderItemEntity> m_OldList = GetOrderItemList(p_DBClient, p_OrderItemList[0].OrderID);
            p_DBClient.Instance.Deleteable(m_OldList).ExecuteCommand();


            //将新数据插入表 
            List<OrderItemEntity> m_NewList = new List<OrderItemEntity>();

            foreach (OrderItemModel t_OrderItemModel in p_OrderItemList)
            {
                OrderItemEntity m_OrderItemEntity = JsonTools.ToObject<OrderItemEntity>(t_OrderItemModel);
                m_NewList.Add(m_OrderItemEntity);
            }

            p_DBClient.Instance.Insertable(m_NewList).ExecuteCommand();

             

            //将删除的订单项转移到删除表
            List<OrderItemDelEntity> m_DelList = new List<OrderItemDelEntity>();
             
            foreach (OrderItemModel t_OrderItemModel in m_OldList)
            { 
                OrderItemDelEntity m_OrderItemDelEntity = JsonTools.ToObject<OrderItemDelEntity>(t_OrderItemModel);

                m_OrderItemDelEntity.DataState = DataStateEnum.Delete;
                m_OrderItemDelEntity.UpdateTime = DateTime.Now;
                m_OrderItemDelEntity.UpdateUser = "";
                m_OrderItemDelEntity.UpdateUserID = 0; 
                m_DelList.Add(m_OrderItemDelEntity);
            }
             
            p_DBClient.Instance.Insertable(m_DelList).ExecuteCommand();  
        }
    }
}
