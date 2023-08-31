using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Model.Model
{
    public class UserModel  
    {
        /// <summary>
        /// 
        /// </summary>
        public long UserID { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; } = "";
        
        /// <summary>
        /// 
        /// </summary>
        public string NickName { get; set; } = "";
    }
}
