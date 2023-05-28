 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm.Model
{
    public class MenuModel
    {
        public static  Dictionary<string,string> GetMenuDic()
        {
            Dictionary<string, string> m_MenuDic = new Dictionary<string, string>();
            m_MenuDic.Add("test1",typeof(BlueDream.WinForm.Forms.Form1).FullName);
            m_MenuDic.Add("test2", typeof(BlueDream.WinForm.Forms.Form2).FullName);
            return m_MenuDic;
        }
    }
}
