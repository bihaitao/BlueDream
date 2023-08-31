namespace BlueDream.WinForm.Controls
{
    partial class UC_Pager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Main = new DataGridView();
            btn_First = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // dgv_Main
            // 
            dgv_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Location = new Point(0, 0);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.Size = new Size(672, 547);
            dgv_Main.TabIndex = 0;
            // 
            // btn_First
            // 
            btn_First.Location = new Point(242, 553);
            btn_First.Name = "btn_First";
            btn_First.Size = new Size(61, 23);
            btn_First.TabIndex = 1;
            btn_First.Text = "首  页";
            btn_First.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(309, 553);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 2;
            button1.Text = "上一页";
            button1.UseVisualStyleBackColor = true;
            // 
            // UC_Pager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btn_First);
            Controls.Add(dgv_Main);
            Name = "UC_Pager";
            Size = new Size(675, 585);
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Main;
        private Button btn_First;
        private Button button1;
    }
}
