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

        public CommonResult GetOrderByID()
        {
            string m_Result = HttpHelper.Get(ApiManager.Order_GetOrderByID, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.JsonToObject<CommonResult>(m_Result);
        }



        public ApiPageResult<List<OrderModel>> GetOrderListByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.Order_GetOrderListByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<OrderModel>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<OrderModel>>>(m_Result);
        }
       
      
    }
}
