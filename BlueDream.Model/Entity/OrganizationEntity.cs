using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 组织表
    /// </summary>
    [SugarTable("t_organization")]
    public class OrganizationEntity : BaseEntity
    {
        /// <summary>
        /// 组织ID
        /// </summary>
        [SugarColumn(ColumnName = "org_id",IsPrimaryKey = true)]
        public long OrgID { get; set; }
        /// <summary>
        /// 组织编码
        /// </summary>
        [SugarColumn(ColumnName = "org_code")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        [SugarColumn(ColumnName = "org_short_name")]
        public string OrgShortName { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        [SugarColumn(ColumnName = "org_cn_name")]
        public string OrgCnName { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        [SugarColumn(ColumnName = "org_en_name")]
        public string OrgEnName { get; set; }
    }
}
