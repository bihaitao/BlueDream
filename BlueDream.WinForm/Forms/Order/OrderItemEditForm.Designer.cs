namespace BlueDream.WinForm
{
    partial class OrderItemEditForm
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
            label1 = new Label();
            txt_StyleNo = new TextBox();
            label2 = new Label();
            btn_Cancel = new Button();
            btn_Save = new Button();
            dtp_DeliveryDate = new DateTimePicker();
            txt_UnitPrice = new TextBox();
            label3 = new Label();
            txt_Composition = new TextBox();
            label4 = new Label();
            txt_ItemIndex = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_Size = new TextBox();
            btn_Gen = new Button();
            txt_Color = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            dgv_Main = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "样式编码";
            // 
            // txt_StyleNo
            // 
            txt_StyleNo.Location = new Point(85, 22);
            txt_StyleNo.Name = "txt_StyleNo";
            txt_StyleNo.Size = new Size(284, 23);
            txt_StyleNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 54);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "交货日期";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(778, 50);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(124, 23);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "取  消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(778, 19);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(124, 23);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "保存并添加下一个";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dtp_DeliveryDate
            // 
            dtp_DeliveryDate.Location = new Point(332, 51);
            dtp_DeliveryDate.Name = "dtp_DeliveryDate";
            dtp_DeliveryDate.Size = new Size(179, 23);
            dtp_DeliveryDate.TabIndex = 6;
            // 
            // txt_UnitPrice
            // 
            txt_UnitPrice.Location = new Point(85, 50);
            txt_UnitPrice.Name = "txt_UnitPrice";
            txt_UnitPrice.Size = new Size(179, 23);
            txt_UnitPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 53);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 7;
            label3.Text = "单    价";
            // 
            // txt_Composition
            // 
            txt_Composition.Location = new Point(474, 22);
            txt_Composition.Name = "txt_Composition";
            txt_Composition.Size = new Size(284, 23);
            txt_Composition.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 25);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 9;
            label4.Text = "面料成分";
            // 
            // txt_ItemIndex
            // 
            txt_ItemIndex.Location = new Point(579, 51);
            txt_ItemIndex.Name = "txt_ItemIndex";
            txt_ItemIndex.Size = new Size(179, 23);
            txt_ItemIndex.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 56);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 11;
            label5.Text = "排列顺序";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 109);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 17;
            label6.Text = "尺    码：";
            // 
            // txt_Size
            // 
            txt_Size.Location = new Point(85, 109);
            txt_Size.Name = "txt_Size";
            txt_Size.Size = new Size(673, 23);
            txt_Size.TabIndex = 16;
            // 
            // btn_Gen
            // 
            btn_Gen.Location = new Point(778, 80);
            btn_Gen.Name = "btn_Gen";
            btn_Gen.Size = new Size(124, 52);
            btn_Gen.TabIndex = 15;
            btn_Gen.Text = "生  成";
            btn_Gen.UseVisualStyleBackColor = true;
            btn_Gen.Click += btn_Gen_Click;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(85, 80);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(673, 23);
            txt_Color.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 83);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 13;
            label7.Text = "颜    色：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_DeliveryDate);
            groupBox1.Controls.Add(txt_ItemIndex);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_UnitPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_StyleNo);
            groupBox1.Controls.Add(txt_Size);
            groupBox1.Controls.Add(txt_Composition);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_Gen);
            groupBox1.Controls.Add(txt_Color);
            groupBox1.Controls.Add(btn_Cancel);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 151);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // dgv_Main
            // 
            dgv_Main.AllowUserToAddRows = false;
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.BackgroundColor = SystemColors.Control;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_Main.Location = new Point(12, 164);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Main.Size = new Size(920, 553);
            dgv_Main.TabIndex = 19;
            // 
            // OrderItemEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 729);
            Controls.Add(dgv_Main);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(960, 768);
            MinimizeBox = false;
            MinimumSize = new Size(960, 768);
            Name = "OrderItemEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderItemEditForm";
            Load += OrderItemEditForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_StyleNo;
        private Label label2;
        private Button btn_Cancel;
        private Button btn_Save;
        private DateTimePicker dtp_DeliveryDate;
        private TextBox txt_UnitPrice;
        private Label label3;
        private TextBox txt_Composition;
        private Label label4;
        private TextBox txt_ItemIndex;
        private Label label5;
        private Label label6;
        private TextBox txt_Size;
        private Button btn_Gen;
        private TextBox txt_Color;
        private Label label7;
        private GroupBox groupBox1;
        private DataGridView dgv_Main;
    }
}