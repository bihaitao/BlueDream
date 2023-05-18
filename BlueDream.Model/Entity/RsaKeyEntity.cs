using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// RsaKey表
    /// </summary>
    [SugarTable("t_RsaKeys")]
    public class RsaKeyEntity : BaseEntity
    {
        /// <summary>
        ///  秘钥ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public long RsaKeyID { set; get; }

        /// <summary>
        ///  公钥
        /// </summary>
        public string PublicKey { set; get; } = "";

        /// <summary>
        ///  私钥
        /// </summary>
        public string PrivateKey { set; get; } = "";

        /// <summary>
        /// 密钥类型 1 系统 2 用户
        /// </summary>
        public KeyTypeEnum KeyType { set; get; }

        /// <summary>
        ///  备注
        /// </summary>
        public string Remarks { set; get; } = "";
    }
}
