using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BlueDream.Common
{
    public class SystemTools
    {
        public static void InitModel(object p_Object)
        {
            foreach (PropertyInfo t_PropertyInfo in p_Object.GetType().GetProperties())
            {
                object t_PropertyInfo_Obj = t_PropertyInfo.GetValue(p_Object);


                switch (t_PropertyInfo.PropertyType.ToString())
                {
                    case "System.String":
                        if (t_PropertyInfo_Obj == null)
                        {
                            t_PropertyInfo.SetValue(p_Object, "");
                        }
                        break;
                    case "System.DateTime":
                        if (t_PropertyInfo_Obj == null || Convert.ToDateTime(t_PropertyInfo_Obj) < Convert.ToDateTime("1901-01-01 00:00:00"))
                        {
                            t_PropertyInfo.SetValue(p_Object, Convert.ToDateTime("1901-01-01 00:00:00"));
                        }

                        break;
                }

            }
        }
    }
}
