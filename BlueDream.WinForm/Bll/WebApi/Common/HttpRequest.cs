using BlueDream.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    /// <summary>
    /// 抽象类，不单独使用，需要用Api类继承之后在内部调用
    /// </summary>
    public abstract class HttpRequest
    {
        public Dictionary<string, object> Parameters { set; get; }

         
        public HttpRequest() {
            Parameters = new Dictionary<string, object>();
        }

        protected string GetParameterJson()
        {
            if(Parameters is null || Parameters.Count==0)
            {
                return "";
            }

            DynamicParameter m_DynamicParameter =  new DynamicParameter(Parameters);
            return JsonTools.GetJson(m_DynamicParameter);
        } 

        protected string GetParameterUrl()
        {
            List<string> m_Parameters = new List<string>();
             
            foreach(var t_Parameter in Parameters)
            {
                m_Parameters.Add($@"{t_Parameter.Key}={t_Parameter.Value}" );
            }

            return string.Join("&", m_Parameters);
        }
    }
}
