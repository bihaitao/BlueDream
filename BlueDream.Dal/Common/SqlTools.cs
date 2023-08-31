using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class SqlTools
    {
        StringBuilder m_StringBuilder = null;


        public SqlTools() {
            m_StringBuilder = new StringBuilder();
        }
         

        public void Append(string p_Sql)
        {
            m_StringBuilder.Append(p_Sql);
        }

        public void AppendLine(string p_Sql)
        {
            m_StringBuilder.AppendLine(p_Sql);
        }

        public void Append(string p_Sql,bool p_Bool)
        {
            if(p_Bool)
            {
                m_StringBuilder.AppendLine(p_Sql);
            } 
        }

        public void AppendLine(string p_Sql, bool p_Bool)
        {
            if (p_Bool)
            {
                m_StringBuilder.AppendLine(p_Sql);
            }
        }

        public string SqlString
        {
            get
            {
                return m_StringBuilder.ToString();
            }
        }
    }
}
