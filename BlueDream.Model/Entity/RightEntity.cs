using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 权限表
    /// </summary>
    [SugarTable("t_right")]
    public class RightEntity:BaseEntity
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        [SugarColumn(ColumnName = "rigth_id", IsPrimaryKey = true)]
        public long RigthID { get; set; }
        /// <summary>
        /// 权限Key
        /// </summary>
        [SugarColumn(ColumnName = "right_key")]
        public string RightKey { get; set; } = "";
        /// <summary>
        /// 权限名称
        /// </summary>
        [SugarColumn(ColumnName = "right_name")]
        public string RightName { get; set; } = "";
        /// <summary>
        /// 注释
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; } = "";
    }
}
