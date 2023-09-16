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
        public CommonResult GetUserByID()
        {
            string m_Result = HttpHelper.Get(ApiManager.User_GetUserByID, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.ToObject<CommonResult>(m_Result);
        }

        public ApiPageResult<List<UserEntity>> GetUserListByPage()
        {
            string m_Result = HttpHelper.Get(ApiManager.User_GetUserListByPage, GetParameterUrl());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new ApiPageResult<List<UserEntity>>();
            }

            return JsonTools.ToObject<ApiPageResult<List<UserEntity>>>(m_Result);
        }

       
    }
}
