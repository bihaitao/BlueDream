using BlueDream.Enum;
using BlueDream.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class OrganizationDal
    {
        /// <summary>
        /// 获取组织
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_OrgID"></param>
        /// <returns></returns>
        public static OrganizationEntity GetOrganizationByID(DBClient p_DBClient, long p_OrganizationID)
        {
            return p_DBClient.Instance.Queryable<OrganizationEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .Where(t => t.OrganizationID == p_OrganizationID)
              .First();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetOrganizationListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey,ref int  m_TotalCount)
        {
            List<OrganizationEntity> m_Result = new List<OrganizationEntity>();
 
            m_Result = p_DBClient.Instance.Queryable<OrganizationEntity>()
                 .Where(t => t.DataState == DataStateEnum.Valid)
                 .WhereIF(p_SearchKey != "*", 
                     t => t.OrganizationCode.Contains(p_SearchKey) || 
                     t.OrganizationShortName.Contains(p_SearchKey) ||
                     t.OrganizationEnName.Contains(p_SearchKey) ||
                     t.OrganizationCnName.Contains(p_SearchKey))
                 .OrderBy(x => x.CreateTime, OrderByType.Desc)
                .ToPageList(p_PageIndex, p_PageSize,ref m_TotalCount);
            return m_Result;
        }

         

      

    }
}
