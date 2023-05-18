using BlueDream.Enum;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlueDream.Common
{
    /// <summary>
    /// 写文件日志类
    /// </summary>
    public class LogHelper
    {

        public LogHelper()
        {
            LogQueue = new Queue<string>();
        }

        private const string c_Exception = "Exception";


        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="p_LogTxt"></param>
        public static void WriteLog(Exception p_Exception)
        {
            try
            {
                Write(p_Exception);
            }
            catch
            {
            }
        }


        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="p_LogTxt"></param>
        public static void Write(Exception p_Exception)
        {
            LogEntity m_LogEntity = new LogEntity
            {
                CreateTime = DateTime.Now,
                LogID = StringTools.GetNewGuidLong()
            };
            if (p_Exception.GetType() == typeof(SysEx))
            {
                SysEx m_SysEx = (SysEx)p_Exception;
                m_LogEntity.ExCode = m_SysEx.ExFullCode;
                m_LogEntity.ExKey = m_SysEx.ExKey;
                m_LogEntity.Title = m_SysEx.ExTitle;
                m_LogEntity.LogTxt = m_SysEx.ExMessage;
                m_LogEntity.StackTrace = m_SysEx.StackTraceInfo;
                m_LogEntity.Level = m_SysEx.Level;
                m_LogEntity.SysName = "";

                ExAlarmTools.Alarm(m_SysEx);
            }
            else
            {
                m_LogEntity.ExCode = SysExTools.SysExCode;
                m_LogEntity.StackTrace = SysExTools.GetStackTraceString();
                m_LogEntity.LogTxt = JsonTools.GetJson(p_Exception);
                m_LogEntity.Title = p_Exception.Message;
                m_LogEntity.Level = ExLevelEnum.Medium;
                m_LogEntity.ExKey = "";
                m_LogEntity.SysName = "";
            }

            WriteLog(m_LogEntity);
        }


        /// <summary>
        /// Exception
        /// </summary>
        /// <returns></returns>
        public static string GetSysExlog()
        {
            return Getlog(SysExTools.SysExKey);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetExlog()
        {
            return Getlog(c_Exception);
        }


        /// <summary>
        /// Exception
        /// </summary>
        /// <returns></returns>
        private static string Getlog(string p_ExName)
        {
            //Log全路径
            string m_LogFilePath = $"{System.IO.Directory.GetCurrentDirectory()}\\Log\\{p_ExName}\\{DateTime.Now.ToString("yyyyMMdd")}.txt";
            if (File.Exists(m_LogFilePath))
            {
                string[] m_AllLines = File.ReadAllLines(m_LogFilePath);
                StringBuilder m_StringBuilder = new StringBuilder();
                foreach (string t_Line in m_AllLines)
                {
                    m_StringBuilder.Append($"<br/>{t_Line}");
                }
                return m_StringBuilder.ToString();
            }
            return "NoLog";
        }


        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="p_LogTxt"></param>
        public  static void WriteLog(LogEntity p_LogEntity)
        {
            if (LogQueue != null)
            {
                while (LogQueue.Count > 1000)
                {
                    LogQueue.Dequeue();
                }
                LogQueue.Enqueue($"{p_LogEntity.Title} \r\r {p_LogEntity.LogTxt} \r\r");
            }


            ////是否写入数据库
            //if (!CfgManager.IsWriteLogToDB)
            //{
            //    return;
            //}


            //是否忽略指定的记录信息
            if (SysExTools.IsLogIgronCode(p_LogEntity.ExCode))
            {
                return;
            }


            //SqlSugarClient m_SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
            //{
            //    ConnectionString = CfgManager.LogConnection,
            //    DbType = CfgManager.DataBaseType,
            //    IsAutoCloseConnection = true
            //});

            //m_SqlSugarClient.Insertable<LogEntity>(p_LogEntity).ExecuteCommand();
        }


        /// <summary>
        /// 临时方法 
        /// </summary>
        /// <param name="p_LogTxt"></param>
        public static void WriteLog_Temp(string p_Title, string p_LogObject)
        {
            try
            {

                if (LogQueue != null)
                {
                    while (LogQueue.Count > 1000)
                    {
                        LogQueue.Dequeue();
                    }
                    LogQueue.Enqueue($"{p_Title} \r\r {p_LogObject} \r\r");
                }
                else
                {
                    LogQueue = new Queue<string>();
                    LogQueue.Enqueue($"{p_Title} \r\r {p_LogObject} \r\r");
                }
                LogEntity m_LogEntity = new LogEntity
                {
                    LogID = StringTools.GetNewGuidLong(),
                    ExCode = SysExTools.SysLogCode,
                    ExKey = "",
                    Title = p_Title,
                    LogTxt = p_LogObject,
                    StackTrace = SysExTools.GetStackTraceString(),
                    Level = ExLevelEnum.Ignore,
                    SysName = "",
                    CreateTime = DateTime.Now
                };
                WriteLog(m_LogEntity);
            }
            catch
            {

            }
        }


        public static Queue<string> LogQueue { set; get; }
    }
}

//---------------------------------------------------------------------------------------------------------------------

#region 写到文本文档中
///// <summary>
///// 写入日志
///// </summary>
///// <param name="p_LogTxt"></param>
//private static void WriteLog(string p_Title, string p_Context)
//{
//    StreamWriter m_StreamWriter = null;
//    try
//    {

//      // if(CfgManager.)


//        //日志路径
//        string m_LogPath = System.IO.Directory.GetCurrentDirectory() + "/Log/" + p_Title;
//        //如果文件夹不存在则创建
//        DirectoryInfo m_LogDirectoryInfo = new DirectoryInfo(m_LogPath);
//        if (!m_LogDirectoryInfo.Exists)
//        {
//            m_LogDirectoryInfo.Create();
//        }
//        //Log全路径
//        string LogFilePath = m_LogPath + "/" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
//        //创建流
//        m_StreamWriter = File.AppendText(LogFilePath);
//        //写入
//        m_StreamWriter.WriteLine("--------------------------------------------------------------------------------------------------------");
//        m_StreamWriter.WriteLine(DateTime.Now.ToString() + "  " + p_Title);
//        m_StreamWriter.WriteLine(p_Context);
//        m_StreamWriter.WriteLine("========================================================================================================");
//        m_StreamWriter.WriteLine();
//        m_StreamWriter.Flush();
//        m_StreamWriter.Dispose();

//        if (LogQueue != null)
//        {
//            if (LogQueue.Count > 1000)
//            {
//                LogQueue.Dequeue();
//            }
//            LogQueue.Enqueue($"{p_Title} \r\r {p_Context} \r\r");
//        }

//    }
//    catch (Exception ex)
//    {
//        try
//        {
//            if (m_StreamWriter != null)
//            {
//                m_StreamWriter.Flush();
//                m_StreamWriter.Dispose();
//            }
//        }
//        catch (Exception ex2)
//        {
//            //不做任何处理
//        }
//    }
//}
#endregion

///// <summary>
///// 记录操作信息,写入表中
///// </summary>
///// <param name="p_Title"></param>
///// <param name="p_Context"></param>
//public static void WriteLog(string p_Title, string p_Context)
//{
//    //记录操作信息
//    WriteLog(p_Title, p_Context, SysExTools.SysLogCode);
//}



///// <summary>
///// 写入日志
///// </summary>
///// <param name="p_LogTxt"></param>
//public static void WriteLog(CommonResult p_CommonResult)
//{
//    WriteLog(p_CommonResult.Message, JsonTools.GetJson(p_CommonResult), p_CommonResult.ExCode);
//}

///// <summary>
///// 写入日志
///// </summary>
///// <param name="p_LogTxt"></param>
//private static void WriteLog(string p_Title, string p_Context,string p_ExCode)
//{
//    try
//    {
//        if (LogQueue != null)
//        {
//            if (LogQueue.Count > 1000)
//            {
//                LogQueue.Dequeue();
//            }
//            LogQueue.Enqueue($"{p_Title} \r\r {p_Context} \r\r");
//        }

//        //是否写入数据库
//        if (!CfgManager.IsWriteLogToDB)
//        {
//            return;
//        }

//        //忽略掉不需要记录日志的异常
//        if(SysExTools.IsLogIgronCode(p_ExCode))
//        {
//            return;
//        }

//        SqlSugarClient m_SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
//        {
//            ConnectionString = CfgManager.LogConnection,
//            DbType = CfgManager.DataBaseType,
//            IsAutoCloseConnection = true
//        });

//        LogEntity m_LogEntity = new LogEntity();

//        m_LogEntity.LogID = StringTools.GetNewGuidLong();
//        m_LogEntity.Title = p_Title;
//        m_LogEntity.SysName = "";
//        m_LogEntity.ExCode = p_ExCode;
//        m_LogEntity.CreateTime = DateTime.Now;
//        m_LogEntity.LogTxt = p_Context;

//        m_SqlSugarClient.Insertable<LogEntity>(m_LogEntity).ExecuteCommand();

//    }
//    catch 
//    { 

//    }
//}


