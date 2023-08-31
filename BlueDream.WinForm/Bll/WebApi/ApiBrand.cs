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
        public ApiPageResult<List<BrandEntity>> GetBrandTop10()
        {
            string m_Result = HttpHelper.Get(ApiManager.Brand_GetTop10, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<BrandEntity>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<BrandEntity>>>(m_Result);
        }
    }
}
