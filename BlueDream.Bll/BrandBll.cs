﻿using BlueDream.Dal;
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
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<BrandEntity> GetTop10()
        {
            return GetTop10("*");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<BrandEntity> GetTop10(string p_SearchKey)
        {
            int m_TotalCount = 0 ;
            return BrandDal.GetListByPage(DBHelper.CreateReadOnlyClient(), 10, 1, p_SearchKey,ref m_TotalCount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<BrandEntity> GetListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        { 
            return BrandDal.GetListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
        }
    }
}