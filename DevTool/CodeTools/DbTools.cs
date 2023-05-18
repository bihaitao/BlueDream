using DevTool.CodeTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;

namespace DevTool.CodeTools
{
    public class DbTools
    {
        public static List<TableInfo> GetMySqlInfo(string p_ConStr)
        {
            List<TableInfo> m_TableInfoList = GetAllTableInfo(p_ConStr);

            foreach (TableInfo t_TableInfo in m_TableInfoList)
            {
                FillColumnInfo(t_TableInfo, p_ConStr);
            }

            return m_TableInfoList;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static List<TableInfo> GetAllTableInfo(string p_ConStr)
        {
            List<TableInfo> m_TableInfoList = new List<TableInfo>();
            MySqlConnection m_MySqlConnection = new MySqlConnection(p_ConStr);
            MySqlCommand m_MySqlCommand = m_MySqlConnection.CreateCommand();

            m_MySqlCommand.CommandType = System.Data.CommandType.Text;
            m_MySqlCommand.CommandText = $@"select table_name,table_comment from information_schema.tables where TABLE_SCHEMA = '{m_MySqlConnection.Database}';";
            m_MySqlConnection.Open();
            MySqlDataReader m_MySqlDataReader = m_MySqlCommand.ExecuteReader();

            while (m_MySqlDataReader.Read())
            {
                TableInfo m_TableInfo = new TableInfo();
                m_TableInfo.TableName = Convert.ToString(m_MySqlDataReader["table_name"]);
                m_TableInfo.TableDesc = Convert.ToString(m_MySqlDataReader["table_comment"]);
                m_TableInfoList.Add(m_TableInfo);
            }

            m_MySqlConnection.Close();

            return m_TableInfoList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static void FillColumnInfo(TableInfo p_TableInfo,string p_ConStr)
        {
            MySqlConnection m_MySqlConnection = new MySqlConnection(p_ConStr);
            MySqlCommand m_MySqlCommand = m_MySqlConnection.CreateCommand();

            m_MySqlCommand.CommandType = System.Data.CommandType.Text;
            m_MySqlCommand.CommandText = $@"select COLUMN_NAME,data_type,COLUMN_KEY,column_comment from information_schema.columns where TABLE_NAME = '{p_TableInfo.TableName}' and TABLE_SCHEMA = '{m_MySqlConnection.Database}';";
            m_MySqlConnection.Open();
            MySqlDataReader m_MySqlDataReader = m_MySqlCommand.ExecuteReader();

            while (m_MySqlDataReader.Read())
            {
                ColumnInfo m_ColumnInfo = new ColumnInfo();
                m_ColumnInfo.ColumnName = Convert.ToString(m_MySqlDataReader["COLUMN_NAME"]);
                m_ColumnInfo.DataType = Convert.ToString(m_MySqlDataReader["data_type"]);

                m_ColumnInfo.CSharpType = GetCSharpType(m_ColumnInfo.DataType);

                

                m_ColumnInfo.ColumnDesc = Convert.ToString(m_MySqlDataReader["column_comment"]);

                if (Convert.ToString(m_MySqlDataReader["COLUMN_KEY"]).ToUpper() == "PRI")
                {
                    m_ColumnInfo.IsPrimaryKey = true;
                }
                else
                {
                    m_ColumnInfo.IsPrimaryKey = false;
                }

                p_TableInfo.Columns.Add(m_ColumnInfo);
            }

            m_MySqlConnection.Close();
        }

        /// <summary>
        /// 将mysql 数据类型转换为C#数据类型 
        /// </summary>
        /// <param name="p_MySqlDataType"></param>
        /// <returns></returns>
        public static string GetCSharpType(string p_MySqlDataType)
        {
            //https://www.cnblogs.com/HopeGi/archive/2013/02/07/2909018.html

            switch (p_MySqlDataType.ToUpper())
            { 
                case "VARCHAR": return "String";
                case "CHAR": return "string";
                case "BLOB": return "byte";
                case "TEXT": return "string";
                case "INTEGER": return "Int64";
                case "TINYINT": return "Enum";
                case "SMALLINT": return "Int33";
                case "MEDIUMINT": return "Int34";
                case "BIT": return "Boolean";
                case "BIGINT": return "Int64";
                case "FLOAT": return "Single";
                case "DOUBLE": return "Double";
                case "DECIMAL": return "Decimal";
                case "BOOLEAN": return "Int32";
                case "ID": return "Int64";
                case "DATE": return "DateTime";
                case "TIME": return "DateTime";
                case "DATETIME": return "DateTime";
                case "TIMESTAMP": return "DateTime";
                case "YEAR": return "DateTime";
                case "ENUM": return "string";
                default: return $@"NoType({p_MySqlDataType})";
            }
        }
    }
}


