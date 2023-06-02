using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 采购明细
    /// </summary>
    [SugarTable("t_clothing_order_dtl")]
    public class ClothingOrderDtlEntity : BaseEntity
    {
        /// <summary>
        /// 采购明细ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_dtl_id",IsPrimaryKey = true)]
        public Int64 ClothingOrderDtlID { get; set; }
        /// <summary>
        /// 合同采购项ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_item_id")]
        public Int64 ClothingOrderItemID { get; set; }
        /// <summary>
        /// 采购单ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_id")]
        public Int64 ClothingOrderID { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [SugarColumn(ColumnName = "color")]
        public String Color { get; set; }
        /// <summary>
        /// 尺码
        /// </summary>
        [SugarColumn(ColumnName = "size")]
        public String Size { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [SugarColumn(ColumnName = "qty")]
        public int Qty { get; set; }
        /// <summary>
        /// 实际交货数量
        /// </summary>
        [SugarColumn(ColumnName = "delivery_qty")]
        public int DeliveryQty { get; set; }
 
    }
}
