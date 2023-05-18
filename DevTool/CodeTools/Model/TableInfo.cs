using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool.CodeTools.Model
{
    public class TableInfo
    {
        public TableInfo() {
            Columns = new List<ColumnInfo>();
        }

        /// <summary>
        /// 表名称
        /// </summary>
        public string TableName { get; set; } = "";

        /// <summary>
        /// 字段名字
        /// </summary>
        public string CSharpName { get; set; } = "";

        /// <summary>
        /// 表注释
        /// </summary>
        public string TableDesc { get; set; } = "";


        public List<ColumnInfo> Columns { get; set; }
    }
}
