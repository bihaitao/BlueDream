using BlueDream.WinForm;
using System;
using System.Collections.Generic;

namespace BlueDream.WinForm
{
    /// <summary>
    /// 分页属性设置类
    /// </summary>
    public class ApiPageResult<T> : ApiResult<T>
    {
        /// <summary>
        /// 无参的构造函数
        /// </summary>
        public ApiPageResult() { }


        /// <summary>
        /// 两个入参的构造函数
        /// </summary>
        /// <param name="p_PageIndex"></param>
        /// <param name="p_PageSize"></param>
        public ApiPageResult(int p_PageIndex, int p_PageSize)
        {
            PageIndex = p_PageIndex;
            PageSize = p_PageSize;
        }


        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; }

         
    }
}
