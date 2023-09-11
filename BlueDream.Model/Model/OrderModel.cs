using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Model
{
    public class OrderModel : OrderEntity
    {
        public OrderModel()
        {
            OrderItemList = new List<OrderItemEntity>();
        }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { set; get; }

        /// <summary>
        /// 担当人
        /// </summary>
        public string PersonInChargeUser { set; get; }
        
        /// <summary>
        /// 采购方名称
        /// </summary>
        public string PurchaseOrgName { set; get; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        public string SaleOrgName { set; get; }

        public List<OrderItemEntity> OrderItemList { set; get; }
    }
}
