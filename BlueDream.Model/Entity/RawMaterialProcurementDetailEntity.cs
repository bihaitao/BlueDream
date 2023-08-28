using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_raw_material_procurement_detail")]
    public class RawMaterialProcurementDetailEntity : BaseEntity
    {
        /// <summary>
        /// 采购明细ID
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_procurement_detail_id",IsPrimaryKey = true)]
        public long RawMaterialProcurementDetailID { get; set; }
        /// <summary>
        /// 采购单ID
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_procurement_id")]
        public long RawMaterialProcurementID { get; set; }
        /// <summary>
        /// 材料编码
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_code")]
        public string RawMaterialCode { get; set; }
        /// <summary>
        /// 材料名称
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_name")]
        public string RawMaterialName { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [SugarColumn(ColumnName = "quantity")]
        public int Quantity { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [SugarColumn(ColumnName = "unit_price")]
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        [SugarColumn(ColumnName = "total_price")]
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 交期
        /// </summary>
        [SugarColumn(ColumnName = "delivery")]
        public DateTime Delivery { get; set; }
    }
}
