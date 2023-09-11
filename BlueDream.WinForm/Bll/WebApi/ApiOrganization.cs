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
        public CommonResult GetOrganizationByID()
        {
            string m_Result = HttpHelper.Get(ApiManager.Organization_GetOrganizationByID, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.JsonToObject<CommonResult>(m_Result);
        }

       

        public ApiPageResult<List<OrganizationEntity>> GetOrganizationListByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.Organization_GetOrganizationListByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<OrganizationEntity>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<OrganizationEntity>>>(m_Result);
        }

        
    }
}
