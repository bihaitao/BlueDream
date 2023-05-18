using BlueDream.Model;
using BlueDream.Dal;
using BlueDream.Common;
using BlueDream.Enum;


namespace BuleDream.Bll
{
    /// <summary>
    /// 秘钥信息操作类
    /// </summary>
    public class RsaKeyBll
    {
        /// <summary>
        /// 根据ReaKeyID 获取key 信息.....
        /// </summary>
        /// <param name="p_RsaKeyID"秘钥ID></param>
        /// <returns></returns>
        public static RsaEntity GetByID(long p_RsaKeyID)
        { 
            return RsaDal.GetByID(DBHelper.CreateReadOnlyClient(), p_RsaKeyID);
        }

        /// <summary>
        /// 获取系统Rsa
        /// </summary> 
        /// <returns></returns>
        public static RsaEntity GetSystemRsa()
        {
            return RsaDal.GetByID(DBHelper.CreateReadOnlyClient(), CfgManager.Instance.RsaID);
        }

        // Tuple<string, string> m_RsaEntity = RsaHelper.GenerateRsaKeys();
        //  m_RsaKeyEntity.PublicKey = m_RsaEntity.Item1;
        //    m_RsaKeyEntity.PrivateKey = m_RsaEntity.Item2;

    }
}

