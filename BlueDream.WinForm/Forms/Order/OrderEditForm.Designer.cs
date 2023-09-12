namespace BlueDream.WinForm
{
    partial class OrderEditForm
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
            btn_DelItem = new Button();
            btn_AddItem = new Button();
            txt_PersonInCharge = new TextBox();
            txt_Sale_Org = new TextBox();
            txt_Purchase_Org = new TextBox();
            txt_Brand = new TextBox();
            btn_Save = new Button();
            label8 = new Label();
            cb_CurrencyCode = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_CustomerOrderNo = new TextBox();
            txt_OrderNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_Remark = new RichTextBox();
            dgv_Main = new DataGridView();
            OrderItemID = new DataGridViewTextBoxColumn();
            OrderID = new DataGridViewTextBoxColumn();
            StyleNo = new DataGridViewTextBoxColumn();
            DeliveryDate = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Composition = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_DelItem);
            groupBox1.Controls.Add(btn_AddItem);
            groupBox1.Controls.Add(txt_PersonInCharge);
            groupBox1.Controls.Add(txt_Sale_Org);
            groupBox1.Controls.Add(txt_Purchase_Org);
            groupBox1.Controls.Add(txt_Brand);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cb_CurrencyCode);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_CustomerOrderNo);
            groupBox1.Controls.Add(txt_OrderNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(933, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息";
            // 
            // btn_DelItem
            // 
            btn_DelItem.Location = new Point(666, 45);
            btn_DelItem.Name = "btn_DelItem";
            btn_DelItem.Size = new Size(100, 23);
            btn_DelItem.TabIndex = 24;
            btn_DelItem.Text = "删除子项";
            btn_DelItem.UseVisualStyleBackColor = true;
            btn_DelItem.Click += btn_DelItem_Click;
            // 
            // btn_AddItem
            // 
            btn_AddItem.Location = new Point(666, 16);
            btn_AddItem.Name = "btn_AddItem";
            btn_AddItem.Size = new Size(100, 23);
            btn_AddItem.TabIndex = 23;
            btn_AddItem.Text = "添加子项";
            btn_AddItem.UseVisualStyleBackColor = true;
            btn_AddItem.Click += btn_AddItem_Click;
            // 
            // txt_PersonInCharge
            // 
            txt_PersonInCharge.BackColor = SystemColors.Window;
            txt_PersonInCharge.Location = new Point(238, 45);
            txt_PersonInCharge.Name = "txt_PersonInCharge";
            txt_PersonInCharge.ReadOnly = true;
            txt_PersonInCharge.Size = new Size(100, 23);
            txt_PersonInCharge.TabIndex = 22;
            txt_PersonInCharge.Click += txt_PersonInCharge_Click;
            // 
            // txt_Sale_Org
            // 
            txt_Sale_Org.BackColor = SystemColors.Window;
            txt_Sale_Org.Location = new Point(416, 45);
            txt_Sale_Org.Name = "txt_Sale_Org";
            txt_Sale_Org.ReadOnly = true;
            txt_Sale_Org.Size = new Size(100, 23);
            txt_Sale_Org.TabIndex = 21;
            txt_Sale_Org.Click += txt_Sale_Org_Click;
            // 
            // txt_Purchase_Org
            // 
            txt_Purchase_Org.BackColor = SystemColors.Window;
            txt_Purchase_Org.Location = new Point(416, 16);
            txt_Purchase_Org.Name = "txt_Purchase_Org";
            txt_Purchase_Org.ReadOnly = true;
            txt_Purchase_Org.Size = new Size(100, 23);
            txt_Purchase_Org.TabIndex = 20;
            txt_Purchase_Org.Click += txt_Purchase_Org_Click;
            // 
            // txt_Brand
            // 
            txt_Brand.BackColor = SystemColors.Window;
            txt_Brand.Location = new Point(238, 16);
            txt_Brand.Name = "txt_Brand";
            txt_Brand.ReadOnly = true;
            txt_Brand.Size = new Size(100, 23);
            txt_Brand.TabIndex = 19;
            txt_Brand.Click += txt_Brand_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(772, 16);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(100, 23);
            btn_Save.TabIndex = 14;
            btn_Save.Text = "保  存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 22);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 13;
            label8.Text = "货币";
            // 
            // cb_CurrencyCode
            // 
            cb_CurrencyCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_CurrencyCode.FormattingEnabled = true;
            cb_CurrencyCode.Location = new Point(560, 16);
            cb_CurrencyCode.Name = "cb_CurrencyCode";
            cb_CurrencyCode.Size = new Size(100, 25);
            cb_CurrencyCode.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 48);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 9;
            label6.Text = "卖方";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 19);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 8;
            label7.Text = "买方";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 48);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 5;
            label4.Text = "担当";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 19);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 4;
            label5.Text = "品牌";
            // 
            // txt_CustomerOrderNo
            // 
            txt_CustomerOrderNo.Location = new Point(89, 45);
            txt_CustomerOrderNo.Name = "txt_CustomerOrderNo";
            txt_CustomerOrderNo.Size = new Size(100, 23);
            txt_CustomerOrderNo.TabIndex = 3;
            // 
            // txt_OrderNo
            // 
            txt_OrderNo.Location = new Point(89, 16);
            txt_OrderNo.Name = "txt_OrderNo";
            txt_OrderNo.Size = new Size(100, 23);
            txt_OrderNo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 48);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "客户订单号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 0;
            label2.Text = "订单编号";
            // 
            // txt_Remark
            // 
            txt_Remark.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Remark.Location = new Point(2, 497);
            txt_Remark.Name = "txt_Remark";
            txt_Remark.Size = new Size(933, 96);
            txt_Remark.TabIndex = 2;
            txt_Remark.Text = "";
            // 
            // dgv_Main
            // 
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.BackgroundColor = SystemColors.Control;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Columns.AddRange(new DataGridViewColumn[] { OrderItemID, OrderID, StyleNo, DeliveryDate, UnitPrice, Composition });
            dgv_Main.Location = new Point(2, 90);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.ReadOnly = true;
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Main.Size = new Size(933, 401);
            dgv_Main.TabIndex = 3;
            dgv_Main.CellDoubleClick += dgv_Main_CellDoubleClick;
            // 
            // OrderItemID
            // 
            OrderItemID.DataPropertyName = "OrderItemID";
            OrderItemID.HeaderText = "订单明细ID";
            OrderItemID.Name = "OrderItemID";
            OrderItemID.ReadOnly = true;
            OrderItemID.Visible = false;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "订单ID";
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Visible = false;
            // 
            // StyleNo
            // 
            StyleNo.DataPropertyName = "StyleNo";
            StyleNo.HeaderText = "样式编码";
            StyleNo.Name = "StyleNo";
            StyleNo.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            DeliveryDate.DataPropertyName = "DeliveryDate";
            DeliveryDate.HeaderText = "交期";
            DeliveryDate.Name = "DeliveryDate";
            DeliveryDate.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "单价";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Composition
            // 
            Composition.DataPropertyName = "Composition";
            Composition.HeaderText = "材料";
            Composition.Name = "Composition";
            Composition.ReadOnly = true;
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 602);
            Controls.Add(dgv_Main);
            Controls.Add(txt_Remark);
            Controls.Add(groupBox1);
            Name = "OrderEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PurchaseOrderForm";
            Click += OrderEditForm_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;

        private Label label8;
        private ComboBox cb_CurrencyCode;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox txt_CustomerOrderNo;
        private TextBox txt_OrderNo;
        private Label label3;
        private Label label2;
        private RichTextBox txt_Remark;
        private Button btn_Save;
        private TextBox txt_Sale_Org;
        private TextBox txt_Purchase_Org;
        private TextBox txt_Brand;
        private TextBox txt_PersonInCharge;
        private Button btn_AddItem;
        private DataGridView dgv_Main;
        private DataGridViewTextBoxColumn OrderItemID;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn StyleNo;
        private DataGridViewTextBoxColumn DeliveryDate;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Composition;
        private Button btn_DelItem;
    }
}