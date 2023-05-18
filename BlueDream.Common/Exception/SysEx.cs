
using BlueDream.Enum;
using System;

namespace BlueDream.Common
{
    /// <summary>
    /// 系统自定义异常实体类
    /// </summary>
    public class SysEx : Exception
    {
        /// <summary>
        /// 异常编码前缀
        /// </summary>
        public string ExPx { set; get; } = "";

        /// <summary>
        /// 异常编码（数字部分）
        /// </summary>
        public string ExCode { set; get; } = "";

        /// <summary>
        /// 异常编码
        /// </summary>
        public string ExFullCode { get { return $"{ExPx}{ExCode}"; } }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ExTitle { set; get; } = "";

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ExMessage { set; get; } = "";

        /// <summary>
        /// 当前堆栈信息
        /// </summary>
        public string StackTraceInfo { set; get; } = "";

        /// <summary>
        /// 异常标识
        /// </summary>
        public string ExKey { set; get; } = "";

        /// <summary>
        /// 异常等级
        /// </summary>
        public ExLevelEnum Level { set; get; }


        public override string ToString()
        {
            return "";
        }

    }
}
