using BlueDream.Enum;
using BlueDream.Model;

namespace BlueDream.Dal
{
    public class UserDal
    {
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
    }
}