using BlueDream.Common;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiBrand : HttpRequest
    {
        public CommonResult GetBrandByID()
        {
            string m_Result = HttpHelper.Get(ApiManager.Brand_GetBrandByID, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.JsonToObject<CommonResult>(m_Result);
        }

        public ApiPageResult<List<BrandEntity>> GetBrandListByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.Brand_GetBrandListByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<BrandEntity>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<BrandEntity>>>(m_Result);
        }

    
    }
}
