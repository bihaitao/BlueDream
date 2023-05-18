using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDream.WebApi
{
    /// <summary>
    /// ModelBinder 类
    /// 用来解析前段参数
    /// </summary>
    public class MyModelBinder : IModelBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_BindingContext"></param>
        /// <returns></returns>
        public Task BindModelAsync(ModelBindingContext p_BindingContext)
        {
            string p_Key = p_BindingContext.ModelName;

            if (String.IsNullOrWhiteSpace(p_Key))
            {
                p_Key = p_BindingContext.FieldName;
            }

            //去掉后缀
            if (p_Key != null && p_Key.Length > 2 && p_Key.Substring(0, 2).ToLower() == "p_")
            {
                p_Key = p_Key.Substring(2, p_Key.Length - 2);
            }

            string m_Value = null;

            try
            {
                m_Value = p_BindingContext.HttpContext.Request.Form[p_Key];
            }
            catch
            {

            }

            if (String.IsNullOrWhiteSpace(m_Value))
            {
                try
                {
                    m_Value = p_BindingContext.HttpContext.Request.Query[p_Key];
                    if(string.IsNullOrWhiteSpace(m_Value)) {
                        m_Value = p_BindingContext.HttpContext.Request.Query[$"p_{p_Key}"];
                    }
                }
                catch
                {

                }
            }


            if (String.IsNullOrWhiteSpace(m_Value))
            {
                p_BindingContext.Result = ModelBindingResult.Failed();
                return Task.CompletedTask;
            }

            if (p_BindingContext.ModelType == typeof(string))
            {
                p_BindingContext.Model = m_Value;
            }

            if (p_BindingContext.ModelType == typeof(int))
            {
                p_BindingContext.Model = int.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(long))
            {
                p_BindingContext.Model = long.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(float))
            {
                p_BindingContext.Model = float.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(double))
            {
                p_BindingContext.Model = double.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(short))
            {
                p_BindingContext.Model = short.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(DateTime))
            {
                p_BindingContext.Model = DateTime.Parse(m_Value);
            }

            if (p_BindingContext.ModelType == typeof(DateTime?))
            {
                p_BindingContext.Model = DateTime.Parse(m_Value);
            }

            if (p_BindingContext.Model != null)
            {
                p_BindingContext.Result = ModelBindingResult.Success(p_BindingContext.Model);
            }

            if (p_BindingContext.ModelType == typeof(IFormFile))
            {
                p_BindingContext.Model = p_BindingContext.HttpContext.Request.Form.Files[0];
            }

            if (p_BindingContext.ModelType.BaseType.Name == "Enum")
            {
                p_BindingContext.Model = System.Enum.Parse(p_BindingContext.ModelType.UnderlyingSystemType, m_Value);
            }

            p_BindingContext.Result = ModelBindingResult.Success(p_BindingContext.Model);

            return Task.CompletedTask;

        }
    }
}
