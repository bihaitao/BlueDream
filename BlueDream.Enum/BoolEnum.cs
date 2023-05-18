using System.ComponentModel;

namespace BlueDream.Enum
{
    /// <summary>
    /// Bool枚举
    /// </summary> 
    [Description("Bool枚举")]
    public enum BoolEnum : byte 
    {
        /// <summary>
        /// 未初始化
        /// </summary>
        [Description("未初始化")]
        NoInit = 0,
        /// <summary>
        /// 是
        /// </summary>
        [Description("是")]
        Yes = 1,
        /// <summary>
        /// 否
        /// </summary>
        [Description("否")]
        No = 2,
    }

}
