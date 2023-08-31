﻿namespace BlueDream.WinForm
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
            dmConnection1 = new Dm.DmConnection();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            cb_SaleOrg = new ComboBox();
            cb_PurchaseOrg = new ComboBox();
            cb_PersonInCharge = new ComboBox();
            cb_Brand = new ComboBox();
            btnj_Save = new Button();
            label8 = new Label();
            cb_CurrencyCode = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dmConnection1
            // 
            dmConnection1.ConnectionString = "schema=SYSDBA";
            dmConnection1.ForEFCore = false;
            dmConnection1.MppType = Dm.DmMppType.LOGIN_MPP_GLOBAL;
            dmConnection1.Schema = "";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(848, 401);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cb_SaleOrg);
            groupBox1.Controls.Add(cb_PurchaseOrg);
            groupBox1.Controls.Add(cb_PersonInCharge);
            groupBox1.Controls.Add(cb_Brand);
            groupBox1.Controls.Add(btnj_Save);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cb_CurrencyCode);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息";
            // 
            // cb_SaleOrg
            // 
            cb_SaleOrg.FormattingEnabled = true;
            cb_SaleOrg.Location = new Point(416, 45);
            cb_SaleOrg.Name = "cb_SaleOrg";
            cb_SaleOrg.Size = new Size(100, 25);
            cb_SaleOrg.TabIndex = 18;
            // 
            // cb_PurchaseOrg
            // 
            cb_PurchaseOrg.FormattingEnabled = true;
            cb_PurchaseOrg.Location = new Point(416, 16);
            cb_PurchaseOrg.Name = "cb_PurchaseOrg";
            cb_PurchaseOrg.Size = new Size(100, 25);
            cb_PurchaseOrg.TabIndex = 17;
            // 
            // cb_PersonInCharge
            // 
            cb_PersonInCharge.FormattingEnabled = true;
            cb_PersonInCharge.Location = new Point(238, 45);
            cb_PersonInCharge.Name = "cb_PersonInCharge";
            cb_PersonInCharge.Size = new Size(100, 25);
            cb_PersonInCharge.TabIndex = 16;
            // 
            // cb_Brand
            // 
            cb_Brand.FormattingEnabled = true;
            cb_Brand.Location = new Point(238, 16);
            cb_Brand.Name = "cb_Brand";
            cb_Brand.Size = new Size(100, 25);
            cb_Brand.TabIndex = 15;
            cb_Brand.TextUpdate += cb_Brand_TextUpdate;
            // 
            // btnj_Save
            // 
            btnj_Save.Location = new Point(666, 16);
            btnj_Save.Name = "btnj_Save";
            btnj_Save.Size = new Size(100, 23);
            btnj_Save.TabIndex = 14;
            btnj_Save.Text = "保  存";
            btnj_Save.UseVisualStyleBackColor = true;
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
            cb_CurrencyCode.FormattingEnabled = true;
            cb_CurrencyCode.Location = new Point(560, 16);
            cb_CurrencyCode.Name = "cb_CurrencyCode";
            cb_CurrencyCode.Size = new Size(100, 25);
            cb_CurrencyCode.TabIndex = 12;
            cb_CurrencyCode.TextUpdate += comboBox1_TextUpdate;
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
            // textBox3
            // 
            textBox3.Location = new Point(89, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
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
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(2, 497);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(848, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 602);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "OrderEditForm";
            Text = "PurchaseOrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Dm.DmConnection dmConnection1;
        private GroupBox groupBox1;
        private Button btn_Search;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_Add;
        private Label label8;
        private ComboBox cb_CurrencyCode;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button btnj_Save;
        private ComboBox cb_SaleOrg;
        private ComboBox cb_PurchaseOrg;
        private ComboBox cb_PersonInCharge;
        private ComboBox cb_Brand;
    }
}