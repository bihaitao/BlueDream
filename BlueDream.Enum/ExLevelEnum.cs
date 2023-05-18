using System.ComponentModel;

namespace BlueDream.Enum
{
    /// <summary>
    /// 异常等级
    /// </summary> 
    [Description("异常等级")]
    public enum ExLevelEnum : byte
    {
        /// <summary>
        /// 忽略（只是单纯记录日常日志信息)
        /// </summary>
        [Description("忽略")]
        Ignore = 1,

        /// <summary>
        /// 低级（偶尔出现不影响使用)
        /// </summary>
        [Description("低级")]
        Low = 2,

        /// <summary>
        /// 中级 影响部分功能 需写日记
        /// </summary>
        [Description("中级")]
        Medium = 3,

        /// <summary>
        /// 高级 严重错误需要发邮件
        /// </summary>
        [Description("高级")]
        High = 4,

        /// <summary>
        /// 紧急（系统崩溃） 需发邮件,立马解决
        /// </summary>
        [Description("紧急")]
        Critical = 5
        
    }

}
