using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_raw_material_procurement")]
    public class RawMaterialProcurementEntity : BaseEntity
    {
        /// <summary>
        /// 原材料采购单ID
        /// </summary>
        [SugarColumn(ColumnName = "procurement_id",IsPrimaryKey = true)]
        public long ProcurementID { get; set; }
        /// <summary>
        /// 采购方组织ID
        /// </summary>
        [SugarColumn(ColumnName = "purchase_org_id")]
        public long PurchaseOrgID { get; set; }
        /// <summary>
        /// 销售方组织ID
        /// </summary>
        [SugarColumn(ColumnName = "sale_org_id")]
        public long SaleOrgID { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        [SugarColumn(ColumnName = "total_price")]
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "unit_price")]
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "purchase_date")]
        public DateTime PurchaseDate { get; set; }
    }
}
