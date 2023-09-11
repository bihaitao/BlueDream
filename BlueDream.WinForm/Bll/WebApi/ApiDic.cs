using BlueDream.Common;
using BlueDream.Model; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiDic : HttpRequest
    {
        public ApiResult<List<CurrencyModel>> GetCurrencyList()
        {
            string m_Result = HttpHelper.Get(ApiManager.Dic_GetCurrencyList);

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiResult<List<CurrencyModel>>();
            }

            return JsonTools.JsonToObject<ApiResult<List<CurrencyModel>>>(m_Result);
        }

        
    }
}
