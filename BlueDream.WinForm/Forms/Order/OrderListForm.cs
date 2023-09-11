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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            dgv_Main.AutoGenerateColumns = false;
            //dgv_Main.Columns.Clear();
            //InitDataGridViewColumn(dgv_Main, "OrderID", "订单ID");
            //dgv_Main.Columns["OrderID"].Visible = false;
            //InitDataGridViewColumn(dgv_Main, "OrderNo", "订单编号");
            //InitDataGridViewColumn(dgv_Main, "CustomerOrderNo", "客户订单号");
            //InitDataGridViewColumn(dgv_Main, "PurchaseOrgName", "采购方");
            //InitDataGridViewColumn(dgv_Main, "SaleOrgName", "销售方");
            //InitDataGridViewColumn(dgv_Main, "BrandName", "品牌");
            //InitDataGridViewColumn(dgv_Main, "PersonInChargeUser", "担当人");
            //InitDataGridViewColumn(dgv_Main, "OrderCurrencyCode", "货币");
            //InitDataGridViewColumn(dgv_Main, "TotalNum", "总数");
            //InitDataGridViewColumn(dgv_Main, "TotalAmount", "总金额");
            //InitDataGridViewColumn(dgv_Main, "CreateTime", "创建时间");
        }

        private void InitDataGridViewColumn(DataGridView p_DataGridView, string p_ColumnName, string p_HeadTex)
        {
            p_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = p_ColumnName,
                Name = p_ColumnName,
                HeaderText = p_HeadTex
            });
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ApiOrder m_ApiOrder = new ApiOrder();

            m_ApiOrder.Parameters.Add("p_PageSize", 20);
            m_ApiOrder.Parameters.Add("p_PageIndex", 1);
            m_ApiOrder.Parameters.Add("p_SearchKey", "*");

            ApiPageResult<List<OrderModel>> m_CommonResult = m_ApiOrder.GetOrderListByPage();

            if (!m_CommonResult.Success)
            {
                MessageBox.Show(m_CommonResult.Message);
                return;
            }

            dgv_Main.DataSource = m_CommonResult.ResultObj;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OrderEditForm m_OrderEditForm = new OrderEditForm(4926049349816525291);
            m_OrderEditForm.StartPosition = FormStartPosition.CenterParent;
            m_OrderEditForm.ShowDialog();
        }



        private void dgv_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_Main.Rows[e.RowIndex].Cells["OrderID"].Value

        }
    }
}
