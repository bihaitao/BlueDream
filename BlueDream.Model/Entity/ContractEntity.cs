using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 合同表
    /// </summary>
    [SugarTable("t_contract")]
    public class ContractEntity : BaseEntity
    {
        /// <summary>
        /// 合同ID
        /// </summary>
        [SugarColumn(ColumnName = "contract_id",IsPrimaryKey = true)]
        public Int64 ContractID { get; set; }
        /// <summary>
        ///  合同编号
        /// </summary>
        [SugarColumn(ColumnName = "contract_no")]
        public String ContractNo { get; set; }
        /// <summary>
        /// 联纺公司ID（联纺，锦至。。。）
        /// </summary>
        [SugarColumn(ColumnName = "company_a_id")]
        public Int64 CompanyAID { get; set; }
        /// <summary>
        /// 联纺公司名称（联纺，锦至。。。）
        /// </summary>
        [SugarColumn(ColumnName = "company_a_name")]
        public String CompanyAName { get; set; }
        /// <summary>
        /// 外部公司ID
        /// </summary>
        [SugarColumn(ColumnName = "company_b_id")]
        public Int64 CompanyBID { get; set; }
        /// <summary>
        /// 外部公司名称
        /// </summary>
        [SugarColumn(ColumnName = "company_b_name")]
        public String CompanyBName { get; set; }
        /// <summary>
        /// 合同主要内容
        /// </summary>
        [SugarColumn(ColumnName = "contract_text")]
        public string ContractText { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [SugarColumn(ColumnName = "begin_time")]
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [SugarColumn(ColumnName = "end_time")]
        public DateTime EndTime { get; set; }
      
 
    }
}
