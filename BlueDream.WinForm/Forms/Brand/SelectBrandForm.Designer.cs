namespace BlueDream.WinForm
{
    partial class SelectBrandForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btn_Select = new Button();
            btn_Search = new Button();
            txt_Search = new TextBox();
            label1 = new Label();
            dgv_Main = new DataGridView();
            dgv_Main_Pager = new PagerLib.PagerControl();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_Select);
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 55);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "信息";
            // 
            // btn_Select
            // 
            btn_Select.Location = new Point(387, 16);
            btn_Select.Name = "btn_Select";
            btn_Select.Size = new Size(75, 23);
            btn_Select.TabIndex = 3;
            btn_Select.Text = "选    择";
            btn_Select.UseVisualStyleBackColor = true;
            btn_Select.Click += btn_Select_Click;
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
            dgv_Main.BackgroundColor = SystemColors.Control;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Location = new Point(4, 73);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.ReadOnly = true;
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.Size = new Size(575, 326);
            dgv_Main.TabIndex = 2;
            // 
            // dgv_Main_Pager
            // 
            dgv_Main_Pager.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main_Pager.DataCount = 0;
            dgv_Main_Pager.Location = new Point(3, 406);
            dgv_Main_Pager.Margin = new Padding(4);
            dgv_Main_Pager.Name = "dgv_Main_Pager";
            dgv_Main_Pager.PageCount = 0;
            dgv_Main_Pager.PageIndex = 1;
            dgv_Main_Pager.PageSize = 5;
            dgv_Main_Pager.Size = new Size(575, 29);
            dgv_Main_Pager.TabIndex = 3;
            // 
            // SelectBrandForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 441);
            Controls.Add(dgv_Main_Pager);
            Controls.Add(dgv_Main);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(600, 480);
            MinimizeBox = false;
            MinimumSize = new Size(600, 480);
            Name = "SelectBrandForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "品牌";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Select;
        private Button btn_Search;
        private TextBox txt_Search;
        private Label label1;
        private DataGridView dgv_Main;
        private PagerLib.PagerControl dgv_Main_Pager;
    }
}