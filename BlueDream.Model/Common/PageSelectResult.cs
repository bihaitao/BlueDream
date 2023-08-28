using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDream.Model
{
    public class PageSelectResult<T>
    {
        /// <summary>
        /// 页面大小
        /// </summary>
        public int PageSize { get; set; } = 0;

        /// <summary>
        /// 当前页索引
        /// </summary>
        public int PageIndex { get; set; } = 0;

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { set; get; }

        /// <summary>
        /// 查询结果
        /// </summary>
        public List<T> DataRows { set; get; }
    }
}
