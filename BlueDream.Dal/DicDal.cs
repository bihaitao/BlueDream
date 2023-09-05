using BlueDream.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Dal
{
    public class DicDal
    {
        public DicDal() { }

        public static List<CurrencyModel> GetCurrencyModels() 
        {
            List<CurrencyModel> m_CurrencyList = new List<CurrencyModel>
            {
                new CurrencyModel()
                {
                    CurrencyCode = "CNY",
                    CurrencyName = "人民币",
                }, 
                new CurrencyModel()
                {
                    CurrencyCode = "USD",
                    CurrencyName = "美元",
                }, 
                new CurrencyModel()
                {
                    CurrencyCode = "JPY",
                    CurrencyName = "日元",
                }
            }; 

            return m_CurrencyList;
        }
    }
}
