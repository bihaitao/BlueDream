using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 收付款记录
    /// </summary>
    [SugarTable("t_payment")]
    public class PaymentEntity : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "bigint",IsPrimaryKey = true)]
        public long Bigint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "payment_code")]
        public string PaymentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "payment_amount")]
        public decimal PaymentAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "payment_org_id")]
        public long PaymentOrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "payee_org_id")]
        public long PayeeOrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "order_id")]
        public long OrderID { get; set; }
    }
}
