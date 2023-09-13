using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Model
{
    public class OrderItemModel:OrderItemEntity
    {
        public OrderItemModel()
        {
            OrderDetailList = new List<OrderDetailEntity>();
        }

        public List<OrderDetailEntity> OrderDetailList
        {
            set;get;
        }
    }
}
