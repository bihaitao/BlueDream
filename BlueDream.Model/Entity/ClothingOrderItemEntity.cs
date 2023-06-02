using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 采购项目
    /// </summary>
    [SugarTable("t_clothing_order_item")]
    public class ClothingOrderItemEntity : BaseEntity
    {
        /// <summary>
        /// 合同采购项ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_item_id",IsPrimaryKey = true)]
        public Int64 ClothingOrderItemID { get; set; }
        /// <summary>
        /// 合同ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_id")]
        public Int64 ClothingOrderID { get; set; }
        /// <summary>
        /// 采购项名称
        /// </summary>
        [SugarColumn(ColumnName = "item_name")]
        public String ItemName { get; set; }
        /// <summary>
        /// 采购项编码
        /// </summary>
        [SugarColumn(ColumnName = "item_code")]
        public String ItemCode { get; set; }
        /// <summary>
        /// 采购数量
        /// </summary>
        [SugarColumn(ColumnName = "qty")]
        public int Qty { get; set; }
        /// <summary>
        /// 采购单价
        /// </summary>
        [SugarColumn(ColumnName = "unit_price")]
        public Decimal UnitPrice { get; set; }
        /// <summary>
        /// 交货日期
        /// </summary>
        [SugarColumn(ColumnName = "delivery_date")]
        public DateTime DeliveryDate { get; set; }
 
    }
}
