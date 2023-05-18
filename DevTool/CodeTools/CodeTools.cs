using DevTool.CodeTools.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool.CodeTools
{
    /// <summary>
    /// 代码工具
    /// </summary>
    public class CodeTools
    {
        private static string NameSpaceName = "BlueDream.Model";

        //实体类后缀
        private static string EntityExName = "Entity";

        public static void GenCode(List<TableInfo> p_TableInfoList ,string p_Path)
        {
            string m_Path_Model = $@"{p_Path}Model\";
            Directory.CreateDirectory(m_Path_Model);

            foreach (TableInfo t_TableInfo in p_TableInfoList)
            {
                string m_Code = GenEntity(t_TableInfo); 
                File.WriteAllText( $@"{m_Path_Model}{t_TableInfo.CSharpName}{EntityExName}.cs", m_Code);
            }
        }
        

        public static string GenEntity(TableInfo p_TableInfo)
        {
            StringBuilder m_Code = new StringBuilder();
            m_Code.AppendLine($@"using BlueDream.Enum;");
            m_Code.AppendLine($@"using SqlSugar;");
            m_Code.AppendLine($@"");
            m_Code.AppendLine($@"namespace {NameSpaceName}");
            m_Code.AppendLine($@"{{");
            m_Code.AppendLine($@"    /// <summary>");
            m_Code.AppendLine($@"    /// {p_TableInfo.TableDesc}");
            m_Code.AppendLine($@"    /// </summary>");
            m_Code.AppendLine($@"    [SugarTable(""{p_TableInfo.TableName}"")]"); 
            m_Code.AppendLine($@"    public class {p_TableInfo.CSharpName}{EntityExName}");
            m_Code.AppendLine($@"    {{");

            foreach(ColumnInfo t_ColumnInfo in p_TableInfo.Columns)
            {
                m_Code.AppendLine($@"        /// <summary>");
                m_Code.AppendLine($@"        /// {t_ColumnInfo.ColumnDesc}");
                m_Code.AppendLine($@"        /// </summary>");
                if(t_ColumnInfo.IsPrimaryKey)
                {
                    m_Code.AppendLine($@"        [SugarColumn(ColumnName = ""{t_ColumnInfo.ColumnName}"",IsPrimaryKey = true)]");
                }
                else
                {
                    m_Code.AppendLine($@"        [SugarColumn(ColumnName = ""{t_ColumnInfo.ColumnName}"")]");
                }
               
                m_Code.AppendLine($@"        public {t_ColumnInfo.CSharpType} {t_ColumnInfo.CSharpName} {{ get; set; }}");
            }
          
            m_Code.AppendLine($@"    }}");
            m_Code.AppendLine($@"}}");

            return m_Code.ToString(); 
        }
        
        /// <summary>
        /// 将TableName和ColumnName转换成ClassName
        /// </summary>
        public static void FillCodeName(List<TableInfo> p_TableInfoList)
        {
            foreach (TableInfo t_TableInfo in p_TableInfoList)
            {
                t_TableInfo.CSharpName = GetTitleCaseName(t_TableInfo.TableName);

                foreach (ColumnInfo t_ColumnInfo in t_TableInfo.Columns)
                {
                    t_ColumnInfo.CSharpName = GetTitleCaseName(t_ColumnInfo.ColumnName);
                }
            }
        }

        /// <summary>
        /// 将Table和Column的名字转换成C#代码所需要的名字
        /// </summary>
        /// <param name="p_TableName"></param>
        /// <returns></returns>
        private static string GetTitleCaseName(string p_TableName)
        {
            if (p_TableName.IndexOf("t_") == 0)
            {
                p_TableName = p_TableName.Substring(2, p_TableName.Length - 2);
            }

            List<string> m_StringList = p_TableName.Split('_').ToList();

            string m_NewName = "";

            foreach (string t_Value in m_StringList)
            {
                if (t_Value.ToLower() == "id")
                {
                    m_NewName += "ID";
                }
                else
                {
                    m_NewName += System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(t_Value.ToLower());
                } 
            }

            return m_NewName;
        }
    }
}
