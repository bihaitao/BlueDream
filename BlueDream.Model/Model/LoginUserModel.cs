 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueDream.Model
{
    /// <summary>
    /// 用户登录验证信息
    /// </summary>
    public class LoginUserModel
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginUserModel()
        {
            
        }

        /// <summary>
        /// 一个入参的构造函数，根据入参值拆分赋值4个基类字段
        /// </summary>
        /// <param name="p_ModelInfo"></param>
        public LoginUserModel(string p_ModelInfo)
        {
            string[] m_StrList = p_ModelInfo.Split(',');

            UserID = Convert.ToInt64(m_StrList[0]);
            UserNickName = m_StrList[1];
            LoginOutTime = Convert.ToDateTime(m_StrList[2]);
        }
 
        /// <summary>
        /// 用户ID
        /// </summary>
        public  Int64 UserID { set; get; } = 0;
         
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserNickName { set; get; } = "";

        /// <summary>
        /// 超时时间
        /// </summary>
        public DateTime LoginOutTime { set; get; } = DateTime.Now;

        /// <summary>
        /// 重写ToString()方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $@"{UserID},{UserNickName},{LoginOutTime.ToString("yyyy-MM-dd HH:mm:ss")}"; 
        }
    }
}
