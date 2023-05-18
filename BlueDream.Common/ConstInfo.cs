
namespace BlueDream.Common
{
    /// <summary>
    /// 常量类
    /// </summary>
    public class ConstInfo
    {


        public const string ClassIndexNum = "1";

        /// <summary>
        /// 同步企业信息Task任务key 名称
        /// </summary>
        public const string RequestCodeTask = "RequestCodeTask";

        /// <summary>
        /// 同步编码信息Task任务key名称
        /// </summary>
        public const string RequestBatchCodeTask = "RequestBatchCodeTask";

        /// <summary>
        /// 图片回传Task任务名称
        /// </summary>
        public const string RequestPicTask = "ReturnPicTask";

        /// <summary>
        /// 认证类型
        /// </summary>
        public static int CertificationType;// 1 ecode 2 handle 4 OID

        /// <summary>
        /// 码池数量单位，（1=10000）
        /// </summary>
        public static int CodeUnit = 10000;

        /// <summary>
        /// Task任务名称ECodeReturn (编码回传)
        /// </summary>
        public const string ECodeReturn = "ECodeReturn";

        /// <summary>
        /// Task任务名称HandleReturn (编码回传)
        /// </summary>
        public const string HandleReturn = "HandleReturn";

        /// <summary>
        /// In 在Sql 中的 最大数量限制
        /// </summary>
        public const int MaxInCount = 2000;

        /// <summary>
        /// 
        /// </summary>
        public const string OperateCodeEntity = "Code";

        /// <summary>
        /// 
        /// </summary>
        public const string OperateTaskEntity = "Task";

        /// <summary>
        /// 按月归档
        /// </summary>
        public const string BackDate_Mothon = "Mothon";

        /// <summary>
        /// 按年归档
        /// </summary>
        public const string BackDate_Year = "Year";

        /// <summary>
        /// 数据库类型 mysql
        /// </summary>
        public const string DataBaseType_MySlq = "mysql";

        /// <summary>
        /// 数据库类型 pgsql
        /// </summary>
        public const string DataBaseType_PgSql = "pgsql";

        /// <summary>
        /// copy 打码数据
        /// </summary>
        public const string CopyMdCodeDataTask = "CopyMdCodeDataTask";

        public const string ZRP_Fx = "ZRP";

        public static string ZRP_FxInfo = $"{ZRP_Fx}:";
    }
}
