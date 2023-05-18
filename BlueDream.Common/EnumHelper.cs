using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BlueDream.Common
{
    /// <summary>
    /// EnumHelper枚举帮助类
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 全局静态唯一
        /// </summary>
        private static string m_EnumJsString = string.Empty;
        /// <summary>
        /// 枚举命名空间
        /// </summary>
        private const string c_EnumSpaceName = "BlueDream.Enum";


        /// <summary>
        /// 只生成一次
        /// </summary>
        static EnumHelper()
        {
            StringBuilder m_StringBuilder = new StringBuilder();

            //获取所有枚举Type
            Type[] m_Types = Assembly.Load(new AssemblyName(c_EnumSpaceName)).GetTypes();

            //循环生成
            foreach (Type t_Type in m_Types)
            {
                //枚举的名称（例：布尔枚举）
                string t_ClassDesc = GetDesc(t_Type);

                //将枚举名称添加到js对象
                m_StringBuilder.Append($" var {t_Type.Name} = {{ Desc:'{t_ClassDesc}', ");

                //循环枚举项
                foreach (var t_Value in System.Enum.GetValues(t_Type))
                {
                    string t_Name = System.Enum.GetName(t_Type, t_Value);

                    string m_Desc = GetDesc(t_Type, t_Name);
                    m_StringBuilder.Append($" {t_Name}: {{ Value: {Convert.ToInt32(t_Value)}, Desc: '{m_Desc}' }},");
                }

                m_StringBuilder.Append("}; ");
            }

            m_EnumJsString = m_StringBuilder.ToString();
        }


        /// <summary>
        /// 枚举JS文本
        /// </summary>
        /// <returns></returns>
        public static string JsText
        {
            get
            {
                return m_EnumJsString;
            }
        }


        /// <summary>
        /// 读取属性
        /// </summary>
        /// <param name="p_Type"></param>
        /// <returns></returns>
        private static string GetDesc(Type p_Type)
        {
            object? m_Value = IntrospectionExtensions.GetTypeInfo(p_Type).CustomAttributes.First().ConstructorArguments[0].Value;
            return StringTools.GetNotNullString(m_Value);
        }


        /// <summary>
        /// 读取属性
        /// </summary>
        /// <param name="p_Type">类型</param>
        /// <param name="p_Name">名字</param>
        /// <returns></returns>
        private static string GetDesc(Type p_Type, string p_Name)
        {
            IEnumerable<CustomAttributeData> m_ClassDescriptions = IntrospectionExtensions.GetTypeInfo(p_Type).GetField(p_Name).CustomAttributes;

            if (m_ClassDescriptions == null || m_ClassDescriptions.Count() == 0)
            {
                return string.Empty;
            }
            else
            {
                return m_ClassDescriptions.First().ConstructorArguments[0].Value.ToString();
            }
        }
    }
}
