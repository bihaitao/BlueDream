using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_user")]
    public class UserEntity:BaseEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(ColumnName = "user_id", IsPrimaryKey = true)]
        public long UserID { get; set; }
        /// <summary>
        /// 用户名（登录用）
        /// </summary>
        [SugarColumn(ColumnName = "user_name")]
        public string UserName { get; set; } = "";
        /// <summary>
        /// 显示名称
        /// </summary>
        [SugarColumn(ColumnName = "nick_name")]
        public string NickName { get; set; } = "";
        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(ColumnName = "password")]
        public string Password { get; set; } = "";

    }
}
