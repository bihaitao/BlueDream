using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_raw_material_inventory_in")]
    public class RawMaterialInventoryInEntity : BaseEntity
    {
        /// <summary>
        /// 采购入库ID
        /// </summary>
        [SugarColumn(ColumnName = "raw_material_inventory_in_id",IsPrimaryKey = true)]
        public long RawMaterialInventoryInID { get; set; }
        /// <summary>
        /// 采购单ID
        /// </summary>
        [SugarColumn(ColumnName = "procurement_id")]
        public long ProcurementID { get; set; }
        /// <summary>
        /// 采购单明细
        /// </summary>
        [SugarColumn(ColumnName = "procurement_detail_id")]
        public long ProcurementDetailID { get; set; }
        /// <summary>
        /// 入库前库存数
        /// </summary>
        [SugarColumn(ColumnName = "before_quantity")]
        public string BeforeQuantity { get; set; }
        /// <summary>
        /// 入库前加权平均
        /// </summary>
        [SugarColumn(ColumnName = "before_weighted_average")]
        public double BeforeWeightedAverage { get; set; }
        /// <summary>
        /// 入库数量
        /// </summary>
        [SugarColumn(ColumnName = "in_quantity")]
        public int InQuantity { get; set; }
        /// <summary>
        /// 入库单价
        /// </summary>
        [SugarColumn(ColumnName = "in_unit_price")]
        public decimal InUnitPrice { get; set; }
        /// <summary>
        /// 入库后数量
        /// </summary>
        [SugarColumn(ColumnName = "afert_quantity")]
        public string AfertQuantity { get; set; }
        /// <summary>
        /// 入库后加权平均
        /// </summary>
        [SugarColumn(ColumnName = "afert_weighted_average")]
        public decimal AfertWeightedAverage { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        [SugarColumn(ColumnName = "in_date")]
        public DateTime InDate { get; set; }
    }
}
