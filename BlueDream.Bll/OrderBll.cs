using BlueDream.Dal;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class OrderBll
    {
        public static List<OrderEntity> GetListByPage(int p_PageSize,int p_PageIndex,string p_SearchKey)
        {
            return OrderDal.GetListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey);
        }
    }
}
