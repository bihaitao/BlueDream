using BlueDream.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ApiSystem : HttpRequest
    {
        public CommonResult Login()
        {
            string m_Result = HttpHelper.Post(ApiManager.System_Login, GetParameterJson());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.ToObject<CommonResult>(m_Result);
        }

        public CommonResult GetRigth()
        {
            string m_Result = HttpHelper.Get(ApiManager.System_GetRight, GetParameterJson());

            if (string.IsNullOrWhiteSpace(m_Result))
            {
                return new CommonResult();
            }

            return JsonTools.ToObject<CommonResult>(m_Result);
        }

    }
}
