using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BlueDream.Common 
{
    /// <summary>
    /// 十六进制与Ascll码转换
    /// </summary>
    public class HexTools
    {
        /// <summary>
        /// String转HexArrayString  "AD/FDAS+"=>"123ASFB"
        /// </summary>
        /// <param name="p_Input"></param>
        /// <returns></returns>
        public static string AscllToHex(string p_Input)
        {
            char[] m_CharArray = p_Input.ToCharArray();
            StringBuilder m_Result = new StringBuilder();

            foreach (char t_Char in m_CharArray)
            {
                int m_CharValue = Convert.ToInt32(t_Char);
                m_Result.Append(Convert.ToString(m_CharValue, 16).PadLeft(2, '0'));
            }

            return m_Result.ToString().ToUpper();
        }

        /// <summary>
        /// 将一条十六进制字符串转换为ASCII
        /// </summary>
        /// <param name="p_HexString">一条十六进制字符串</param>
        /// <returns>返回一条ASCII码</returns>
        public static string HexToAscll(string p_HexString)
        {
            StringReader m_StringReader = new StringReader(p_HexString);
            List<char> m_Result = new List<char>();
            char[] m_HexChar = new char[2];

            while (m_StringReader.Read(m_HexChar, 0,2) > 0)
            {
                string t_Temp = Convert.ToString(m_HexChar[0]) + Convert.ToString(m_HexChar[1]);
                m_Result.Add(Convert.ToChar(Convert.ToByte(t_Temp, 16)));
            }

            return new string(m_Result.ToArray());
        }
    }
}
