﻿using BlueDream.Common;
using BlueDream.Model;
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

        public OrderItemEditForm(string p_ReturnKey)
        {
            m_ReturnKey = p_ReturnKey;
            InitializeComponent();
        }

        private void OrderItemEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            OrderItemEntity m_OrderItemEntity = new OrderItemEntity();

            m_OrderItemEntity.OrderItemID = StringTools.GetNewGuidLong();

            m_OrderItemEntity.ItemIndex = Convert.ToInt32(txt_ItemIndex.Text);

            m_OrderItemEntity.StyleNo = txt_StyleNo.Text;

            m_OrderItemEntity.DeliveryDate = Convert.ToDateTime(this.dtp_DeliveryDate.Text);

            m_OrderItemEntity.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);

            m_OrderItemEntity.Composition = txt_Composition.Text;

            CallBack_Event(m_ReturnKey, m_OrderItemEntity);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}