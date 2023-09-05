using BlueDream.Dal;
using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Bll
{
    public class DicBll
    {
        public static List<CurrencyModel> GetCurrencyModels()
        {
            return DicDal.GetCurrencyModels();
        }
    }
}
