using BlueDream.Common;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiUser : HttpRequest
    {
        public ApiPageResult<List<UserEntity>> GetUserTop10()
        {
            string m_Result = HttpHelper.Get(ApiManager.User_GetTop10, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<UserEntity>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<UserEntity>>>(m_Result);
        }

        public ApiPageResult<List<UserEntity>> GetListModelByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.User_GetListModelByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<UserEntity>>();
            }

            return JsonTools.JsonToObject<ApiPageResult<List<UserEntity>>>(m_Result);
        }
    }
}
