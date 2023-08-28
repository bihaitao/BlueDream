using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 密钥表
    /// </summary>
    [SugarTable("t_rsa")]
    public class RsaEntity:BaseEntity
    {
        /// <summary>
        /// 密钥ID
        /// </summary>
        [SugarColumn(ColumnName = "rsa_id", IsPrimaryKey = true)]
        public long RsaID { get; set; }
        /// <summary>
        /// 公钥
        /// </summary>
        [SugarColumn(ColumnName = "public_key")]
        public string PublicKey { get; set; } = "";
        /// <summary>
        /// 私钥
        /// </summary>
        [SugarColumn(ColumnName = "private_key")]
        public string PrivateKey { get; set; } = "";
        /// <summary>
        /// 说明
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; } = "";

    }
}
