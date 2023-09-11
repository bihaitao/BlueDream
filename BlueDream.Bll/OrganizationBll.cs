using BlueDream.Dal;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    /// <summary>
    /// 
    /// </summary>
    public class OrganizationBll
    {
        /// <summary>
        /// 获取组织信息
        /// </summary>
        /// <param name="p_OrganizationID"></param>
        /// <returns></returns>
        public static OrganizationEntity GetOrganizationByID(long p_OrganizationID)
        {
            return OrganizationDal.GetOrganizationByID(DBHelper.CreateReadOnlyClient(), p_OrganizationID);
        }

        /// <summary>
        /// 根据ReaKeyID 获取key 信息.....
        /// </summary>
        /// <param name="p_SearchKey"秘钥ID></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetOrganizationListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int m_TotalCount)
        {
            return OrganizationDal.GetOrganizationListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref m_TotalCount);
        }
         
    }


}
