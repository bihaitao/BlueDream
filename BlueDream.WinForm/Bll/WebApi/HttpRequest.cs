using BlueDream.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class HttpRequest
    {
        public Dictionary<string, object> Parameters { set; get; }

         
        public HttpRequest() {
            Parameters = new Dictionary<string, object>();
        }

        private string GetParameterJson()
        {
            DynamicParameter m_DynamicParameter =  new DynamicParameter(Parameters);
            return JsonTools.GetJson(m_DynamicParameter);
        }

        public CommonResult Login()
        { 
            string m_Result = HttpHelper.Post(ApiManager.System_Login, GetParameterJson());

            if(string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.JsonToObject<CommonResult>(m_Result);
        }

        



    }
}
