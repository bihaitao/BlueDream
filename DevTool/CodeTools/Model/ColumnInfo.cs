using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool.CodeTools.Model
{
    /// <summary>
    /// 列定义信息
    /// </summary>
    public class ColumnInfo
    {
        /// <summary>
        /// 列名称
        /// </summary>
        public string ColumnName { get; set; } = "";

        /// <summary>
        /// C#名称
        /// </summary>
        public string CSharpName { get; set; } = "";

        /// <summary>
        /// 主键
        /// </summary>
        public bool IsPrimaryKey { get; set; } 

        /// <summary>
        /// 字段注释
        /// </summary>
        public string ColumnDesc { get; set; } = "";

        /// <summary>
        /// 列数据类型
        /// </summary>
        public string DataType { get; set; } = "";

        /// <summary>
        /// 列数据类型
        /// </summary>
        public string CSharpType { get; set; } = "";
    }
}
