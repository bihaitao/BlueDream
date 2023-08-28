

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Web;

namespace BlueDream.WinForm
{
    public static class HttpHelper
    {
        public static string LoginKey { set; get; } = "";
        

        /// <summary>
        /// 向指定URL发送GET方法的请求
        /// </summary>
        /// <param name="p_Url">发送请求的URL</param>
        /// <param name="p_Param">请求参数，请求参数应该是 name1=value1</param>
        /// <returns>所代表远程资源的响应结果</returns>
        public static string Get(string p_Url, List<string> p_Params)
        {
            return Get(p_Url, string.Join('&', p_Params));
        }

        /// <summary>
        /// 向指定URL发送GET方法的请求
        /// </summary>
        /// <param name="p_Url">发送请求的URL</param>
        /// <param name="p_Param">请求参数，请求参数应该是 name1=value1&name2=value2 的形式。</param>
        /// <returns>所代表远程资源的响应结果</returns>
        public static string Get(string p_Url, string p_Param)
        {
            string m_Result = String.Empty;
            StreamReader m_StreamReader = null;
            try
            {
                string m_UrlNameString = p_Url + "?" + p_Param;
                HttpWebRequest m_HttpWebRequest = (HttpWebRequest)WebRequest.Create(m_UrlNameString);

                if(!string.IsNullOrWhiteSpace(LoginKey))
                {
                    m_HttpWebRequest.Headers.Add("LoginKey", LoginKey);
                }
                m_HttpWebRequest.Method = "GET";
                m_HttpWebRequest.ContentType = "application/json; charset=utf-8";
                m_HttpWebRequest.Accept = "text/plain";
                m_HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1;SV1)";

                HttpWebResponse m_HttpWebResponse = (HttpWebResponse)m_HttpWebRequest.GetResponse();
                Stream m_Stream = m_HttpWebResponse.GetResponseStream();
                m_StreamReader = new StreamReader(m_Stream, Encoding.GetEncoding("utf-8"));
                m_Result = m_StreamReader.ReadToEnd();

                m_StreamReader.Close();
                m_Stream.Close();
                m_HttpWebResponse.Close();
                m_StreamReader = null;
                m_Stream = null;
                m_HttpWebResponse = null;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (m_StreamReader != null)
                {
                    m_StreamReader.Close();
                }
            }
            return m_Result;
        }



        /// <summary>
        /// 向指定 URL 发送POST方法的请求
        /// </summary>
        /// <param name="p_Url">发送请求的 URL</param>
        /// <param name="jsonData">请求参数，请求参数应该是Json格式字符串的形式。</param>
        /// <returns>所代表远程资源的响应结果</returns>
        public static string Post(string p_Url, string p_JsonData)
        {
            string m_Result = String.Empty;
            try
            {
                CookieContainer m_CookieContainer = new CookieContainer();

                HttpWebRequest m_HttpWebRequest = (HttpWebRequest)WebRequest.Create(p_Url);
                m_HttpWebRequest.Method = "POST";
                m_HttpWebRequest.Headers.Add("x-requested-with", "XMLHttpRequest");
                if (!string.IsNullOrWhiteSpace(LoginKey))
                {
                    m_HttpWebRequest.Headers.Add("LoginKey", LoginKey);
                }
                m_HttpWebRequest.ServicePoint.Expect100Continue = false;
                m_HttpWebRequest.ContentType = "application/json";
                m_HttpWebRequest.Accept = "*/*";
                m_HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1;SV1)";
                m_HttpWebRequest.ContentLength = Encoding.UTF8.GetByteCount(p_JsonData);
                m_HttpWebRequest.CookieContainer = m_CookieContainer;
                using (StreamWriter m_StreamWriter = new StreamWriter(m_HttpWebRequest.GetRequestStream()))
                {
                    m_StreamWriter.Write(p_JsonData);
                }

                HttpWebResponse m_HttpWebResponse = (HttpWebResponse)m_HttpWebRequest.GetResponse();
                m_HttpWebResponse.Cookies = m_CookieContainer.GetCookies(m_HttpWebResponse.ResponseUri);
                using (Stream m_ResponseStream = m_HttpWebResponse.GetResponseStream())
                {
                    using (StreamReader t_StreamReader = new StreamReader(m_ResponseStream))
                    {
                        m_Result = t_StreamReader.ReadToEnd();

                        t_StreamReader.Close();
                    }
                    m_ResponseStream.Close();
                }
                m_HttpWebResponse.Close();
                m_HttpWebResponse = null;
                m_HttpWebRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送GET请求出现异常：" + ex.Message);
            }
            return m_Result;
        }



        /// <summary>
        /// 上传媒体文件
        /// </summary>
        /// <param name="url">上传媒体文件的微信公众平台接口地址</param>
        /// <param name="file">要上传的媒体文件对象</param>
        /// <returns>返回上传的响应结果，详情参看微信公众平台开发者接口文档</returns>
        public static string Upload(string url, string file)
        {
            string m_Result = String.Empty;
            try
            {
                WebClient m_WebClient = new WebClient();
                m_WebClient.Credentials = CredentialCache.DefaultCredentials;
                byte[] m_ResponseArray = m_WebClient.UploadFile(url, "POST", file);
                m_Result = System.Text.Encoding.Default.GetString(m_ResponseArray, 0, m_ResponseArray.Length);
                Console.WriteLine("上传result:" + m_Result);
            }
            catch (Exception ex)
            {
                m_Result = "Error:" + ex.Message;
                Console.WriteLine("发送GET请求出现异常：" + ex.Message);
            }
            finally
            {
                Console.WriteLine("上传MediaId:" + m_Result);
            }
            return m_Result;
        }

        public static bool Download(string p_Url, string p_Param, string p_OutFileName)
        {
            bool m_Result = false;
            FileStream m_FileStream = null;
            try
            {
                string m_UrlNameString = $@"{p_Url}?{p_Param}";
                HttpWebRequest m_HttpWebRequest = (HttpWebRequest)WebRequest.Create(m_UrlNameString);
                m_HttpWebRequest.Method = "GET";
                m_HttpWebRequest.ContentType = "text/html;charset=UTF-8";
                m_HttpWebRequest.Accept = "*/*";
                m_HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1;SV1)";

                HttpWebResponse m_HttpWebResponse = (HttpWebResponse)m_HttpWebRequest.GetResponse();
                Stream m_ResponseStream = m_HttpWebResponse.GetResponseStream();
                m_FileStream = new FileStream(p_OutFileName, FileMode.Create);
                int m_BufferSize = 2048;
                byte[] m_Data = new byte[m_BufferSize];
                int m_Length = 0;
                while ((m_Length = m_ResponseStream.Read(m_Data, 0, m_BufferSize)) > 0)
                {
                    m_FileStream.Write(m_Data, 0, m_Length);
                }
                m_FileStream.Close();
                m_ResponseStream.Close();
                m_HttpWebResponse.Close();
                m_FileStream = null;
                m_ResponseStream = null;
                m_HttpWebResponse = null;

                m_Result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("下载媒体文件时出现异常：" + ex.Message);

            }
            finally
            {
                if (m_FileStream != null)
                {
                    m_FileStream.Close();
                }
            }
            return m_Result;
        }

    }

}