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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 90);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "样式编码";
            // 
            // txt_StyleNo
            // 
            txt_StyleNo.Location = new Point(134, 87);
            txt_StyleNo.Name = "txt_StyleNo";
            txt_StyleNo.Size = new Size(203, 23);
            txt_StyleNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 130);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "交货日期";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(72, 256);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(124, 23);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "取  消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(202, 256);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(124, 23);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "保存并添加下一个";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dtp_DeliveryDate
            // 
            dtp_DeliveryDate.Location = new Point(134, 125);
            dtp_DeliveryDate.Name = "dtp_DeliveryDate";
            dtp_DeliveryDate.Size = new Size(203, 23);
            dtp_DeliveryDate.TabIndex = 6;
            // 
            // txt_UnitPrice
            // 
            txt_UnitPrice.Location = new Point(134, 165);
            txt_UnitPrice.Name = "txt_UnitPrice";
            txt_UnitPrice.Size = new Size(203, 23);
            txt_UnitPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 168);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 7;
            label3.Text = "单    价";
            // 
            // txt_Composition
            // 
            txt_Composition.Location = new Point(134, 206);
            txt_Composition.Name = "txt_Composition";
            txt_Composition.Size = new Size(203, 23);
            txt_Composition.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 209);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 9;
            label4.Text = "面料成分";
            // 
            // txt_ItemIndex
            // 
            txt_ItemIndex.Location = new Point(134, 47);
            txt_ItemIndex.Name = "txt_ItemIndex";
            txt_ItemIndex.Size = new Size(203, 23);
            txt_ItemIndex.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 50);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 11;
            label5.Text = "排列顺序";
            // 
            // OrderItemEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(txt_ItemIndex);
            Controls.Add(label5);
            Controls.Add(txt_Composition);
            Controls.Add(label4);
            Controls.Add(txt_UnitPrice);
            Controls.Add(label3);
            Controls.Add(dtp_DeliveryDate);
            Controls.Add(btn_Save);
            Controls.Add(btn_Cancel);
            Controls.Add(label2);
            Controls.Add(txt_StyleNo);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(450, 350);
            MinimizeBox = false;
            MinimumSize = new Size(450, 350);
            Name = "OrderItemEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderItemEditForm";
            Load += OrderItemEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}