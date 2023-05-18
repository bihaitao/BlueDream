using BlueDream.Bll;
using BlueDream.Model;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 添加SwagerHeader参数
    /// </summary>
    public class AddHeaderFilter : IOperationFilter
    {

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }

            LoginUserModel p_LoginUserModel = new LoginUserModel();
            p_LoginUserModel.UserID = 999;
            p_LoginUserModel.UserNickName = "Debug";
            p_LoginUserModel.LoginOutTime = DateTime.Now.AddDays(1);

            //添加默认登录验证参数
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "LoginKey",
                In = ParameterLocation.Header,
                Description = "登录验证",
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                    Default = new OpenApiString(UserBll.GenEnCodeString(p_LoginUserModel))
                }
            });
        }
    }
}
