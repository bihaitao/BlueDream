using BlueDream.Enum;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BlueDream.Common
{

    /// <summary>
    /// 内部异常定义类
    /// </summary>
    public class SysExTools
    {
        //private static readonly string SysExKey = "SysEx";
        private static readonly string SysExPx = "CodeCenterEx";
        private static readonly string SysExCode = "CodeCenterEx000000";
        //private static readonly string SysLogCode = "CodeCenterEx060000";


        /// <summary>
        /// 读取要忽略的异常编码信息
        /// </summary>
        /// <param name="p_ExCode"></param>
        /// <returns></returns>
        public static bool IsLogIgronCode(string p_ExCode)
        {
            if (string.IsNullOrWhiteSpace(p_ExCode))
            {
                return true;
            }
            return CfgManager.Instance.LogIgronCode.Split(',').ToList().Contains(p_ExCode);
        }


        /// <summary>
        /// [000001] 数据库连接失败
        /// </summary>
        public static void Throw_DbOpenEX(string p_Message, string p_ExKey)
        {
            throw GetExModel("000001", "数据库连接失败!", p_Message, p_ExKey, ExLevelEnum.High);
        }


        /// <summary>
        /// [000002]
        /// </summary>
        /// <param name="p_Count"></param>
        /// <param name="p_Title"></param>
        /// <param name="p_ExKey"></param>
        /// <param name="p_Message"></param>

        public static void Throw_DataBase_ZeroRowEx(int p_Count, string p_Title, string p_ExKey, string p_Message = "操作数据库时影响行数为零！")
        {
            if (p_Count <= 0)
            {
                throw GetExModel("000002", p_Title, p_Message, p_ExKey, ExLevelEnum.Low);
            }
        }


        /// <summary>
        /// [000003] 登出
        /// </summary>
        public static void Throw_LoginEx(string p_Title, string p_Message, string p_ExKey = "")//string p_Message = "权限验证失败"
        {
            throw GetExModel("000003", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000004] 获取配置异常
        /// </summary>
        public static void Throw_ECodeRegEx(string p_Title, string p_Message, string p_ExKey = "")//编码中心注册失败
        {
            throw GetExModel("000004", p_Title, p_Message, p_ExKey, ExLevelEnum.High);
        }


        /// <summary>
        /// [000005] 获取配置异常
        /// </summary>
        public static void Throw_ConfigEx(string p_Title, string p_Message, string p_ExKey = "")//配置信息获取异常！
        {
            throw GetExModel("000005", p_Title, p_Message, p_ExKey, ExLevelEnum.High);
        }


        /// <summary>
        /// [000006] 检查数据异常
        /// </summary>
        public static void Throw_CheckDateEx(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000006", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000007] 抛出一般错误
        /// </summary>
        public static void Throw_NormalEx(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000007", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000008] 消息队列异常
        /// </summary>
        public static void Throw_MQ_Ex(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000008", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000009] 申请物联码异常
        /// </summary>
        public static void Throw_ReqCode(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000009", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000019] 同步打码信息异常
        /// </summary>
        /// <param name="p_ExMessage"></param>
        public static void Throw_PrintCodeEx(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000019", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000020] 提示（但不是异常）
        /// </summary>
        public static void Throw_Info(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000020", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000021]下载编码数据
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_CheckDownLoad(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000021", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000022]
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_ClientEx(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000022", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000023] 
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_ParamsEx(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000023", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000024]校验编码信息中是否存在Sql中的非法字符
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_SqlFilter(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000024", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000025] 编码/图片 回传失败
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_HandleReturnError(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000025", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// [000026] 读取图片Hash值
        /// </summary>
        /// <param name="p_Title"></param>
        /// <param name="p_Message"></param>
        /// <param name="p_ExKey"></param>
        public static void Throw_GetImageHash(string p_Title, string p_Message, string p_ExKey = "")
        {
            throw GetExModel("000026", p_Title, p_Message, p_ExKey, ExLevelEnum.Medium);
        }


        /// <summary>
        /// 附加异常处理执行
        /// </summary>
        /// <param name="p_CommonResult"></param>
        /// <param name="p_Action"></param>
        public static void TryExec(CommonResult p_CommonResult, Action p_Action)
        {
            try
            {
                //执行代码
                p_Action();

                //不抛异常默认为成功
                p_CommonResult.Success = true;

                if (string.IsNullOrWhiteSpace(p_CommonResult.Message))
                {
                    p_CommonResult.Message = "执行成功！";
                }
            }
            catch (SysEx m_SysEx)
            {
                p_CommonResult.Success = false;
                p_CommonResult.Message = m_SysEx.ExTitle;
                p_CommonResult.ExMessage = m_SysEx.ExMessage;
                p_CommonResult.ExCode = m_SysEx.ExFullCode;
                LogHelper.WriteLog(m_SysEx);
            }
            catch (Exception m_Exception)
            {
                p_CommonResult.Success = false;
                p_CommonResult.Message = "未知错误！";
                p_CommonResult.ExMessage = JsonTools.GetJson(m_Exception);
                p_CommonResult.ExCode = SysExCode;
                LogHelper.WriteLog(m_Exception);
            }
            finally
            {
            }
        }


        /// <summary>
        /// 获取当前堆栈信息
        /// </summary>
        /// <returns></returns>
        public static string GetStackTraceString()
        {
            StackTrace m_StackTrace = new StackTrace(true);
            StringBuilder m_StringBuilder = new StringBuilder();

            foreach (StackFrame t_StackFrame in m_StackTrace.GetFrames())
            {
                try
                {
                    string t_FileName = StringTools.GetNotNullString(t_StackFrame.GetFileName());
                    if (string.IsNullOrWhiteSpace(t_FileName))
                    {
                        continue;
                    }
                    m_StringBuilder.AppendLine($"FileName:{t_FileName}");

                    m_StringBuilder.AppendLine($"DeclaringType.Module.FullyQualifiedName:{t_StackFrame.GetMethod().DeclaringType.Module.FullyQualifiedName}");
                    m_StringBuilder.AppendLine($"DeclaringType.FullName:{t_StackFrame.GetMethod().DeclaringType.FullName}");
                    m_StringBuilder.AppendLine($"Method:{t_StackFrame.GetMethod().Name}");


                    m_StringBuilder.AppendLine($"Line:{t_StackFrame.GetFileLineNumber()},Column:{t_StackFrame.GetFileColumnNumber()}");
                }
                catch
                {
                    m_StringBuilder.AppendLine("获取堆栈失败");
                }

                m_StringBuilder.AppendLine();
            }

            return m_StringBuilder.ToString();
        }


        /// <summary>
        /// 构建异常对象
        /// </summary>
        /// <param name="p_ExCode">编码号</param>
        /// <param name="p_Title">标题</param>
        /// <param name="p_Message">信息</param>
        /// <param name="p_ExKey">异常key</param>
        /// <param name="p_ExLevelEnum">异常等级</param>
        /// <returns></returns>
        private static Exception GetExModel(string p_ExCode, string p_Title, string p_Message, string p_ExKey, ExLevelEnum p_ExLevelEnum)
        {
            SysEx m_SysEx = new SysEx
            {
                ExPx = SysExPx,
                ExCode = p_ExCode,
                ExTitle = p_Title,
                ExMessage = p_Message,
                ExKey = p_ExKey,
                StackTraceInfo = GetStackTraceString(),
                Level = p_ExLevelEnum
            };
            return m_SysEx;
        }
    }
}
//----------------------------------------------------------------------------------------------------------------------------
//public static CommonResult GetCommonResultByEx(Exception p_Exception)
//{
//    CommonResult m_CommonResult = null;

//    try
//    {
//        if (p_Exception.Message.Length >= 13 + SysExPx.Length)
//        {
//            string m_ExMessage = p_Exception.Message;

//            string m_SysExKey = m_ExMessage.Substring(0, 5);
//            if (m_SysExKey == SysExKey)
//            {
//                m_CommonResult = new CommonResult();
//                m_CommonResult.Success = false;
//                m_CommonResult.Message = m_ExMessage.Substring(13 + SysExPx.Length, m_ExMessage.Length - 13 - SysExPx.Length);
//                m_CommonResult.ExMessage = JsonTools.GetJson(p_Exception);
//                m_CommonResult.ExCode = m_ExMessage.Substring(6, SysExPx.Length + 6);
//            }

//        }

//        if (m_CommonResult == null)
//        {
//            m_CommonResult = new CommonResult();
//            m_CommonResult.Success = false;
//            m_CommonResult.Message = "系统错误！";// + p_Exception.Message;
//            m_CommonResult.ExMessage = JsonTools.GetJson(p_Exception);
//            m_CommonResult.ExCode = SysExCode;

//        }


//    }
//    catch (Exception ex)
//    {
//        m_CommonResult = new CommonResult();
//        m_CommonResult.Success = false;
//        m_CommonResult.Message = "系统错误，构建异常信息失败！";// + ex.Message;
//        m_CommonResult.ExMessage = JsonTools.GetJson(ex);
//        m_CommonResult.ExCode = SysExCode;

//    }

//    //LogHelper.WriteSysExceptionLog(JsonTools.GetJson(m_CommonResult));
//    return m_CommonResult;
//}




