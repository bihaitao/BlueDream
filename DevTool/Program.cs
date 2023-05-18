using BlueDream.Common;
using DevTool.CodeTools;
using DevTool.CodeTools.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        GenCode();
        //string m_LongID = StringTools.GetNewGuidLongString();
        //Tuple<string, string> m_Tuple = RsaHelper.GenerateRsaKeys();
        //MIGdMA0GCSqGSIb3DQEBAQUAA4GLADCBhwKBgQkJqzd+hjx7Mn6f2qSS15ZcJqrgU06etEm7tUd6ou2OnS3sGu3Zy5eAmh4jJZboPHgUvY9GhhFNahhyWdGSoOVGaxYdN4xwqjxwoR4TlvFXNkxo6SQfZqbalbbJWxGIFEcpeptI2yiJzmBcevtyTVcQs3VGMo3CnQiPyjWScUtPVQIBAw==
        //MIICdwIBADANBgkqhkiG9w0BAQEFAASCAmEwggJdAgEAAoGBCQmrN36GPHsyfp/apJLXllwmquBTTp60Sbu1R3qi7Y6dLewa7dnLl4CaHiMllug8eBS9j0aGEU1qGHJZ0ZKg5UZrFh03jHCqPHChHhOW8Vc2TGjpJB9mptqVtslbEYgURyl6m0jbKInOYFx6+3JNVxCzdUYyjcKdCI/KNZJxS09VAgEDAoGBBgZyJP8EKFIhqb/nGGHlDugZx0A3ib8i29J42lHB87RoyUgR8+aHulW8FBduZJrS+rh+X4RZYN5Guvbmi7cV7irvIV50fRnZUx43QAb7PPlCrHvFP9Rjt0Zu0+M/PWMWngTQbOJIoQ/c4hoZhTe1MvenW4EzEeLf6kZB6Pit8XdrAkEDIDmks6GzGqfy866yr7e1FmOjzutcO/WJmtzkLIYfDWKjOKPv8E/FBfnNQGCBGvHBNi2xS20md+zTWP5CML+VOQJBAuQqatUvFsmX0FqPVm5eLDvmC3JZBJUeZ1ScEE+vVGT3fwlUBX3nLP0TaBRTHaKY3AI+UxqFx9U8Uw5Z2zuhhv0CQQIVe8Mia8y8b/dNHyHKeni5l8KJ8j19Tlu8k0LIWWoI7GzQbUqgNS4D+94q6wC8oSt5c8uHnhmlSIzl/tbLKmN7AkEB7XGcjh9khmU1kbTkSZQdfUQHoZCtuL7vjb1gNR+NmKT/W41Y/pod/gzwDYy+bGXoAX7iEa6FONLiCZE80muvUwJBAbkSk9khi0+rD8wiEK4aIK8IR6RVStutb/KaN3nFNExbcKhOhGppzuEz6rVySHTsXwwnGLeGR/YuFRXZZRcAJ74=
        Console.WriteLine("Hello, World!");

        Console.ReadKey();
    }  

    /// <summary>
    /// 生成实体类代码
    /// </summary>
    private static void GenCode()
    {
        string m_ConStr = "Server=rm-bp1lpp0h73oj596h3go.mysql.rds.aliyuncs.com;Database=bule_dream;UID=crm;PWD=crm@1234;";

        List<TableInfo> m_TableInfoList = DbTools.GetMySqlInfo(m_ConStr);

        CodeTools.FillCodeName(m_TableInfoList);

        CodeTools.GenCode(m_TableInfoList, "C:\\mydisk\\code_temp\\");
    }
}