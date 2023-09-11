using BlueDream.Enum;
using BlueDream.Model;
using BlueDream.Model.Model;

namespace BlueDream.Dal
{
    public class UserDal
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_UserID"></param>
        /// <returns></returns>
        public static UserEntity GetUserByID(DBClient p_DBClient, long p_UserID)
        {
            return p_DBClient.Instance.Queryable<UserEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .Where(t => t.UserID == p_UserID)
              .First();
        }


        /// <summary>
        /// 根据用户名获取用户实体信息
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_UserName">用户名</param>
        /// <returns></returns>
        public static UserEntity GetUserByUserName(DBClient p_DBClient, string p_UserName)
        { 
            return p_DBClient.Instance.Queryable<UserEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .Where(t => t.UserName == p_UserName)
              .First(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_PageSize">页面大小</param>
        /// <param name="p_PageIndex">页面索引</param>
        /// <param name="p_SearchKey">搜索词</param>
        /// <returns></returns>
        public static List<UserEntity> GetUserListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return p_DBClient.Instance.Queryable<UserEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .WhereIF((p_SearchKey != "*"), t => t.UserName.Contains(p_SearchKey)|| t.NickName.Contains(p_SearchKey))
              .ToPageList(p_PageIndex, p_PageSize, ref p_TotalCount);
        }

    }
}