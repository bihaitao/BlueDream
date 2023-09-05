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
        public static List<OrganizationEntity> GetOrganization(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int m_TotalCount)
        {
            return OrganizationDal.GetListByWhere(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref m_TotalCount);
        }

        /// <summary>
        /// 根据ReaKeyID 获取key 信息.....
        /// </summary>
        /// <param name="p_SearchKey"秘钥ID></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetTop10(string p_SearchKey)
        {
            int m_TotalCount = 0;
            return OrganizationDal.GetListByWhere(DBHelper.CreateReadOnlyClient(), 10, 1, p_SearchKey, ref m_TotalCount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return OrganizationDal.GetListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
        }
    }


}
