using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Model
{
    public class OrderItemModel : OrderItemEntity
    {
        public OrderItemModel()
        {
            OrderDetailList = new List<OrderDetailEntity>();
        }

        public List<OrderDetailEntity> OrderDetailList
        {
            set; get;
        }

        public List<string> Colors
        {
            get
            {
                List<string> m_ColorList = new List<string>();

                OrderDetailList = OrderDetailList.OrderBy(t => t.OrderIndex).ToList();

                foreach (OrderDetailEntity t_OrderDetailEntity in OrderDetailList)
                {
                    if (!m_ColorList.Contains(t_OrderDetailEntity.Color))
                    {
                        m_ColorList.Add(t_OrderDetailEntity.Color);
                    }

                }

                return m_ColorList;
            }
        }

        public List<string> Size
        {
            get
            {
                List<string> m_SizeList = new List<string>();

                OrderDetailList = OrderDetailList.OrderBy(t => t.OrderIndex).ToList();

                foreach (OrderDetailEntity t_OrderDetailEntity in OrderDetailList)
                {
                    if (!m_SizeList.Contains(t_OrderDetailEntity.Size))
                    {
                        m_SizeList.Add(t_OrderDetailEntity.Size);
                    }

                }

                return m_SizeList;
            }
        }
    }
}
