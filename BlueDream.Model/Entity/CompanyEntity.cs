using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    ///   公司表
    /// </summary>
    [SugarTable("t_company")]
    public class CompanyEntity : BaseEntity
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        [SugarColumn(ColumnName = "company_id",IsPrimaryKey = true)]
        public Int64 CompanyID { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        [SugarColumn(ColumnName = "company_name")]
        public String CompanyName { get; set; }
        /// <summary>
        /// 检索关键字
        /// </summary>
        [SugarColumn(ColumnName = "search_key")]
        public String SearchKey { get; set; }
 
 
    }
}
