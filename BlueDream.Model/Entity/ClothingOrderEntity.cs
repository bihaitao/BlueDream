using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 采购单
    /// </summary>
    [SugarTable("t_clothing_order")]
    public class ClothingOrderEntity : BaseEntity
    {
        /// <summary>
        /// 采购单ID
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_id",IsPrimaryKey = true)]
        public Int64 ClothingOrderID { get; set; }
        /// <summary>
        /// 采购单编号
        /// </summary>
        [SugarColumn(ColumnName = "clothing_order_no")]
        public String ClothingOrderNo { get; set; }
        /// <summary>
        /// 合同ID
        /// </summary>
        [SugarColumn(ColumnName = "contract_id")]
        public Int64 ContractID { get; set; }
        /// <summary>
        /// 采购方ID,关联t_company
        /// </summary>
        [SugarColumn(ColumnName = "purchaser_company_id")]
        public Int64 PurchaserCompanyID { get; set; }
        /// <summary>
        /// 销售方公司ID,关联t_company
        /// </summary>
        [SugarColumn(ColumnName = "seller_company_id")]
        public Int64 SellerCompanyID { get; set; }
  
    }
}
