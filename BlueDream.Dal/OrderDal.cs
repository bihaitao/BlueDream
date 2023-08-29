using BlueDream.Enum;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class OrderDal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_UserName"></param>
        /// <returns></returns>
        public static List<OrderEntity> GetListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey)
        {
            return p_DBClient.Instance.Queryable<OrderEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .Where(t => t.CustomerOrderNo.Contains(p_SearchKey))
              .ToPageList(p_PageIndex, p_PageSize);
        }
    }
}
