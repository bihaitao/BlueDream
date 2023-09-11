using BlueDream.Dal;
using BlueDream.Enum;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class BrandBll
    {
        public BrandBll() { }

        /// <summary>
        /// 获取品牌
        /// </summary>
        /// <param name="p_BrandID"></param>
        /// <returns></returns>
        public static BrandEntity GetBrandByID(long p_BrandID)
        {
            return BrandDal.GetBrandByID(DBHelper.CreateReadOnlyClient(), p_BrandID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<BrandEntity> GetBrandListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        { 
            return BrandDal.GetBrandListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
        }


      
    }
}
