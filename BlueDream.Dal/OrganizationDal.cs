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
        public static List<OrganizationEntity> GetListByWhere(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey,ref int  m_TotalCount)
        {
            List<OrganizationEntity> m_Result = new List<OrganizationEntity>();
 
            m_Result = p_DBClient.Instance.Queryable<OrganizationEntity>()
                 .Where(t => t.DataState == DataStateEnum.Valid)
                 .WhereIF(p_SearchKey != "*", 
                     t =>t.OrgCode.Contains(p_SearchKey) || 
                     t.OrgShortName.Contains(p_SearchKey) ||
                     t.OrgEnName.Contains(p_SearchKey) ||
                     t.OrgCnName.Contains(p_SearchKey))
                 .OrderBy(x => x.CreateTime, OrderByType.Desc)
                .ToPageList(p_PageIndex, p_PageSize,ref m_TotalCount);
            return m_Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_PageSize">页面大小</param>
        /// <param name="p_PageIndex">页面索引</param>
        /// <param name="p_SearchKey">搜索词</param>
        /// <returns></returns>
        public static List<OrganizationEntity> GetListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return p_DBClient.Instance.Queryable<OrganizationEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .WhereIF((p_SearchKey != "*"), 
                  t => t.OrgCnName.Contains(p_SearchKey) || 
                  t.OrgEnName.Contains(p_SearchKey) ||
                  t.OrgShortName.Contains(p_SearchKey) ||
                  t.OrgCode.Contains(p_SearchKey))
              .ToPageList(p_PageIndex, p_PageSize, ref p_TotalCount);
        }
    }
}
