using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// ��ɫ��
    /// </summary>
    [SugarTable("t_rule")]
    public class RuleEntity
    {
        /// <summary>
        /// ��ɫID
        /// </summary>
        [SugarColumn(ColumnName = "rule_id", IsPrimaryKey = true)]
        public long RuleID { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        [SugarColumn(ColumnName = "rule_name")]
        public string RuleName { get; set; } = "";
        /// <summary>
        /// ��ʾ����
        /// </summary>
        [SugarColumn(ColumnName = "nick_name")]
        public string NickName { get; set; } = "";
        /// <summary>
        /// ˵��
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; } = "";

    }
}
