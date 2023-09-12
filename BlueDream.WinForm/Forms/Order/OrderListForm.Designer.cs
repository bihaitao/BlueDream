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
            OrderID = new DataGridViewTextBoxColumn();
            OrderNo = new DataGridViewTextBoxColumn();
            CustomerOrderNo = new DataGridViewTextBoxColumn();
            PurchaseOrgName = new DataGridViewTextBoxColumn();
            SaleOrgName = new DataGridViewTextBoxColumn();
            BrandName = new DataGridViewTextBoxColumn();
            PersonInChargeUser = new DataGridViewTextBoxColumn();
            OrderCurrencyCode = new DataGridViewTextBoxColumn();
            TotalNum = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            CreateTime = new DataGridViewTextBoxColumn();
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
            dgv_Main.AllowUserToAddRows = false;
            dgv_Main.AllowUserToDeleteRows = false;
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.BackgroundColor = SystemColors.Control;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderNo, CustomerOrderNo, PurchaseOrgName, SaleOrgName, BrandName, PersonInChargeUser, OrderCurrencyCode, TotalNum, TotalAmount, CreateTime });
            dgv_Main.Location = new Point(5, 73);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.ReadOnly = true;
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Main.Size = new Size(1142, 613);
            dgv_Main.TabIndex = 1;
            dgv_Main.CellMouseDoubleClick += dgv_Main_CellMouseDoubleClick;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "订单ID";
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Visible = false;
            // 
            // OrderNo
            // 
            OrderNo.DataPropertyName = "OrderNo";
            OrderNo.HeaderText = "订单编号";
            OrderNo.Name = "OrderNo";
            OrderNo.ReadOnly = true;
            // 
            // CustomerOrderNo
            // 
            CustomerOrderNo.DataPropertyName = "CustomerOrderNo";
            CustomerOrderNo.HeaderText = "客户订单号";
            CustomerOrderNo.Name = "CustomerOrderNo";
            CustomerOrderNo.ReadOnly = true;
            // 
            // PurchaseOrgName
            // 
            PurchaseOrgName.DataPropertyName = "PurchaseOrgName";
            PurchaseOrgName.HeaderText = "采购方";
            PurchaseOrgName.Name = "PurchaseOrgName";
            PurchaseOrgName.ReadOnly = true;
            // 
            // SaleOrgName
            // 
            SaleOrgName.DataPropertyName = "SaleOrgName";
            SaleOrgName.HeaderText = "销售方";
            SaleOrgName.Name = "SaleOrgName";
            SaleOrgName.ReadOnly = true;
            // 
            // BrandName
            // 
            BrandName.DataPropertyName = "BrandName";
            BrandName.HeaderText = "品牌";
            BrandName.Name = "BrandName";
            BrandName.ReadOnly = true;
            // 
            // PersonInChargeUser
            // 
            PersonInChargeUser.DataPropertyName = "PersonInChargeUser";
            PersonInChargeUser.HeaderText = "担当人";
            PersonInChargeUser.Name = "PersonInChargeUser";
            PersonInChargeUser.ReadOnly = true;
            // 
            // OrderCurrencyCode
            // 
            OrderCurrencyCode.DataPropertyName = "OrderCurrencyCode";
            OrderCurrencyCode.HeaderText = "货币";
            OrderCurrencyCode.Name = "OrderCurrencyCode";
            OrderCurrencyCode.ReadOnly = true;
            // 
            // TotalNum
            // 
            TotalNum.DataPropertyName = "TotalNum";
            TotalNum.HeaderText = "总数";
            TotalNum.Name = "TotalNum";
            TotalNum.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "总金额";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // CreateTime
            // 
            CreateTime.DataPropertyName = "CreateTime";
            CreateTime.HeaderText = "创建时间";
            CreateTime.Name = "CreateTime";
            CreateTime.ReadOnly = true;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 726);
            Controls.Add(dgv_Main);
            Controls.Add(groupBox1);
            Name = "OrderListForm";
            StartPosition = FormStartPosition.CenterParent;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderNo;
        private DataGridViewTextBoxColumn CustomerOrderNo;
        private DataGridViewTextBoxColumn PurchaseOrgName;
        private DataGridViewTextBoxColumn SaleOrgName;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn PersonInChargeUser;
        private DataGridViewTextBoxColumn OrderCurrencyCode;
        private DataGridViewTextBoxColumn TotalNum;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn CreateTime;
    }
}