using BlueDream.Common;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiOrder : HttpRequest
    {
        public ApiPageResult<List<OrderModel>> GetListModelByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.Order_GetListModelByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<OrderModel>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<OrderModel>>>(m_Result);
        }
    }
}
