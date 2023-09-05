using BlueDream.Enum;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class BrandDal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_DBClient"></param>
        /// <param name="p_PageSize">页面大小</param>
        /// <param name="p_PageIndex">页面索引</param>
        /// <param name="p_SearchKey">搜索词</param>
        /// <returns></returns>
        public static List<BrandEntity> GetListByPage(DBClient p_DBClient, int p_PageSize, int p_PageIndex, string p_SearchKey,ref int p_TotalCount)
        {
            return p_DBClient.Instance.Queryable<BrandEntity>()
              .Where(t => t.DataState == DataStateEnum.Valid)
              .WhereIF((p_SearchKey != "*"), t => t.BrandCn.Contains(p_SearchKey) || t.BrandEn.Contains(p_SearchKey)) 
              .ToPageList(p_PageIndex, p_PageSize,ref p_TotalCount);
        }
    }
}
