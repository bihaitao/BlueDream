using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_fabric_plan")]
    public class FabricPlanEntity : BaseEntity
    {
        /// <summary>
        /// 面料计划单ID
        /// </summary>
        [SugarColumn(ColumnName = "fabric_plan_id", IsPrimaryKey = true)]
        public Int64 FabricPlanID { get; set; }
        /// <summary>
        /// 合同采购项ID
        /// </summary>
        [SugarColumn(ColumnName = "purchase_item_id")]
        public Int64 PurchaseItemID { get; set; }
        /// <summary>
        /// 交货日期
        /// </summary>
        [SugarColumn(ColumnName = "delivery_date")]
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// 责任人
        /// </summary>
        [SugarColumn(ColumnName = "responsible_user_id")]
        public Int64 ResponsibleUserID { get; set; }

    }
}
