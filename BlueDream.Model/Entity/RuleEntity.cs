using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 角色表
    /// </summary>
    [SugarTable("t_rule")]
    public class RuleEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [SugarColumn(ColumnName = "rule_id", IsPrimaryKey = true)]
        public Int64 RuleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [SugarColumn(ColumnName = "rule_name")]
        public String RuleName { get; set; } = "";
        /// <summary>
        /// 显示名称
        /// </summary>
        [SugarColumn(ColumnName = "nick_name")]
        public String NickName { get; set; } = "";
        /// <summary>
        /// 说明
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public String Info { get; set; } = "";

    }
}
