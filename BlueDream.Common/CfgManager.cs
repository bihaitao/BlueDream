using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1;

namespace BlueDream.Common
{      /// <summary>
       /// appsettings配置读取辅助类
       /// </summary>
    public class CfgManager
    {
        #region 字段定义

        private static readonly string ConfigFileLock = "ConfigFileLock";
        
        private static IConfigurationRoot m_ConfigurationRoot = null;

        #endregion

        #region 单例实现

        private static CfgManager CfgManager_Instance = null;

        private CfgManager()
        {
            m_ConfigurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();
        }

        public static CfgManager Instance
        {
            get
            {
                lock (ConfigFileLock)
                {
                    if (CfgManager_Instance == null)
                    {
                        CfgManager_Instance = new CfgManager();
                    }
                    return CfgManager_Instance;
                }
            }
        }

        #endregion

        #region GetConnectionString

        /// <summary>
        /// 获取配置文件中ConnectionStrings中某个配置项的数据库连接字符串
        /// </summary>
        /// <param name="p_Key">ConnectionStrings中某个配置项</param> 
        /// <returns>返回配置文件中ConnectionStrings中某个配置项的数据库连接字符串</returns>
        private string GetConnectionString(string p_Key)
        {
            string result = m_ConfigurationRoot.GetConnectionString(p_Key);
            if (result == null)
            {
                return "";
            }
            else
            {
                return result;
            }
        }

        #endregion

        #region GetAppSetting

        /// <summary>
        /// 获取配置文件中AppSettings中某个配置项的值
        /// </summary>
        /// <param name="p_Key">AppSettings中某个配置项</param> 
        /// <returns>返回配置文件中AppSettings中某个配置项的值</returns>
        private string GetAppSetting(string p_Key)
        { 
            IConfigurationSection m_IConfigurationSection = m_ConfigurationRoot.GetSection("AppSettings");
            if (m_IConfigurationSection != null)
            {
                if (m_IConfigurationSection.GetSection(p_Key) != null)
                {
                    return m_IConfigurationSection.GetSection(p_Key).Value;
                }
            }
            return "";
        }

        #endregion


        #region Config

        /// <summary>
        /// 数据库类型
        /// </summary>
        public SqlSugar.DbType DataBaseType {
            get { 
                if( GetConnectionString("DataBaseType").ToLower() == "mysql")
                {
                    return SqlSugar.DbType.MySql;
                }
                else if (GetConnectionString("DataBaseType").ToLower() == "sqlserver")
                {
                    return SqlSugar.DbType.SqlServer;
                }

                SysExTools.Throw_ConfigEx("获取配置异常！", "DataBaseType 没有匹配的数据库类型，可选项为(mysql,sqlserver)");
                throw new Exception();
            }
        }

        /// <summary>
        /// 读写链接
        /// </summary>
        public string ReadWriteConnection { get { return GetConnectionString("ReadWriteConnection"); } }

        /// <summary>
        /// 只读链接
        /// </summary>
        public string ReadOnlyConnection { get { return GetConnectionString("ReadOnlyConnection"); } }

        /// <summary>
        /// 只读链接
        /// </summary>
        public string LogConnection { get { return GetConnectionString("LogConnection"); } }

        /// <summary>
        /// 日志中忽略某些编码
        /// </summary>
        public string LogIgronCode { get { return GetAppSetting("LogIgronCode"); } }

        /// <summary>
        /// 系统RsaID
        /// </summary>
        public Int64 RsaID { get { return Convert.ToInt64(GetAppSetting("RsaID")); } }

        #endregion
    }
}
