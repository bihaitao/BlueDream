using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlueDream.Common
{
    /// <summary>
    /// 获取枚举描述
    /// </summary>
    public static class EnumDescriptionHelper
    {
        /// <summary>
        /// 返回枚举项的描述信息。
        /// </summary>
        /// <param name="value">要获取描述信息的枚举项。</param>
        /// <returns>枚举想的描述信息。</returns>
        public static string GetDescription(this System.Enum p_EnumValue)
        {
            string p_Value = p_EnumValue.ToString();
            System.Reflection.FieldInfo m_FieldInfo = p_EnumValue.GetType().GetField(p_Value);
            object[] m_Object = m_FieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);    //获取描述属性
            if (m_Object.Length == 0)    //当描述属性没有时，直接返回名称
            {
                return p_Value;
            }
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)m_Object[0];
            return descriptionAttribute.Description;
        }
    }
}
