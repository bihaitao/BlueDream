using BlueDream.Enum;

namespace BlueDream.Common
{
    /// <summary>
    /// 根据异常等级发送邮件工具类
    /// </summary>
    public class ExAlarmTools
    {

        /// <summary>
        /// 根据异常等级发送邮件
        /// </summary>
        /// <param name="p_SysEx"></param>
        public static void Alarm(SysEx p_SysEx)
        { 
            ////紧急
            //if (p_SysEx.Level == ExLevelEnum.Critical)
            //{
            //    Critical(p_SysEx);
            //}

            ////高
            //if (p_SysEx.Level == ExLevelEnum.High)
            //{
            //    High(p_SysEx);
            //}
        }


        /// <summary>
        /// 紧急
        /// </summary>
        /// <param name="p_SysEx"></param>
        public static void Critical(SysEx p_SysEx)
        {
            //SendEmailTools.Send($"系统报警_紧急_{p_SysEx.ExFullCode}_{p_SysEx.ExTitle}", p_SysEx.ToString());
        }

        
        /// <summary>
        /// 高级
        /// </summary>
        /// <param name="p_SysEx"></param>
        public static void High(SysEx p_SysEx)
        {
            //SendEmailTools.Send($"系统报警_高级_{p_SysEx.ExFullCode}_{p_SysEx.ExTitle}", p_SysEx.ToString());
        }        
    }
}
