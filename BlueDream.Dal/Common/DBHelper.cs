using BlueDream.Common;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDream.Dal
{
    public class DBHelper
    {

        /// <summary>
        /// 创建数据库对象（读写）
        /// </summary>
        /// <returns></returns>
        public static DBClient CreateClient()
        {
            return Create(CfgManager.Instance.ReadWriteConnection, CfgManager.Instance.DataBaseType);
        }


        /// <summary>
        /// 创建数据库对象（只读）
        /// </summary>
        /// <returns></returns>
        public static DBClient CreateReadOnlyClient()
        {
            return Create(CfgManager.Instance.ReadOnlyConnection, CfgManager.Instance.DataBaseType);
        }

 

        /// <summary>
        /// 根据数据库类型创建数据库连接
        /// </summary>
        /// <param name="p_ConnectionString">数据库连接字符串</param>
        /// <param name="p_DbType"></param>
        /// <returns></returns>
        private static DBClient Create(string p_ConnectionString, SqlSugar.DbType p_DbType)
        {
            SqlSugarClient m_SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = p_ConnectionString,
                DbType = p_DbType,
                IsAutoCloseConnection = true
            });

            DBClient m_DBClient = new DBClient
            {
                Instance = m_SqlSugarClient,
                ConnectionString = p_ConnectionString
            };

            return m_DBClient;
        }


        /// <summary>
        /// 附加异常处理执行
        /// </summary>
        /// <param name="p_CommonResultBase"></param>
        /// <param name="p_Action"></param>
        public static void Transaction(Action<DBClient> p_Action)
        {
            DBClient m_DBClient = CreateReadOnlyClient();
            try
            {
                m_DBClient.Instance.Ado.BeginTran();

                p_Action(m_DBClient);

                m_DBClient.Instance.Ado.CommitTran();
            }
            catch (SysEx m_SysEx)
            {
                try
                {
                    m_DBClient.Instance.Ado.RollbackTran();
                }
                catch
                {

                }

                throw m_SysEx;
            }
            catch (Exception m_Exception)
            {
                try
                {
                    m_DBClient.Instance.Ado.RollbackTran();
                }
                catch
                {

                }
                throw m_Exception;
            }
        }

    }
}
