using BlueDream.Enum;
using BlueDream.Model;
using Org.BouncyCastle.Asn1.X509;
using SqlSugar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class OrderDal
    { 

        public static OrderModel GetOrderByID(DBClient p_DBClient,long p_OrderID)
        {
            SqlTools m_SqlTools = new SqlTools();
            m_SqlTools.Append($@"      SELECT t_order.order_id,");
            m_SqlTools.Append($@"             t_order.order_no,");
            m_SqlTools.Append($@"             t_order.customer_order_no,");
            m_SqlTools.Append($@"             t_order.brand_id,");
            m_SqlTools.Append($@"             t_brand.brand_cn as BrandName,");
            m_SqlTools.Append($@"             t_order.person_in_charge_id,");
            m_SqlTools.Append($@"             t_user.nick_name as PersonInChargeUser,");
            m_SqlTools.Append($@"             t_order.purchase_org_id,");
            m_SqlTools.Append($@"             purchase_org.organization_short_name as PurchaseOrgName,");
            m_SqlTools.Append($@"             t_order.sale_org_id,");
            m_SqlTools.Append($@"             sale_org.organization_short_name as SaleOrgName,");
            m_SqlTools.Append($@"             t_order.order_date,");
            m_SqlTools.Append($@"             t_order.order_currency_code,");
            m_SqlTools.Append($@"             t_order.total_num,");
            m_SqlTools.Append($@"             t_order.total_amount,");
            m_SqlTools.Append($@"             t_order.remarks_info,");
            m_SqlTools.Append($@"             t_order.create_user_id,");
            m_SqlTools.Append($@"             t_order.create_user,");
            m_SqlTools.Append($@"             t_order.create_time,");
            m_SqlTools.Append($@"             t_order.update_user_id,");
            m_SqlTools.Append($@"             t_order.update_user,");
            m_SqlTools.Append($@"             t_order.update_time,");
            m_SqlTools.Append($@"             t_order.data_state");
            m_SqlTools.Append($@"        FROM t_order");
            m_SqlTools.Append($@"   LEFT JOIN t_brand ON t_order.brand_id = t_brand.brand_id");
            m_SqlTools.Append($@"   LEFT JOIN t_user ON t_order.person_in_charge_id = t_user.user_id");
            m_SqlTools.Append($@"   LEFT JOIN t_organization AS purchase_org ON t_order.purchase_org_id = purchase_org.organization_id");
            m_SqlTools.Append($@"   LEFT JOIN t_organization AS sale_org ON t_order.sale_org_id = sale_org.organization_id  ");
            m_SqlTools.Append($@"       WHERE t_order.order_id = {p_OrderID}");
            m_SqlTools.Append($@"         AND t_order.data_state = {Convert.ToInt32(DataStateEnum.Valid)}");

            OrderModel m_OrderModel = p_DBClient.Instance.SqlQueryable<OrderModel>(m_SqlTools.SqlString).First();

            if(m_OrderModel is null)
            {
                return m_OrderModel;
            }

            m_OrderModel.OrderItemList = p_DBClient.Instance.Queryable<OrderItemEntity>()
                .Where(t => t.DataState == DataStateEnum.Valid)
                .Where(t => t.OrderID == p_OrderID)
                .ToList();

            return m_OrderModel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_PageSize">页面大小</param>
        /// <param name="p_PageIndex">页面索引</param>
        /// <param name="p_SearchKey">搜索词</param>
        /// <param name="p_TotalCount">ref 总数量</param>
        /// <returns></returns>
        public static List<OrderModel> GetOrderListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            SqlTools m_SqlTools = new SqlTools();
            m_SqlTools.Append($@"      SELECT t_order.order_id,");
            m_SqlTools.Append($@"             t_order.order_no,");
            m_SqlTools.Append($@"             t_order.customer_order_no,");
            m_SqlTools.Append($@"             t_order.brand_id,");
            m_SqlTools.Append($@"             t_brand.brand_cn as BrandName,");
            m_SqlTools.Append($@"             t_order.person_in_charge_id,");
            m_SqlTools.Append($@"             t_user.nick_name as PersonInChargeUser,");
            m_SqlTools.Append($@"             t_order.purchase_org_id,");
            m_SqlTools.Append($@"             purchase_org.organization_short_name as PurchaseOrgName,");
            m_SqlTools.Append($@"             t_order.sale_org_id,");
            m_SqlTools.Append($@"             sale_org.organization_short_name as SaleOrgName,");
            m_SqlTools.Append($@"             t_order.order_date,");
            m_SqlTools.Append($@"             t_order.order_currency_code,");
            m_SqlTools.Append($@"             t_order.total_num,");
            m_SqlTools.Append($@"             t_order.total_amount,");
            m_SqlTools.Append($@"             t_order.remarks_info,");
            m_SqlTools.Append($@"             t_order.create_user_id,");
            m_SqlTools.Append($@"             t_order.create_user,");
            m_SqlTools.Append($@"             t_order.create_time,");
            m_SqlTools.Append($@"             t_order.update_user_id,");
            m_SqlTools.Append($@"             t_order.update_user,");
            m_SqlTools.Append($@"             t_order.update_time,");
            m_SqlTools.Append($@"             t_order.data_state");
            m_SqlTools.Append($@"        FROM t_order");
            m_SqlTools.Append($@"   LEFT JOIN t_brand ON t_order.brand_id = t_brand.brand_id");
            m_SqlTools.Append($@"   LEFT JOIN t_user ON t_order.person_in_charge_id = t_user.user_id");
            m_SqlTools.Append($@"   LEFT JOIN t_organization AS purchase_org ON t_order.purchase_org_id = purchase_org.organization_id");
            m_SqlTools.Append($@"   LEFT JOIN t_organization AS sale_org ON t_order.sale_org_id = sale_org.organization_id  ");
            m_SqlTools.Append($@"       WHERE t_order.customer_order_no LIKE '%{p_SearchKey}%'", p_SearchKey != "*");
            m_SqlTools.Append($@"         AND t_order.data_state = {Convert.ToInt32(DataStateEnum.Valid)}");
            m_SqlTools.Append($@"    ORDER BY t_order.create_time desc ");

            return p_DBClient.Instance.SqlQueryable<OrderModel>(m_SqlTools.SqlString)
                .ToPageList(p_PageIndex, p_PageSize, ref p_TotalCount);

             
        }
    }
}
