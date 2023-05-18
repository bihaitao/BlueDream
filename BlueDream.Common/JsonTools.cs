
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
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
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
