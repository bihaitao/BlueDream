using System;

namespace BlueDream.Common
{
    /// <summary>
    /// 时间工具
    /// </summary>
    public class DateTimeTools
    {

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        public const string yyyy_MM_dd_HH_mm_ss = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// yyyy-MM-dd
        /// </summary>
        public const string yyyy_MM_dd = "yyyy-MM-dd";

        /// <summary>
        /// HH:mm:ss
        /// </summary>
        public const string HH_mm_ss = "HH:mm:ss";


        /// <summary>
        /// 用于实体字段，防止DateTime字段为null 或者时间过小 例如“0001-01-01 00：00：00”
        /// </summary>
        /// <param name="p_DateTime"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(DateTime p_DateTime)
        {
            DateTime m_MiniDateTime = Convert.ToDateTime("1901-01-01 00:00:00");

            if (p_DateTime < m_MiniDateTime)
            {
                return m_MiniDateTime;
            }
            else
            {
                return p_DateTime;
            }
        }


        /// <summary>
        /// 获取时间间隔 1天以前/1小时以前/1分钟以前/1秒钟以前
        /// </summary>
        /// <param name="p_DateTime"></param>
        /// <returns></returns>
        public static string GetDateStringByTimeSpan(DateTime p_DateTime)
        {
            //计算与当前时间差
            TimeSpan m_TimeSpan = DateTime.Now - p_DateTime;

            if (m_TimeSpan.Days > 6)
            {
                return p_DateTime.ToString(yyyy_MM_dd);
            }

            if (m_TimeSpan.Days > 0)
            {
                return m_TimeSpan.Days.ToString() + "天前";
            }

            if (m_TimeSpan.Hours > 0)
            {
                return m_TimeSpan.Hours.ToString() + "小时前";
            }

            if (m_TimeSpan.Minutes > 0)
            {
                return m_TimeSpan.Minutes.ToString() + "分钟前";
            }

            if (m_TimeSpan.Seconds > 5)
            {
                return m_TimeSpan.Seconds.ToString() + "秒前";
            }

            if (m_TimeSpan.Seconds > 0)
            {
                return "刚刚";
            }

            return string.Empty;
        }


        /// <summary>
        /// 将一个字符串转换成日期
        /// </summary>
        /// <param name="p_Value">字符串，格式(yyyyMMdd)</param>
        public static DateTime ConvertStringToDateTime(string p_Value)
        {
            DateTime m_DateTime = DateTime.Parse(p_Value.Substring(0, 4) + "-" + p_Value.Substring(4, 2) + "-" + p_Value.Substring(6, 2));

            return m_DateTime;
        }
    }
}
