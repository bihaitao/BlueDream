namespace BlueDream.WinForm
{
    partial class OrderItemForm
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
            groupBox1 = new GroupBox();
            btn_Save = new Button();
            label2 = new Label();
            txt_Size = new TextBox();
            btn_Gen = new Button();
            txt_Color = new TextBox();
            label1 = new Label();
            dgv_Main = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // dmConnection1
            // 
            dmConnection1.ConnectionString = "schema=SYSDBA";
            dmConnection1.ForEFCore = false;
            dmConnection1.MppType = Dm.DmMppType.LOGIN_MPP_GLOBAL;
            dmConnection1.Schema = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Size);
            groupBox1.Controls.Add(btn_Gen);
            groupBox1.Controls.Add(txt_Color);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息";
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(763, 26);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 61);
            btn_Save.TabIndex = 6;
            btn_Save.Text = "保  存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 5;
            label2.Text = "尺    码：";
            // 
            // txt_Size
            // 
            txt_Size.Location = new Point(77, 64);
            txt_Size.Name = "txt_Size";
            txt_Size.Size = new Size(599, 23);
            txt_Size.TabIndex = 4;
            // 
            // btn_Gen
            // 
            btn_Gen.Location = new Point(682, 26);
            btn_Gen.Name = "btn_Gen";
            btn_Gen.Size = new Size(75, 61);
            btn_Gen.TabIndex = 3;
            btn_Gen.Text = "生  成";
            btn_Gen.UseVisualStyleBackColor = true;
            btn_Gen.Click += btn_Gen_Click;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(77, 26);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(599, 23);
            txt_Color.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "颜    色：";
            // 
            // dgv_Main
            // 
            dgv_Main.AllowUserToAddRows = false;
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.BackgroundColor = SystemColors.Control;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_Main.Location = new Point(2, 117);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Main.Size = new Size(848, 484);
            dgv_Main.TabIndex = 1;
            // 
            // OrderItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 602);
            Controls.Add(dgv_Main);
            Controls.Add(groupBox1);
            Name = "OrderItemForm";
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
        private TextBox txt_Color;
        private Label label1;
        private Button btn_Gen;
        private TextBox txt_Size;
        private Label label2;
        private DataGridView dgv_Main;
        private Button btn_Save;
    }
}