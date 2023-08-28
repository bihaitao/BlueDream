using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_raw_material_inventory_out")]
    public class RawMaterialInventoryOutEntity : BaseEntity
    {
        /// <summary>
        /// 出库ID
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_inventory_out_id")]
        public long RawMaterialInventoryOutID { get; set; }
        /// <summary>
        /// 原材料编码
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_code")]
        public string RawMaterialCode { get; set; }
        /// <summary>
        /// 出库数量
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_name")]
        public string RawMaterialName { get; set; }
        /// <summary>
        /// 出库数量
        /// </summary>
        [SugarColumn(ColumnName = "out_quantity")]
        public int OutQuantity { get; set; }
        /// <summary>
        /// 出库价格
        /// </summary>
        [SugarColumn(ColumnName = "out_unit_price")]
        public decimal OutUnitPrice { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        [SugarColumn(ColumnName = "business_type")]
        public BusinessTypeEnum BusinessType { get; set; }
        /// <summary>
        /// 业务标识
        /// </summary>
        [SugarColumn(ColumnName = "business_id")]
        public long BusinessID { get; set; }
    }
}
