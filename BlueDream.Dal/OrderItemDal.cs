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
        public static void Save(DBClient p_DBClient, List<OrderItemEntity> p_OrderItemList)
        {
            List<OrderItemEntity> m_OldList = p_DBClient.Instance.Queryable<OrderItemEntity>()
                .Where(t => t.OrderID == p_OrderItemList[0].OrderID)
                .ToList();

            Dictionary<long, OrderItemEntity> m_OldListDic = new Dictionary<long, OrderItemEntity>();

            foreach (OrderItemEntity t_OrderItemEntity in m_OldList)
            {
                m_OldListDic.Add(t_OrderItemEntity.OrderItemID, t_OrderItemEntity);
            }


            foreach (OrderItemEntity t_OrderItemEntity in p_OrderItemList)
            {
                if(m_OldListDic.ContainsKey(t_OrderItemEntity.OrderItemID))
                {
                    m_OldListDic.Remove(t_OrderItemEntity.OrderItemID);
                }

                OrderItemEntity m_OrderItemEntity = p_DBClient.Instance.Queryable<OrderItemEntity>()
                    .Where(t => t.OrderItemID == t_OrderItemEntity.OrderItemID)
                    .Where(t => t.DataState == DataStateEnum.Valid)
                    .First();

                if (m_OrderItemEntity is null)
                {
                    p_DBClient.Instance.Insertable(t_OrderItemEntity).ExecuteCommand() ;
                }
                else
                { 
                    p_DBClient.Instance.Updateable(t_OrderItemEntity)
                        .IgnoreColumns(t => new { t.CreateUserID, t.CreateUser, t.CreateTime })
                        .Where(t => t.OrderItemID == t_OrderItemEntity.OrderItemID)
                        .Where(t => t.DataState == DataStateEnum.Valid)
                        .ExecuteCommand();
                }
            }

            foreach (var t_DicItem in m_OldListDic)
            {
                t_DicItem.Value.DataState = DataStateEnum.Delete;
                t_DicItem.Value.UpdateTime = DateTime.Now;
                t_DicItem.Value.UpdateUser = "";
                t_DicItem.Value.UpdateUserID = 0;

                p_DBClient.Instance.Updateable(t_DicItem.Value)
                          .UpdateColumns(t=>new { t.DataState ,t.UpdateTime,t.UpdateUser,t.UpdateUserID})
                          .Where(t => t.DataState == DataStateEnum.Valid)
                          .Where(t => t.OrderItemID == t_DicItem.Key)
                          .ExecuteCommand();
            }



        }
    }
}
