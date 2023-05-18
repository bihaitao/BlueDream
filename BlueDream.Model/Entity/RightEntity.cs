using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_right")]
    public class RightEntity
    {
        /// <summary>
        /// 111
        /// </summary>
        [SugarColumn(ColumnName = "rigth_id",IsPrimaryKey = true)]
        public Int64 RigthID { get; set; }
        /// <summary>
        /// 222
        /// </summary>
        [SugarColumn(ColumnName = "right_key")]
        public String RightKey { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "right_name")]
        public String RightName { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public String Info { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_user")]
        public String CreateUser { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_user_id")]
        public Int64 CreateUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_user")]
        public String UpdateUser { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_user_id")]
        public Int64 UpdateUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_time")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "data_state")]
        public DataStateEnum DataState { get; set; }
    }
}
