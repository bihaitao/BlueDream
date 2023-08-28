using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_raw_material_inventory")]
    public class RawMaterialInventoryEntity : BaseEntity
    {
        /// <summary>
        /// 原材料编码
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_code",IsPrimaryKey = true)]
        public string RawMaterialCode { get; set; }
        /// <summary>
        /// 原材料名称
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_name")]
        public string RawMaterialName { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [SugarColumn(ColumnName = "inventory_quantity")]
        public int InventoryQuantity { get; set; }
        /// <summary>
        /// 加权平均价格
        /// </summary>
        [SugarColumn(ColumnName = "weighted_average")]
        public decimal WeightedAverage { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; }
    }
}
