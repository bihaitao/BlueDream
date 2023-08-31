namespace BlueDream.WinForm.Controls
{
    partial class SuperGridView
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
            label1 = new Label();
            label3 = new Label();
            lblCount = new Label();
            panel1 = new Panel();
            btnBegin = new Button();
            btnPre = new Button();
            btnNext = new Button();
            btnEnd = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 575);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 11;
            label1.Text = "共";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(207, 575);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 12;
            label3.Text = "条";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("宋体", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.Location = new Point(131, 575);
            lblCount.Margin = new Padding(4, 0, 4, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(70, 15);
            lblCount.TabIndex = 13;
            lblCount.Text = "1545454";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(240, 573);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 21);
            panel1.TabIndex = 10;
            // 
            // btnBegin
            // 
            btnBegin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBegin.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBegin.Location = new Point(376, 569);
            btnBegin.Margin = new Padding(4);
            btnBegin.Name = "btnBegin";
            btnBegin.Size = new Size(94, 27);
            btnBegin.TabIndex = 6;
            btnBegin.Text = "首页";
            btnBegin.UseVisualStyleBackColor = true;
            // 
            // btnPre
            // 
            btnPre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPre.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnPre.Location = new Point(478, 569);
            btnPre.Margin = new Padding(4);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(94, 27);
            btnPre.TabIndex = 7;
            btnPre.Text = "上一页";
            btnPre.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(580, 569);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 27);
            btnNext.TabIndex = 8;
            btnNext.Text = "下一页";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            btnEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnd.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnd.Location = new Point(682, 569);
            btnEnd.Margin = new Padding(4);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 27);
            btnEnd.TabIndex = 9;
            btnEnd.Text = "末页";
            btnEnd.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(4, 0);
            dgv.Margin = new Padding(4);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 23;
            dgv.Size = new Size(792, 540);
            dgv.TabIndex = 0;
            // 
            // SuperGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblCount);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEnd);
            Controls.Add(btnNext);
            Controls.Add(btnPre);
            Controls.Add(btnBegin);
            Controls.Add(dgv);
            Margin = new Padding(4);
            Name = "SuperGridView";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblCount;
        private Panel panel1;
        private Button btnBegin;
        private Button btnPre;
        private Button btnNext;
        private Button btnEnd;
        private DataGridView dgv;
    }
}
