using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlueDream.Enum
{
    ///  RsaKey类型
    /// </summary> 
    [Description("RsaKey类型")]
    public enum KeyTypeEnum : byte
    {
        /// <summary>
        /// 未初始化
        /// </summary>
        [Description("未初始化")]
        NoInit = 0,

        /// <summary>
        /// 系统
        /// </summary>
        [Description("系统")]
        System = 1,

        /// <summary>
        /// 用户
        /// </summary>
        [Description("用户")]
        User = 2,
    }
}
