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
            //查询原有订单项
            List<OrderItemEntity> m_OldList = p_DBClient.Instance.Queryable<OrderItemEntity>()
                .Where(t => t.OrderID == p_OrderItemList[0].OrderID)
                .ToList();

            //原有订单项字典
            Dictionary<long, OrderItemEntity> m_OldListDic = new Dictionary<long, OrderItemEntity>();

            foreach (OrderItemEntity t_OrderItemEntity in m_OldList)
            {
                m_OldListDic.Add(t_OrderItemEntity.OrderItemID, t_OrderItemEntity);
            }


            //循环新的订单项
            foreach (OrderItemEntity t_OrderItemEntity in p_OrderItemList)
            {
                //如果发现订单项在旧的订单项清单中存在，则从原有订单项清单中删除，并更新此项
                if(m_OldListDic.ContainsKey(t_OrderItemEntity.OrderItemID))
                {
                    m_OldListDic.Remove(t_OrderItemEntity.OrderItemID);
                    p_DBClient.Instance.Updateable(t_OrderItemEntity)
                      .IgnoreColumns(t => new { t.CreateUserID, t.CreateUser, t.CreateTime })
                      .Where(t => t.OrderItemID == t_OrderItemEntity.OrderItemID)
                      .Where(t => t.DataState == DataStateEnum.Valid)
                      .ExecuteCommand();
                }
                else
                {
                    //如果没有则添加
                    p_DBClient.Instance.Insertable(t_OrderItemEntity).ExecuteCommand();
                }

               
            }

            //老订单项中有，新订单项中没有的，则认定为被用户删除，则执行逻辑删除
            foreach (var t_DicItem in m_OldListDic)
            {
                t_DicItem.Value.DataState = DataStateEnum.Delete;
                t_DicItem.Value.UpdateTime = DateTime.Now;
                t_DicItem.Value.UpdateUser = "";
                t_DicItem.Value.UpdateUserID = 0;

                p_DBClient.Instance.Updateable(t_DicItem.Value)
                    .UpdateColumns(t=>new { t.DataState,t.UpdateTime,t.UpdateUser,t.UpdateUserID})
                    .Where(t => t.DataState == DataStateEnum.Valid)
                    .Where(t => t.OrderItemID == t_DicItem.Key)
                    .ExecuteCommand();

                OrderDetailDal.Delete(p_DBClient,(OrderItemEntity)t_DicItem.Value);
            }



        }
    }
}
