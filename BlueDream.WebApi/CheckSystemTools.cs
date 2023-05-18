using BlueDream.Common;
using BlueDream.Dal;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 系统验证帮助类
    /// </summary>
    public class CheckSystemTools
    {
        /// <summary>
        /// 校验请求服务通讯，数据库连接等是否正常
        /// </summary>
        /// <returns></returns>
        public static string Check()
        {
            StringBuilder m_StringBuilder = new StringBuilder();
            m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            Check_ReadWriteConnection(m_StringBuilder);
            m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            Check_ReadOnlyConnection(m_StringBuilder);
            m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            Check_LogConnection(m_StringBuilder);
            m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            //Check_LogicPath(m_StringBuilder);
            //m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            //查询Log数量
            Check_LogCount(m_StringBuilder);
            m_StringBuilder.Append($"<br/>------------------------------------------------------------------------- ");

            //MqConnection(m_StringBuilder);
            return m_StringBuilder.ToString();
        }


        

       


        /// <summary>
        /// 解析URL地址
        /// </summary>
        /// <param name="p_Url"></param>
        /// <returns></returns>
        private static string[] GetTelnetInfo(string p_Url)
        {
            string m_Chart = "//";
            string m_Url = p_Url;
            if (p_Url.IndexOf("//") > 0)
            {
                m_Url = p_Url.Substring(p_Url.IndexOf("//") + m_Chart.Length, m_Url.Length - p_Url.IndexOf("//") - m_Chart.Length);
            }

            if (m_Url.IndexOf("/") > 0)
            {
                m_Url = m_Url.Substring(0, m_Url.IndexOf("/"));
            }
            string m_TempUrl = m_Url;
            string m_Point = "80";
            if (m_Url.IndexOf(":") > 0)
            {
                m_Url = m_TempUrl.Substring(0, m_TempUrl.IndexOf(":"));
                m_Point = m_TempUrl.Substring(m_TempUrl.IndexOf(":") + 1, m_TempUrl.Length - m_TempUrl.IndexOf(":") - 1);
            }
            string[] m_Result = { m_Url, m_Point };
            return m_Result;
        }


        /// <summary>
        /// 校验ReadWriteConnection 数据库连接
        /// </summary>
        /// <param name="p_StringBuilder"></param>
        public static void Check_ReadWriteConnection(StringBuilder p_StringBuilder)
        {
            p_StringBuilder.Append($"<br/>开始测试 ReadWriteConnection！ ");
            ReadCon(CfgManager.Instance.ReadWriteConnection, p_StringBuilder);
        }


        /// <summary>
        /// 校验 ReadOnlyConnection 数据库连接
        /// </summary>
        /// <param name="p_StringBuilder"></param>
        public static void Check_ReadOnlyConnection(StringBuilder p_StringBuilder)
        {
            p_StringBuilder.Append($"<br/>开始测试 ReadOnlyConnection！ ");
            ReadCon(CfgManager.Instance.ReadOnlyConnection, p_StringBuilder);
        }


        /// <summary>
        /// 校验 LogConnection 数据库连接
        /// </summary>
        /// <param name="p_StringBuilder"></param>
        public static void Check_LogConnection(StringBuilder p_StringBuilder)
        {
            p_StringBuilder.Append($"<br/>开始测试 LogConnection！ ");
            ReadCon(CfgManager.Instance.LogConnection, p_StringBuilder);
        }


        /// <summary>
        /// 校验数据库连接
        /// </summary>
        /// <param name="p_StrConn">数据连接字符串</param>
        /// <param name="p_StringBuilder"></param>
        private static void ReadCon(string p_StrConn, StringBuilder p_StringBuilder)
        {
            try
            {
                Dictionary<string, string> m_DBKeyValue = ConnectionStrKeyValue(p_StrConn);

                //校验端口是否通

                string[] m_UserInfo = { m_DBKeyValue["server"], m_DBKeyValue["port"] };
                p_StringBuilder.Append($"<br/>Server :{m_UserInfo[0]}:{m_UserInfo[1]} ");
               

                p_StringBuilder.Append($"<br/>{Convert.ToString(CfgManager.Instance.DataBaseType)}");

                SqlSugarClient m_SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = p_StrConn,
                    DbType = CfgManager.Instance.DataBaseType,
                    IsAutoCloseConnection = true
                });

                m_SqlSugarClient.Open();
                m_SqlSugarClient.Close();
                p_StringBuilder.Append($"<br/>{m_DBKeyValue["server"]},{m_DBKeyValue["port"]},{m_DBKeyValue["database"]} Connection OK <br/>");
            }
            catch
            {
                // p_StringBuilder.Append($"<br/><b style='color:#F00'>连接字符串测试未通过！{ex.Message}</b>  ");
            }
        }


        /// <summary>
        /// 解析 数据库连接字符串
        /// </summary>
        /// <param name="p_StrConnection"></param>
        /// <returns></returns>
        private static Dictionary<string, string> ConnectionStrKeyValue(string p_StrConnection)
        {
            Dictionary<string, string> m_DBKeyValue = new Dictionary<string, string>();
            string[] m_DBInfo = p_StrConnection.Trim().ToLower().Split(';');
            foreach (string t_Index in m_DBInfo)
            {
                if (string.IsNullOrWhiteSpace(t_Index))
                {
                    continue;
                }
                string[] m_Info = t_Index.Split('=');
                if (m_Info.Length == 0 || m_Info.Length == 1)
                {
                    continue;
                }
                if (!m_DBKeyValue.ContainsKey(m_Info[0]))
                {
                    m_DBKeyValue.Add(m_Info[0], m_Info[1]);
                }
            }
            return m_DBKeyValue;
        }


        /// <summary>
        /// 查询t_Log表信息
        /// </summary>
        /// <param name="p_StringBuilder"></param>
        private static void Check_LogCount(StringBuilder p_StringBuilder)
        {
            p_StringBuilder.Append($"<br/>Log表数量: ");

            try
            {
               // p_StringBuilder.Append($"<b style='color:#00FF5F'>{LogDal.GetLogCount()};</b>");
            }
            catch (Exception ex)
            {
                p_StringBuilder.Append($"<br/><b style='color:#F00'>查询Log表信息失败!</b>");
                p_StringBuilder.Append($"<br/><b style='color:#F00'>{ ex.ToString()}</b>");
                p_StringBuilder.Append($"<br/><b style='color:#F00'>{ ex.StackTrace}</b>");
            }
        }

       
    }
}
