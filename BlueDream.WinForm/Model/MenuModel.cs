
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlueDream.WinForm
{
    public class MenuModel
    {
        public MenuModel()
        {
            SubMenus = new List<MenuModel>();
        }

         
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public string FormFullName { set; get; } = "";

        /// <summary>
        /// 
        /// </summary>
        public List<MenuModel> SubMenus { set; get; }
    }
}
