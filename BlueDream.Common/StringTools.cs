using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Drawing; 
using System.Linq;
using System.Reflection;
using System.ComponentModel;

namespace BlueDream.Common
{
    /// <summary>
    /// 字符串工具类
    /// </summary>
    public class StringTools
    {

        /// <summary>
        /// 获取不为空的字符串
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static string GetNotNullString(string? p_Value)
        {
            if (string.IsNullOrWhiteSpace(p_Value))
            {
                return string.Empty;
            }
            return p_Value;
        }
        /// <summary>
        /// 获取不为空的字符串
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static string GetNotNullString(Object? p_Value)
        {
            if (p_Value is null)
            {
                return string.Empty;
            }
            else
            {
                return p_Value.ToString();
            }

        }

        /// <summary>
        /// 获取一个新的GUID转uLong
        /// </summary>
        /// <returns></returns>
        public static long GetNewGuidLong()
        {
            return BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
        }


        /// <summary>
        /// 获取一个新的GUID转uLong(string类型)
        /// </summary>
        /// <returns></returns>
        public static string GetNewGuidLongString()
        {
            return GetNewGuidLong().ToString();
        }


        ///// <summary>
        ///// 将json串MD5加密
        ///// </summary>
        ///// <param name="p_String"></param>
        ///// <returns></returns>
        //public static string MD5Encrypt(string p_String)
        //{
        //    byte[] buffer = Encoding.Default.GetBytes(p_String); //将字符串解析成字节数组，随便按照哪种解析格式都行
        //    MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        //    byte[] hashedDataBytes = md5Hasher.ComputeHash(buffer);
        //    StringBuilder tmp = new StringBuilder();
        //    foreach (byte i in hashedDataBytes)
        //    {
        //        tmp.Append(i.ToString("x2"));
        //    }
        //    return tmp.ToString();
        //}

        public static string HexEncrypt(string p_String, System.Text.Encoding p_Encoding)
        {
            if ((p_String.Length % 2) != 0)
            {
                p_String += " "; 
            }

            byte[] m_Bytes = p_Encoding.GetBytes(p_String);

            string m_HexString = "";

            for (int i = 0; i < m_Bytes.Length; i++)
            {
                m_HexString += string.Format("{0:X}", m_Bytes[i]);
            }

            return m_HexString;
        }

        /// <summary>
        /// 读取文本文档的内容
        /// </summary>
        /// <param name="P_Path"></param>
        /// <returns></returns>
        public static string ReadTxt(string P_Path)
        {
            if (!File.Exists(P_Path))
            {
                return "";
            }
            StreamReader m_StreamReader = new StreamReader(P_Path, Encoding.Default);
            m_StreamReader.ReadToEnd();
            m_StreamReader.Close();
            //File.ReadAllLines(P_Path);
            return "";
        }


         


        /// <summary>
        /// 判断 sql 非法字符
        /// </summary>
        /// <param name="p_Sql"></param>
        /// <returns></returns>
        public static bool SqlIsNotSave(string p_Sql)
        {
            string[] m_Keys = {
                "'", ";", ",", "?", "<", ">", "(", ")", "@", "=", "+", "*", "&", "#", "%", "$","-",
                "exec","and","or",
                "script","select", "insert","delete","drop","update","truncate"
            };

            foreach (string t_Key in m_Keys)
            {
                if (p_Sql.IndexOf(t_Key, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// 根据枚举值获取对应属性
        /// </summary>
        /// <param name="p_EnumValue"></param>
        /// <returns></returns>
        public static string GetEnumDescription(object p_EnumValue)
        {
            string value = p_EnumValue.ToString();
            FieldInfo field = p_EnumValue.GetType().GetField(value);
            object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);    //获取描述属性
            if (objs == null || objs.Length == 0)    //当描述属性没有时，直接返回名称
                return value;
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
            return descriptionAttribute.Description;
        }

 

         

        /// <summary>
        ///  编码
        /// </summary>
        /// <param name="p_CodeType">utf-8 ...</param>
        /// <param name="p_Code"></param>
        /// <returns></returns>
        public static string EncodeBase64(string p_CodeType, string p_Code)
        {
            try
            {
                byte[] m_bytes = Encoding.GetEncoding(p_CodeType).GetBytes(p_Code);
                return Convert.ToBase64String(m_bytes);
            }
            catch
            {
                return p_Code;
            }
        }


        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="p_CodeType">utf-8 ...</param>
        /// <param name="p_Code"></param>
        /// <returns></returns>
        public static string DecodeBase64(string p_CodeType, string p_Code)
        {
            try
            {
                byte[] m_bytes = Convert.FromBase64String(p_Code);
                return Encoding.GetEncoding(p_CodeType).GetString(m_bytes);
            }
            catch
            {
                return p_Code;
            }
        }



    }
}
//---------------------------------------------------------------------------------------------------------------
///// <summary>
///// 解析Handle是否含有端口号
///// </summary>
///// <param name="p_HandleNode">节点地址</param>
///// <returns></returns>
//public static string GetHandNode(string p_HandleNode)
//{
//    if (p_HandleNode.LastIndexOf(":") > 0 && p_HandleNode.IndexOf(".") < p_HandleNode.LastIndexOf(":"))
//    {
//        return p_HandleNode.Substring(0, p_HandleNode.LastIndexOf(":"));
//    }
//    return p_HandleNode;
//}
