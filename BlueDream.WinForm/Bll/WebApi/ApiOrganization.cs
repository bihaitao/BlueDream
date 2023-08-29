using BlueDream.Common;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiOrganization : HttpRequest
    {
        public ApiResult<List<OrganizationEntity>> GetOrganization()
        {
            string m_Result = HttpHelper.Get(ApiManager.Organization_GetOrganization, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiResult<List<OrganizationEntity>>();
            }

            return JsonTools.JsonToObject<ApiResult<List<OrganizationEntity>>>(m_Result);
        }
    }
}
