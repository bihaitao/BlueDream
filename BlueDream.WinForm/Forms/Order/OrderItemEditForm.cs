using BlueDream.Common;
using BlueDream.Model;
using BlueDream.Model.Common;
using Org.BouncyCastle.Asn1.X509;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueDream.WinForm
{
    public partial class OrderItemEditForm : Form
    {
        private string m_ReturnKey = "";

        public delegate void CallBack(string p_Key, object p_Value);//定义委托
        public event CallBack CallBack_Event;//事件变量

        public bool m_IsAdd = true;

        OrderItemModel m_OrderItemModel = new OrderItemModel();


        public OrderItemEditForm(string p_ReturnKey)
        {
            m_ReturnKey = p_ReturnKey;
            InitializeComponent();
        }

        public OrderItemEditForm(string p_ReturnKey, OrderItemModel p_OrderItemModel)
        {
            InitializeComponent();

            m_IsAdd = false;
            m_ReturnKey = p_ReturnKey;
            m_OrderItemModel = p_OrderItemModel;


            txt_ItemIndex.Text = m_OrderItemModel.ItemIndex.ToString();
            txt_StyleNo.Text = m_OrderItemModel.StyleNo;
            dtp_DeliveryDate.Text = m_OrderItemModel.DeliveryDate.ToString();
            txt_UnitPrice.Text = m_OrderItemModel.UnitPrice.ToString();
            txt_Composition.Text = m_OrderItemModel.Composition;

            InitDataGridViewColumn(dgv_Main, "Color", "颜色");

            var m_Groups_Size = p_OrderItemModel.OrderDetailList.GroupBy(t => t.Size);
            foreach (var t_SizeGroupTemp in m_Groups_Size)
            { 
                InitDataGridViewColumn(dgv_Main, t_SizeGroupTemp.Key, t_SizeGroupTemp.Key);
            }

            var m_Groups_Color = p_OrderItemModel.OrderDetailList.GroupBy(t => t.Color);
             
            foreach (var t_ColorGroupTemp in m_Groups_Color)
            {
                int t_RowIndex = this.dgv_Main.Rows.Add();
                dgv_Main.Rows[t_RowIndex].Cells[0].Value = t_ColorGroupTemp.Key;
                dgv_Main.Rows[t_RowIndex].Cells[0].ReadOnly = true;
            }

            foreach(OrderDetailEntity t_OrderDetailEntity in p_OrderItemModel.OrderDetailList)
            {
                dgv_Main.Rows[FindRowIndex(t_OrderDetailEntity.Color)].Cells[t_OrderDetailEntity.Size].Value = t_OrderDetailEntity.Quantity;
            }

        }

        private int FindRowIndex(string p_Color)
        {
            for(int t_RowIndex=0;t_RowIndex<dgv_Main.Rows.Count;t_RowIndex++)
            {
                if (dgv_Main.Rows[t_RowIndex].Cells[0].Value.ToString() == p_Color)
                {
                    return t_RowIndex;
                }
            }

            return 0;
        }

        private void OrderItemEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (m_IsAdd)
            {
                m_OrderItemModel = new OrderItemModel();

                m_OrderItemModel.OrderItemID = StringTools.GetNewGuidLong();

                m_OrderItemModel.ItemIndex = Convert.ToInt32(txt_ItemIndex.Text);

                m_OrderItemModel.StyleNo = txt_StyleNo.Text;

                m_OrderItemModel.DeliveryDate = Convert.ToDateTime(this.dtp_DeliveryDate.Text);

                m_OrderItemModel.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);

                m_OrderItemModel.Composition = txt_Composition.Text;

                m_OrderItemModel.OrderDetailList = GetDetailList();
  
                CallBack_Event(m_ReturnKey, m_OrderItemModel);
            }
            else
            {
                m_IsAdd = true;

                m_OrderItemModel.ItemIndex = Convert.ToInt32(txt_ItemIndex.Text);

                m_OrderItemModel.StyleNo = txt_StyleNo.Text;

                m_OrderItemModel.DeliveryDate = Convert.ToDateTime(this.dtp_DeliveryDate.Text);

                m_OrderItemModel.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);

                m_OrderItemModel.Composition = txt_Composition.Text;

                m_OrderItemModel.OrderDetailList = GetDetailList();

                CallBack_Event(m_ReturnKey, m_OrderItemModel);
            }
        }

        private List<OrderDetailEntity> GetDetailList()
        {
            List<OrderDetailEntity> m_DetailList = new List<OrderDetailEntity>();
            for (int t_RowIndex = 0; t_RowIndex < dgv_Main.RowCount; t_RowIndex++)
            {
                for (int t_ColumnIndex = 1; t_ColumnIndex < dgv_Main.ColumnCount; t_ColumnIndex++)
                {
                    OrderDetailEntity m_OrderDetailEntity = new OrderDetailEntity();

                    m_OrderDetailEntity.OrderDetailID = StringTools.GetNewGuidLong();

                    m_OrderDetailEntity.OrderItemID = m_OrderItemModel.OrderItemID;

                    m_OrderDetailEntity.Color = dgv_Main.Rows[t_RowIndex].Cells[0].Value.ToString();

                    m_OrderDetailEntity.Size = dgv_Main.Columns[t_ColumnIndex].Name;

                    m_OrderDetailEntity.OrderDetailNo = "";

                    m_OrderDetailEntity.Quantity = Convert.ToInt32(dgv_Main.Rows[t_RowIndex].Cells[t_ColumnIndex].Value);

                    m_OrderDetailEntity.DeliveryQuantity = 0;

                    BaseTools.InitBase(m_OrderDetailEntity);

                    m_DetailList.Add(m_OrderDetailEntity);
                }
            }

            return m_DetailList;

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Gen_Click(object sender, EventArgs e)
        {
            dgv_Main.AutoGenerateColumns = false;
            dgv_Main.Columns.Clear();

            InitDataGridViewColumn(dgv_Main, "Color", "颜色");

            foreach (string p_Size in txt_Size.Text.Split(','))
            {
                InitDataGridViewColumn(dgv_Main, p_Size, p_Size);
            }

            foreach (string p_Color in txt_Color.Text.Split(','))
            {
                int t_RowIndex = this.dgv_Main.Rows.Add();
                dgv_Main.Rows[t_RowIndex].Cells[0].Value = p_Color;
                dgv_Main.Rows[t_RowIndex].Cells[0].ReadOnly = true;
            }
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

    }
}
