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

namespace BlueDream.WinForm
{
    public partial class OrderItemForm : Form
    {
        public OrderItemForm()
        {
            InitializeComponent();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
