using BlueDream.WinForm.Forms.Purchase;
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
    public partial class ClothingOrderForm : Form
    {
        public ClothingOrderForm()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //检索订单
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClothingOrderEditForm m_Form = new ClothingOrderEditForm();
             
            m_Form.ShowDialog();

        }
    }
}
