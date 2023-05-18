using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;

namespace BlueDream.WebApi
{
    /// <summary>
    /// ModelBinderProvider类
    /// </summary>
    public class MyModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_ModelBinderProviderContext"></param>
        /// <returns></returns>
        public IModelBinder GetBinder(ModelBinderProviderContext p_ModelBinderProviderContext)
        {
            if (p_ModelBinderProviderContext == null)
            {
                throw new ArgumentNullException(nameof(p_ModelBinderProviderContext));
            }

            if (p_ModelBinderProviderContext.BindingInfo.BindingSource == null)
            { 
                return new BinderTypeModelBinder(typeof(MyModelBinder));
            }

            if (p_ModelBinderProviderContext.BindingInfo.BindingSource == BindingSource.Query)
            {
                return new BinderTypeModelBinder(typeof(MyModelBinder));
            }

            return null;
        }
    }
 
}
