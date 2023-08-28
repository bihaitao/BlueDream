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
        public long RuleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [SugarColumn(ColumnName = "rule_name")]
        public string RuleName { get; set; } = "";
        /// <summary>
        /// 显示名称
        /// </summary>
        [SugarColumn(ColumnName = "nick_name")]
        public string NickName { get; set; } = "";
        /// <summary>
        /// 说明
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; } = "";

    }
}
