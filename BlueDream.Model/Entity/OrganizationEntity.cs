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
        [SugarColumn(ColumnName = "organization_id", IsPrimaryKey = true)]
        public long OrganizationID { get; set; }
        /// <summary>
        /// 组织编码
        /// </summary>
        [SugarColumn(ColumnName = "organization_code")]
        public string OrganizationCode { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        [SugarColumn(ColumnName = "organization_short_name")]
        public string OrganizationShortName { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        [SugarColumn(ColumnName = "organization_cn_name")]
        public string OrganizationCnName { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        [SugarColumn(ColumnName = "organization_en_name")]
        public string OrganizationEnName { get; set; }
    }
}
