using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_fabric_plan_item")]
    public class FabricPlanItemEntity:BaseEntity
    {
        /// <summary>
        /// 面料计划单明细
        /// </summary>
        [SugarColumn(ColumnName = "fabric_plan_item_id",IsPrimaryKey = true)]
        public Int64 FabricPlanItemID { get; set; }
        /// <summary>
        /// 面料计划单ID
        /// </summary>
        [SugarColumn(ColumnName = "fabric_plan_id")]
        public Int64 FabricPlanID { get; set; }
        /// <summary>
        /// 面料名称
        /// </summary>
        [SugarColumn(ColumnName = "fabric_name")]
        public String FabricName { get; set; }
        /// <summary>
        /// 面料编码
        /// </summary>
        [SugarColumn(ColumnName = "fabric_code")]
        public String FabricCode { get; set; }
        /// <summary>
        /// 颜色名称
        /// </summary>
        [SugarColumn(ColumnName = "color_name")]
        public String ColorName { get; set; }
        /// <summary>
        /// 颜色编码
        /// </summary>
        [SugarColumn(ColumnName = "color_code")]
        public String ColorCode { get; set; }
        /// <summary>
        /// 重量 kg
        /// </summary>
        [SugarColumn(ColumnName = "number")]
        public Double Number { get; set; }
 
    }
}
