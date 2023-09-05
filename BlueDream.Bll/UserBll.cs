using BlueDream.Common;
using BlueDream.Dal;
using BlueDream.Model;
using BlueDream.Model.Model;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class UserBll
    {
        public static string LoginReturnRsaKey(string p_UserName, string p_Password)
        {
            UserEntity m_UserEntity = UserDal.GetUserByUserName(DBHelper.CreateReadOnlyClient(), p_UserName);

            if (m_UserEntity == null)
            {
                SysExTools.Throw_LoginEx("用户名密码或错误！", "UserName不存在");
            }

            if (m_UserEntity.Password != p_Password)
            {
                SysExTools.Throw_LoginEx("用户名密码或错误！", "Password 不正确");
            }

            LoginUserModel p_LoginUserModel = new LoginUserModel
            {
                UserID = m_UserEntity.UserID,
                UserNickName = m_UserEntity.NickName,
                LoginOutTime = DateTime.Now.AddDays(1)
            };
            string m_RsaKey =  GenEnCodeString(p_LoginUserModel);
            return m_RsaKey;
        }

        /// <summary>
        /// 根据LoginUserModel 生成RsaKey
        /// </summary>
        /// <param name="p_LoginUserModel"></param>
        /// <returns></returns>
        public static string GenEnCodeString(LoginUserModel p_LoginUserModel)
        {
            RsaEntity m_RsaEntity = RsaKeyBll.GetSystemRsa();
            string m_RsaString = RsaHelper.EncryptByPublicKey(p_LoginUserModel.ToString(), m_RsaEntity.PublicKey);
            string m_HexString = HexTools.AscllToHex(m_RsaString);
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
            long m_RsaKeyID = Convert.ToInt64(p_EnCodeString.Substring(0, 19));

            //根据秘钥ID获取秘钥对象信息
            RsaEntity m_RsaEntity = RsaKeyBll.GetByID(m_RsaKeyID);

            if (m_RsaEntity == null)
            {
                SysExTools.Throw_CheckDateEx("鉴权失败", $"根据秘钥ID没有找到对应的秘钥信息,RsaKeyID:{m_RsaKeyID}", $"RsaKeyID:{m_RsaKeyID}");
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<UserModel> GetTop10(string p_SearchKey)
        {
            int m_TotalCount = 0;
            List<UserEntity> m_EntityList =  UserDal.GetListByPage(DBHelper.CreateReadOnlyClient(), 10, 1, p_SearchKey, ref m_TotalCount);
            List<UserModel> m_ModelList = new List<UserModel>();
            
            foreach(UserEntity t_UserEntity in m_EntityList)
            { 
                m_ModelList.Add(new UserModel()
                {
                    UserID = t_UserEntity.UserID,
                    UserName = t_UserEntity.UserName,
                    NickName = t_UserEntity.NickName
                });
            }

            return m_ModelList; 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_SearchKey"></param>
        /// <returns></returns>
        public static List<UserEntity> GetListByPage(int p_PageSize, int p_PageIndex, string p_SearchKey, ref int p_TotalCount)
        {
            return UserDal.GetListByPage(DBHelper.CreateReadOnlyClient(), p_PageSize, p_PageIndex, p_SearchKey, ref p_TotalCount);
        }
    }
}
