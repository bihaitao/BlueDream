using BlueDream.WinForm;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlueDream.Common;
using BlueDream.Model;

namespace BlueDream.WinForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ApiOrder m_ApiOrder = new ApiOrder();

            m_ApiOrder.Parameters.Add("p_PageSize", 20);
            m_ApiOrder.Parameters.Add("p_PageIndex", 1);
            m_ApiOrder.Parameters.Add("p_SearchKey", "");

            ApiResult<List<OrderEntity>> m_CommonResult = m_ApiOrder.GetListByPage();

            if (!m_CommonResult.Success)
            {
                MessageBox.Show(m_CommonResult.Message);
                return;
            }
             


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
