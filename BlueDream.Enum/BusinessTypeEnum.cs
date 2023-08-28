using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Enum
{
    public enum BusinessTypeEnum
    {
        /// <summary>
        /// 未初始化
        /// </summary>
        [Description("未初始化")]
        NoInit = 0,
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Order = 1
       
    }
}
