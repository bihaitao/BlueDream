using System;
using System.Collections.Generic;

namespace BlueDream.Common
{
    /// <summary>
    /// 分页属性设置类
    /// </summary>
    public class PageResult : CommonResult
    {
        /// <summary>
        /// 无参的构造函数
        /// </summary>
        public PageResult(){ }


        /// <summary>
        /// 两个入参的构造函数
        /// </summary>
        /// <param name="p_PageIndex"></param>
        /// <param name="p_PageSize"></param>
        public PageResult(int p_PageIndex, int p_PageSize)
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
       
        /// <summary>
        /// 排序值
        /// </summary>
        public string SortValue { get; set; } = "";

        /// <summary>
        /// 排序规则
        /// </summary>
        public string Desc { get; set; } = "";

        /// <summary>
        /// 页数   
        /// </summary>
        private int m_PageCount;
       
        /// <summary>
        /// 获取页数
        /// </summary>
        public Int32 PageCount
        {
            get
            {
                if (PageSize == 0)
                {
                    return 0;
                }

                if (m_PageCount == 0)
                {
                    m_PageCount = TotalCount / PageSize;
                    if (TotalCount % PageSize > 0)
                    {
                        m_PageCount++;
                    }
                }
                return m_PageCount;
            }
        }
        

        /// <summary>
        /// 当前页开始编号
        /// </summary>
        private int m_RowStart = 0;
       

        public Int32 RowStart
        {
            get
            {
                return m_RowStart == 0 ? (PageIndex - 1) * PageSize + 1 : m_RowStart;
            }
        }


        /// <summary>
        /// 当前页结束编号
        /// </summary>
        private int m_RowEnd = 0;
       

        public Int32 RowEnd
        {
            get { return m_RowEnd == 0 ? PageIndex * PageSize : m_RowEnd; }
        }


        /// <summary>
        /// 显示多少个页
        /// </summary>
        private const int ShowPagerCount = 10;

        
        public Int32 PageStart
        {
            get
            {
                //计算开始值
                int m_Start = PageIndex - ShowPagerCount / 2;

                if (m_Start < 1)
                {
                    return 1;//如果小于1则返回1
                }
                else
                {
                    return m_Start;//否则返回计算值
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public Int32 PageEnd
        {
            get
            {
                //用开始页计算最后页面
                int m_End = PageStart + ShowPagerCount - 1;

                if (m_End > m_PageCount)
                {
                    return m_PageCount;//如果最后页面超过了总也是返回总页数
                }
                else
                {
                    return m_End;//否则返回计算值
                }
            }
        }


        /// <summary>
        /// 最后一页与开始页中间的所有页
        /// </summary>
        public List<int> PageList
        {
            get
            {
                List<int> m_PageList = new List<int>();

                if (PageStart == 0)
                {
                    return m_PageList;
                }

                if (PageStart == PageEnd)
                {
                    m_PageList.Add(PageStart);
                    return m_PageList;
                }

                for (int t_Index = PageStart; t_Index <= PageEnd; t_Index++)
                {
                    m_PageList.Add(t_Index);
                }

                return m_PageList;
            }
        }
    }
}
