using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{ 
    public class ApiResult<T>
    {
        /// <summary>
        /// 操作是否成功
        /// </summary> 
        public bool Success { set; get; }

        /// <summary>
        /// 异常编码
        /// </summary>
        public string ExCode { set; get; } = "";

        /// <summary>
        /// 返回信息
        /// </summary> 
        public string Message { set; get; } = "";

        /// <summary>
        /// 异常信息
        /// </summary> 
        public string ExMessage { set; get; } = "";

        /// <summary>
        /// 返回值
        /// </summary> 
        public T ResultObj { set; get; }

        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
