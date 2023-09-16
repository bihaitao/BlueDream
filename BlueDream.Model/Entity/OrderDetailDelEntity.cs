using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 订单明细
    /// </summary>
    [SugarTable("t_order_detail_del")]
    public class OrderDetailDelEntity : BaseEntity
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [SugarColumn(ColumnName = "order_detail_id",IsPrimaryKey = true)]
        public long OrderDetailID { get; set; }
        /// <summary>
        /// 订单项ID
        /// </summary>
        [SugarColumn(ColumnName = "order_item_id")]
        public long OrderItemID { get; set; }

        [SugarColumn(ColumnName = "order_index")]
        public int OrderIndex { set; get; }
        /// <summary>
        /// 订单明细编码（sku）
        /// </summary>
        [SugarColumn(ColumnName = "order_detail_no")]
        public string OrderDetailNo { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [SugarColumn(ColumnName = "color")]
        public string Color { get; set; }
        /// <summary>
        /// 尺码
        /// </summary>
        [SugarColumn(ColumnName = "size")]
        public string Size { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [SugarColumn(ColumnName = "quantity")]
        public int Quantity { get; set; }
        /// <summary>
        /// 交货数量
        /// </summary>
        [SugarColumn(ColumnName = "delivery_quantity")]
        public int DeliveryQuantity { get; set; }
    }
}
