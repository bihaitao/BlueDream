using System.Runtime.Serialization;

namespace BlueDream.Common
{
    /// <summary>
    /// 返回结果
    /// Success、IsHappenEx默认值为False
    /// </summary>
    [DataContract]
    public class CommonResult
    {
        /// <summary>
        /// 将是否成功和发生异常标志初始化为false
        /// </summary>
        public CommonResult()
        {
            Success = false;
            ResultObj = new object();
        }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [DataMember]
        public bool Success { set; get; } 

        /// <summary>
        /// 异常编码
        /// </summary>
        [DataMember]
        public string ExCode { set; get; } = "";

        /// <summary>
        /// 返回信息
        /// </summary>
        [DataMember]
        public string Message { set; get; } = "";

        /// <summary>
        /// 异常信息
        /// </summary>
        [DataMember]
        public string ExMessage { set; get; } = "";

        /// <summary>
        /// 返回值（object数组）
        /// </summary>
        [DataMember]
        public object ResultObj { set; get; }

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
