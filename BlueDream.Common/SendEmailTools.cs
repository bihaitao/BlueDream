using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace BlueDream.Common
{
   public  class SendEmailTools
    {


     


        /// <summary>
        /// 发送邮件给指定的地址
        /// </summary>
        /// <param name="p_MailModel"></param>
        public static void SendEmail(MailModel p_MailModel)
        {
            MailMessage m_MailMessage = new MailMessage();
            m_MailMessage.From = new MailAddress(p_MailModel.Account, p_MailModel.Name, Encoding.UTF8);
            m_MailMessage.Subject = p_MailModel.Subject;
            m_MailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            m_MailMessage.Body = p_MailModel.Body;
            m_MailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            m_MailMessage.IsBodyHtml = true;          

            foreach (string t_To in p_MailModel.To)
            {
                m_MailMessage.To.Add(t_To);
            }

            SmtpClient m_SmtpClient = new SmtpClient();
            m_SmtpClient.Credentials = new System.Net.NetworkCredential(p_MailModel.Account, p_MailModel.Password);
            m_SmtpClient.Port = p_MailModel.Port;
            m_SmtpClient.Host = p_MailModel.SmtpClient;
            m_SmtpClient.EnableSsl = false;
            m_SmtpClient.Send(m_MailMessage);
            m_MailMessage.Dispose();
            m_SmtpClient.Dispose();
        }

    }



    /// <summary>
    /// 邮件实体
    /// </summary>
    public class MailModel
    {
        public MailModel()
        {
            To = new List<string>();
        }

        /// <summary>
        /// 接收人
        /// </summary>
        public List<string> To { set; get; }

        /// <summary>
        /// 邮箱服务地址
        /// </summary>
        public string SmtpClient { set; get; } = "";

        /// <summary>
        /// 端口 （126smtp：25）
        /// </summary>
        public int Port { set; get; }

        /// <summary>
        /// 邮箱账号
        /// </summary>
        public string Account { set; get; } = "";

        /// <summary>
        /// 邮箱密码
        /// </summary>
        public string Password { set; get; } = "";

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { set; get; } = "";

        /// <summary>
        /// 标题
        /// </summary>
        public string Subject { set; get; } = "";

        /// <summary>
        /// 内容
        /// </summary>
        public string Body { set; get; } = "";
    }
}
