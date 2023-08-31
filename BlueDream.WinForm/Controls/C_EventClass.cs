using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm.Controls
{
    /// <summary>
    /// 事件类
    /// </summary>
    public class C_EventClass
    {
        /// <summary>
        /// 当前页改变时的事件委托
        /// </summary>
        /// <param name="sender">自身</param>
        /// <param name="e">事件数据类</param>
        public delegate void OnPagerIndexChangedEventHandler(object sender, C_EventArgsClass e);

        /// <summary>
        /// 每页行数改变时的事件委托
        /// </summary>
        /// <param name="sender">自身</param>
        /// <param name="e">事件数据类</param>
        public delegate void OnPagerNumChangedEventHandler(object sender, C_EventArgsClass e);
    }

    /// <summary>
    /// 事件数据类
    /// </summary>
    public class C_EventArgsClass
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPagerIndex { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        public int PagerNum { get; set; }
    }
}
