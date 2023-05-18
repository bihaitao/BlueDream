 
using BlueDream.Common;
using BlueDream.Model;
using BuleDream.Bll;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BlueDream.WebApi
{
    /// <summary>
    /// 授权帮助类
    /// </summary>
    public class LoginHelper
    {
        /// <summary>
        /// 常量HttpHeaders请求头
        /// </summary>
        public const string LoginKey = "LoginKey";

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginHelper() { }

        /// <summary>
        /// 校验用户权限
        /// </summary>
        /// <param name="p_HttpContext">请求信息</param>
        public static void IsLogin(HttpContext p_HttpContext)
        {
            //获取请求的认证信息
            string p_EnCodeString = p_HttpContext.Request.Headers["LoginKey"];

            if (string.IsNullOrWhiteSpace(p_EnCodeString))
            {
                SysExTools.Throw_LoginEx("请求认证Key不存在!", "p_HttpContext.Request.Headers[LoginKey] 为空!");
            }
            //校验权限
            LoginUserModel m_LoginUserModel = GetLoginUserByEnCodeString(p_EnCodeString);

            //判断是否超过授权时间
            if (m_LoginUserModel.LoginOutTime < DateTime.Now)
            {
                if (string.IsNullOrWhiteSpace(p_EnCodeString))
                {
                    SysExTools.Throw_LoginEx("请求已过期!", $"{m_LoginUserModel.ToString()}", $"{m_LoginUserModel.UserID}");
                }
            }
        }


        public static string GenEnCodeString(LoginUserModel p_LoginUserModel)
        {
            RsaEntity m_RsaEntity = RsaKeyBll.GetSystemRsa();
            string m_RsaString = RsaHelper.EncryptByPublicKey(p_LoginUserModel.ToString(),m_RsaEntity.PublicKey);
            string m_HexString =HexTools.AscllToHex(m_RsaString);
            return $@"{m_RsaEntity.RsaID}{m_HexString}"; 
        }

        /// <summary>
        /// 根据加密后的信息，鉴权解密
        /// </summary>
        /// <param name="p_EnCodeString"></param>
        /// <returns></returns>
        public static LoginUserModel GetLoginUserByEnCodeString(string p_EnCodeString)
        {
            //截取得到秘钥ID
            long m_RsaKeyID1 = Convert.ToInt64(p_EnCodeString.Substring(0, 19));
            //根据秘钥ID获取秘钥对象信息
            RsaEntity m_RsaEntity = RsaKeyBll.GetByID(m_RsaKeyID1);

            if (m_RsaEntity == null)
            {
                SysExTools.Throw_CheckDateEx("鉴权失败", $"根据秘钥ID没有找到对应的秘钥信息,RsaKeyID:{m_RsaKeyID1}", $"RsaKeyID:{ m_RsaKeyID1}");
            }

            //得到加密串
            p_EnCodeString = p_EnCodeString.Substring(19);

            //将公钥转换成Ascll码
            p_EnCodeString = HexTools.HexToAscll(p_EnCodeString);

            //根据私钥解密
            string m_UserModelInfo = RsaHelper.DecryptByPrivateKey(p_EnCodeString, m_RsaEntity.PrivateKey);

            //将解密后的信息解析成User信息
            LoginUserModel m_LoginUserModel = new LoginUserModel(m_UserModelInfo);

            //根据秘钥ID得到站点信息
            //CodeServerEntity m_CodeServerEntity = CodeServerBll.GetByRsaKeyID1(m_RsaKeyID1);

            //if (m_CodeServerEntity != null)
            //{
            //    m_LoginUserModel.CodeServerID = m_CodeServerEntity.CodeSeverID;
            //}


            return m_LoginUserModel;
        }
 
    }
}
