namespace BlueDream.WinForm
{
    partial class OrderListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_Add = new Button();
            btn_Search = new Button();
            txt_Search = new TextBox();
            label1 = new Label();
            dgv_Main = new DataGridView();
            pager_dgv_Main = new Controls.PagerToolsControl();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1142, 55);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(387, 16);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "添    加";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(306, 16);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "搜    索";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(70, 16);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(230, 23);
            txt_Search.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "检索文本：";
            // 
            // dgv_Main
            // 
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Location = new Point(5, 73);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.ReadOnly = true;
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.Size = new Size(1142, 613);
            dgv_Main.TabIndex = 1;
            dgv_Main.CellDoubleClick += dgv_Main_CellDoubleClick;
            // 
            // pager_dgv_Main
            // 
            pager_dgv_Main.Current = 0;
            pager_dgv_Main.DataCount = 0;
            pager_dgv_Main.DataCountLable = "共 #count 行";
            pager_dgv_Main.Dock = DockStyle.Bottom;
            pager_dgv_Main.IsTrigger = true;
            pager_dgv_Main.Location = new Point(0, 691);
            pager_dgv_Main.Margin = new Padding(4);
            pager_dgv_Main.Name = "pager_dgv_Main";
            pager_dgv_Main.PagerNum = 10;
            pager_dgv_Main.Size = new Size(1149, 35);
            pager_dgv_Main.TabIndex = 2;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 726);
            Controls.Add(pager_dgv_Main);
            Controls.Add(dgv_Main);
            Controls.Add(groupBox1);
            Name = "OrderListForm";
            Text = "PurchaseOrderForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Dm.DmConnection dmConnection1;
        private GroupBox groupBox1;
        private Button btn_Search;
        private TextBox txt_Search;
        private Label label1;
        private Button btn_Add;
        private DataGridView dataGridView1;
        private DataGridView dgv_Main;
        private Controls.PagerToolsControl pager_dgv_Main;
        private DataGridViewTextBoxColumn Column1;
    }
}