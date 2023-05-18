using System.ComponentModel;

namespace BlueDream.Enum
{
    /// <summary>
    /// 数据状态枚举项
    /// </summary>
    [Description("数据状态枚举项")]
    public enum DataStateEnum
    {
        /// <summary>
        /// 未初始化
        /// </summary>
        [Description("未初始化")]
        NoInit = 0,
        /// <summary>
        /// 有效的
        /// </summary>
        [Description("有效的")]
        Valid = 1,
        /// <summary>
        /// 删除的
        /// </summary>
        [Description("删除的")]
        Delete = 255
    }
}
