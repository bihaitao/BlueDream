using System.Collections.Generic;

namespace BlueDream.Common
{
    /// <summary>
    /// 校验参数工具类
    /// </summary>
    public class CheckInfoTool
    {
        /// <summary>
        /// 校验数据是否为空
        /// </summary>
        /// <param name="p_Value">判断的值</param>
        /// <param name="p_Message">提示信息</param>
        public static void Check_IsNullOrWhiteSpace(string p_Value, string p_Message)
        {
            if (string.IsNullOrWhiteSpace(p_Value))
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message);
            }
        }


        /// <summary>
        /// 校验数据为空
        /// </summary>
        /// <param name="p_Value">判断的值</param>
        /// <param name="p_Message">提示信息</param>
        /// <param name="p_Key">涉及到的唯一Key</param>
        public static void Check_IsNullOrWhiteSpace(string p_Value, string p_Message, string p_Key)
        {
            if (string.IsNullOrWhiteSpace(p_Value))
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message, p_Key);
            }
        }


        /// <summary>
        /// 校验参数对象是否为空
        /// </summary>
        /// <param name="p_Value">判断的值</param>
        /// <param name="p_Message">提示信息</param>
        /// <param name="p_Key">涉及到的唯一Key</param>
        public static void Check_IsNullOrWhiteSpace(object p_Value, string p_Message="", string p_Key = "")
        {
            if (p_Value == null)
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message, p_Key);
            }
        }

        /// <summary>
        /// 校验List对象数量是否为0
        /// </summary>
        /// <param name="p_Value">判断的值</param>
        /// <param name="p_Message">提示信息</param>
        /// <param name="p_Key">涉及到的唯一Key</param>
        public static void Check_ArrayIsNull(object[] p_Value, string p_Message = "", string p_Key = "")
        {
            if (p_Value == null|| p_Value.Length<=0)
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message, p_Key);
            }
        }



        /// <summary>
        /// 校验参数对象是否为空
        /// </summary>
        /// <param name="p_Value">判断的值</param>
        /// <param name="p_Title">错误信息标题</param>
        /// <param name="p_Message">提示信息</param>
        /// <param name="p_Key">涉及到的唯一Key</param>
        public static void Check_IsNullOrWhiteSpace(object p_Value, string p_Title, string p_Message , string p_Key = "")
        {
            if (p_Value == null)
            {
                SysExTools.Throw_CheckDateEx(p_Title, p_Message, p_Key);
            }
        }
        /// <summary>
        /// 根据参数值为True时抛出相应的数据异常信息
        /// </summary>
        /// <param name="p_Result">结果值</param>
        /// <param name="p_Message">提示的错误信息</param>
        public static void Check(bool p_Result, string p_Message)
        {
            if (p_Result)
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message);
            }
        }

        /// <summary>
        /// 根据参数值为0时，抛出相应的数据异常信息
        /// </summary>
        /// <param name="p_Result"></param>
        /// <param name="p_Message"></param>
        public static void Check(int p_Result, string p_Message)
        {
            if (p_Result==0)
            {
                SysExTools.Throw_CheckDateEx(p_Message, p_Message);
            }
        }
    }
}
