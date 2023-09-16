using BlueDream.Common;
using BlueDream.Dal;
using BlueDream.Enum;
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
            OrderModel m_OrderModel = OrderDal.GetOrderByID(DBHelper.CreateReadOnlyClient(), p_OrderID);

            if(m_OrderModel is null)
            {
                return m_OrderModel;
            }

            List<OrderItemEntity> m_OrderItemList = OrderItemDal.GetOrderItemList(DBHelper.CreateReadOnlyClient(), m_OrderModel.OrderID);
            
            foreach(OrderItemEntity t_OrderItemEntity in m_OrderItemList)
            {
                OrderItemModel m_OrderItemModel = JsonTools.ToObject<OrderItemModel>(t_OrderItemEntity);

                m_OrderItemModel.OrderDetailList = OrderDetailDal.GetOrderDetailList(DBHelper.CreateReadOnlyClient(),m_OrderItemModel.OrderItemID);
                m_OrderModel.OrderItemList.Add(m_OrderItemModel);
            }
             
            return m_OrderModel; 
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
            return OrderDal.GetOrderListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
        }


        public static void Save(OrderModel p_OrderModel)
        {
            DBHelper.Transaction((t_DBClient) =>
            {
                //重新生成Item和DetailID

                for(int t_Index_Item=0; t_Index_Item< p_OrderModel.OrderItemList.Count; t_Index_Item++)
                {
                    p_OrderModel.OrderItemList[t_Index_Item].OrderItemID =  StringTools.GetNewGuidLong();

                    for(int t_Index_Detail=0; t_Index_Detail<p_OrderModel.OrderItemList[t_Index_Item].OrderDetailList.Count; t_Index_Detail ++)
                    {
                        p_OrderModel.OrderItemList[t_Index_Item].OrderDetailList[t_Index_Detail].OrderItemID = p_OrderModel.OrderItemList[t_Index_Item].OrderItemID;
                        p_OrderModel.OrderItemList[t_Index_Item].OrderDetailList[t_Index_Detail].OrderDetailID = StringTools.GetNewGuidLong();
                    }
                }


                OrderDal.Save(t_DBClient, p_OrderModel);

                OrderItemDal.Save(t_DBClient, p_OrderModel.OrderItemList);

                foreach(OrderItemModel t_OrderItemModel in p_OrderModel.OrderItemList)
                {
                    OrderDetailDal.Save(t_DBClient, t_OrderItemModel.OrderDetailList);
                } 
            }); 
        }


    }
}
