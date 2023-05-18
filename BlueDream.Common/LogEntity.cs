using BlueDream.Enum;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDream.Common
{
    [SugarTable("t_Log")]
    public class LogEntity
    {
        /// <summary>
        /// 日志表ID
        /// </summary>
        public long LogID { set; get; }
        /// <summary>
        /// 日志主题
        /// </summary>
        public string Title { set; get; } = "";
        /// <summary>
        /// 名称(暂时没用到)
        /// </summary>
        public string SysName { set; get; } = "";
        /// <summary>
        /// 错误编码(暂时没用到)
        /// </summary>
        public string ExCode { set; get; } = "";
        /// <summary>
        /// 日志信息
        /// </summary>
        public string LogTxt { set; get; } = "";
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }
        /// <summary>
        /// 异常key
        /// </summary>
        public string ExKey { set; get; } = "";
        /// <summary>
        /// 异常堆栈信息
        /// </summary>
        public string StackTrace { set; get; } = "";
        /// <summary>
        /// 异常等级信息
        /// </summary>
        public ExLevelEnum Level { set; get; }


    }

}
