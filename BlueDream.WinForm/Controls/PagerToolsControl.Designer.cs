namespace BlueDream.WinForm.Controls
{
    partial class PagerToolsControl
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
            toolStrip_main = new ToolStrip();
            tbtn_first = new ToolStripButton();
            tbtn_up = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ttxt_current = new ToolStripTextBox();
            tlab_total = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tbtn_next = new ToolStripButton();
            tbtn_last = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            tcomb_current = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tcom_num = new ToolStripComboBox();
            toolStripLabel4 = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            tbtn_refresh = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tlab_datacount = new ToolStripLabel();
            toolStrip_main.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip_main
            // 
            toolStrip_main.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_main.Items.AddRange(new ToolStripItem[] { tbtn_first, tbtn_up, toolStripSeparator1, ttxt_current, tlab_total, toolStripSeparator2, tbtn_next, tbtn_last, toolStripSeparator3, toolStripLabel2, tcomb_current, toolStripLabel3, toolStripSeparator4, toolStripLabel1, tcom_num, toolStripLabel4, toolStripSeparator5, tbtn_refresh, toolStripSeparator6, tlab_datacount });
            toolStrip_main.Location = new Point(0, 0);
            toolStrip_main.Name = "toolStrip_main";
            toolStrip_main.Size = new Size(831, 25);
            toolStrip_main.TabIndex = 1;
            toolStrip_main.Text = "toolStrip1";
            // 
            // tbtn_first
            // 
            tbtn_first.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtn_first.Image = Properties.Resources._3;
            tbtn_first.ImageTransparentColor = Color.Magenta;
            tbtn_first.Name = "tbtn_first";
            tbtn_first.Size = new Size(23, 22);
            tbtn_first.Text = "第一页";
            tbtn_first.Click += tbtn_first_Click;
            // 
            // tbtn_up
            // 
            tbtn_up.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtn_up.Image = Properties.Resources._4;
            tbtn_up.ImageTransparentColor = Color.Magenta;
            tbtn_up.Name = "tbtn_up";
            tbtn_up.Size = new Size(23, 22);
            tbtn_up.Text = "上一页";
            tbtn_up.Click += tbtn_up_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ttxt_current
            // 
            ttxt_current.Name = "ttxt_current";
            ttxt_current.Size = new Size(34, 25);
            ttxt_current.TextBoxTextAlign = HorizontalAlignment.Center;
            ttxt_current.ToolTipText = "当前页";
            ttxt_current.KeyPress += ttxt_current_KeyPress;
            // 
            // tlab_total
            // 
            tlab_total.Name = "tlab_total";
            tlab_total.Size = new Size(0, 22);
            tlab_total.Tag = "/{0}";
            tlab_total.ToolTipText = "总页数";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tbtn_next
            // 
            tbtn_next.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtn_next.Image = Properties.Resources._1;
            tbtn_next.ImageTransparentColor = Color.Magenta;
            tbtn_next.Name = "tbtn_next";
            tbtn_next.Size = new Size(23, 22);
            tbtn_next.Text = "下一页";
            tbtn_next.Click += tbtn_next_Click;
            // 
            // tbtn_last
            // 
            tbtn_last.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtn_last.Image = Properties.Resources._2;
            tbtn_last.ImageTransparentColor = Color.Magenta;
            tbtn_last.Name = "tbtn_last";
            tbtn_last.Size = new Size(23, 22);
            tbtn_last.Text = "最后一页";
            tbtn_last.Click += tbtn_last_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(20, 22);
            toolStripLabel2.Text = "第";
            // 
            // tcomb_current
            // 
            tcomb_current.DropDownStyle = ComboBoxStyle.DropDownList;
            tcomb_current.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tcomb_current.Name = "tcomb_current";
            tcomb_current.Size = new Size(87, 25);
            tcomb_current.ToolTipText = "当前页";
            tcomb_current.SelectedIndexChanged += tcomb_current_SelectedIndexChanged;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(20, 22);
            toolStripLabel3.Text = "页";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(32, 22);
            toolStripLabel1.Text = "每页";
            // 
            // tcom_num
            // 
            tcom_num.Name = "tcom_num";
            tcom_num.Size = new Size(87, 25);
            tcom_num.ToolTipText = "每页行数";
            tcom_num.SelectedIndexChanged += tcom_num_SelectedIndexChanged;
            tcom_num.KeyPress += tcom_num_KeyPress;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(20, 22);
            toolStripLabel4.Text = "行";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            toolStripSeparator5.Visible = false;
            // 
            // tbtn_refresh
            // 
            tbtn_refresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtn_refresh.ImageTransparentColor = Color.Magenta;
            tbtn_refresh.Name = "tbtn_refresh";
            tbtn_refresh.Size = new Size(23, 22);
            tbtn_refresh.Text = "toolStripButton5";
            tbtn_refresh.Visible = false;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // tlab_datacount
            // 
            tlab_datacount.Name = "tlab_datacount";
            tlab_datacount.Size = new Size(0, 22);
            // 
            // PagerToolsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip_main);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PagerToolsControl";
            Size = new Size(831, 35);
            toolStrip_main.ResumeLayout(false);
            toolStrip_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripButton tbtn_first;
        private System.Windows.Forms.ToolStripButton tbtn_up;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttxt_current;
        private System.Windows.Forms.ToolStripLabel tlab_total;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtn_next;
        private System.Windows.Forms.ToolStripButton tbtn_last;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tcomb_current;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tcom_num;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbtn_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tlab_datacount;
    }
}
