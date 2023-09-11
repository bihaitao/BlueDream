
using NetTaste;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlueDream.Common
{

    /// <summary>
    /// Json工具类
    /// </summary>
    public class JsonTools
    {

        /// <summary>
        /// 获取Json 字符串
        /// </summary>
        /// <param name="p_Obj"></param>
        /// <returns></returns>
        public static string GetJson(object p_Obj)
        {
            return JsonConvert.SerializeObject(p_Obj);
        }


        /// <summary>
        /// 根据字符串获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_JsonString"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string p_JsonString)
        {
            return JsonConvert.DeserializeObject<T>(p_JsonString);
        }

        /// <summary>
        /// 根据字符串获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(Object p_Object)
        {
            string m_Json = JsonConvert.SerializeObject(p_Object);
            return JsonConvert.DeserializeObject<T>(m_Json);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Json"></param>
        /// <param name="p_Key"></param>
        /// <returns></returns>
        public static string GetString(string p_Json, string p_Key)
        {
            JObject m_JObject = (JObject)JsonConvert.DeserializeObject(p_Json);
            return m_JObject[p_Key].ToString();
        }
    }
}
