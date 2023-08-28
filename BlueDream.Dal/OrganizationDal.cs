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
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetListByWhere(DBClient p_DBClient, string p_SearchKey)
        {
            List<OrganizationEntity> m_Result = new List<OrganizationEntity>();
 
            m_Result = p_DBClient.Instance.Queryable<OrganizationEntity>()
                 .Where(t => t.DataState == DataStateEnum.Valid)
                 .WhereIF(!string.IsNullOrWhiteSpace(p_SearchKey), 
                     t =>t.OrgCode.Contains(p_SearchKey) || 
                     t.OrgShortName.Contains(p_SearchKey) ||
                     t.OrgEnName.Contains(p_SearchKey) ||
                     t.OrgCnName.Contains(p_SearchKey))
                 .OrderBy(x => x.CreateTime, OrderByType.Desc)
                 .ToList(); 
            return m_Result;
        }
    }
}
