namespace BlueDream.WebApi
{
    public class VerifyCode
    {
        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 验证码数据流
        /// </summary>
        public byte[] Image { get; set; }
    }
    public enum VerifyCodeType
    {
        NUM,
        CHAR
    }
 
}
