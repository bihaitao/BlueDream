using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class ConfigManager
    {

        public static string Server
        {
            get
            {
                return GetValueByKey("Server");
            }
        }

        private static string GetValueByKey(string p_Key)
        {
            return ConfigurationManager.AppSettings[p_Key];
        }
    }
}
