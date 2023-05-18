using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("t_user")]
    public class UserEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(ColumnName = "user_id",IsPrimaryKey = true)]
        public Int64 UserID { get; set; }
        /// <summary>
        /// 用户名（登录用）
        /// </summary>
        [SugarColumn(ColumnName = "user_name")]
        public String UserName { get; set; } = "";
        /// <summary>
        /// 显示名称
        /// </summary>
        [SugarColumn(ColumnName = "nick_name")]
        public String NickName { get; set; } = "";
        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(ColumnName = "password")]
        public String Password { get; set; } = "";
        /// <summary>
        /// 公钥
        /// </summary>
        [SugarColumn(ColumnName = "rsa_public_key")]
        public String RsaPublicKey { get; set; } = "";
        /// <summary>
        /// 私钥
        /// </summary>
        [SugarColumn(ColumnName = "rsa_private_key")]
        public String RsaPrivateKey { get; set; } = "";
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
