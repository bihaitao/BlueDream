using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_order")]
    public class OrderEntity : BaseEntity
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(ColumnName = "order_id",IsPrimaryKey = true)]
        public long OrderID { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [SugarColumn(ColumnName = "order_no")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 客户订单号
        /// </summary>
        [SugarColumn(ColumnName = "customer_order_no")]
        public string CustomerOrderNo { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
        [SugarColumn(ColumnName = "brand_id")]
        public long BrandID { get; set; }

        /// <summary>
        /// 担当人ID User_ID 
        /// </summary>
        [SugarColumn(ColumnName = "person_in_charge_id")]
        public long Person_IN_Charge_ID { get; set; }
        
        /// <summary>
        /// 采购方组织ID
        /// </summary>
        [SugarColumn(ColumnName = "purchase_org_id")]
        public long PurchaseOrgID { get; set; }
        /// <summary>
        /// 销售方组织ID
        /// </summary>
        [SugarColumn(ColumnName = "sale_org_id")]
        public long SaleOrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "order_date")]
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// 货币编码
        /// </summary>
        [SugarColumn(ColumnName = "order_currency_code")]
        public string OrderCurrencyCode { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        [SugarColumn(ColumnName = "total_num")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "total_amount")]
        public decimal TotalAmount { get; set; }
    }
}
