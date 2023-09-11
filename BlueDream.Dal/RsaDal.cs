using BlueDream.Enum;
using BlueDream.Model;

namespace BlueDream.Dal
{
    /// <summary>
    /// 秘钥数据操作类
    /// </summary>
    public class RsaDal
    {
         

        /// <summary>
        /// 根据RsaKey 查询秘钥信息
        /// </summary>
        /// <param name="p_RsaID">秘钥ID</param>
        /// <returns></returns>
        public static RsaEntity GetRsaByID(DBClient p_DBClient, long p_RsaID)
        {
            return p_DBClient.Instance.Queryable<RsaEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .Where(t => t.RsaID == p_RsaID)
              .First();
        }

       


    }
}
