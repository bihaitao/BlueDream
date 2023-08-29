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
        public ApiResult<List<OrderEntity>> GetListByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.Order_GetListByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiResult<List<OrderEntity>>();
            }

            return JsonTools.JsonToObject<ApiResult<List<OrderEntity>>>(m_Result);
        }
    }
}
