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
        public Int64 RsaID { get; set; }
        /// <summary>
        /// 公钥
        /// </summary>
        [SugarColumn(ColumnName = "public_key")]
        public String PublicKey { get; set; } = "";
        /// <summary>
        /// 私钥
        /// </summary>
        [SugarColumn(ColumnName = "private_key")]
        public String PrivateKey { get; set; } = "";
        /// <summary>
        /// 说明
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public String Info { get; set; } = "";

    }
}
