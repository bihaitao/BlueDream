using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_order_item_del")]
    public class OrderItemDelEntity : BaseEntity
    {
        /// <summary>
        /// 订单项ID
        /// </summary>
        [SugarColumn(ColumnName = "order_item_id",IsPrimaryKey = true)]
        public long OrderItemID { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(ColumnName = "order_id")]
        public long OrderID { get; set; }
        /// <summary>
        /// 项索引
        /// </summary>
        [SugarColumn(ColumnName = "item_index")]
        public int ItemIndex { get; set; }
        /// <summary>
        /// 样式编码(SPU)
        /// </summary>
        [SugarColumn(ColumnName = "style_no")]
        public string StyleNo { get; set; }
        /// <summary>
        /// 交期
        /// </summary>
        [SugarColumn(ColumnName = "delivery_date")]
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [SugarColumn(ColumnName = "unit_price")]
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 面料
        /// </summary>
        [SugarColumn(ColumnName = "composition")]
        public string Composition { get; set; }
    }
}
