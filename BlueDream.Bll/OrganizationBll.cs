using BlueDream.Dal;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class OrganizationBll
    {
        /// <summary>
        /// 根据ReaKeyID 获取key 信息.....
        /// </summary>
        /// <param name="p_SearchKey"秘钥ID></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetOrganization(string p_SearchKey)
        {
            return OrganizationDal.GetListByWhere(DBHelper.CreateReadOnlyClient(), p_SearchKey);
        }
    }
}
