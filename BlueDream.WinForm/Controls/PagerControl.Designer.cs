namespace PagerLib
{
    partial class PagerControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagerControl));
            bindingNavigator = new BindingNavigator(components);
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorSeparator = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            txtCurrentPage = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            lblCountPage = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            ComboBoxRowsPerPage = new ToolStripComboBox();
            toolStripLabel6 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel8 = new ToolStripLabel();
            toolStripLabel7 = new ToolStripLabel();
            lblCountRecord = new ToolStripLabel();
            toolStripLabel9 = new ToolStripLabel();
            toolStripLabel10 = new ToolStripLabel();
            bindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingNavigator).BeginInit();
            bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // bindingNavigator
            // 
            bindingNavigator.AddNewItem = null;
            bindingNavigator.Anchor = AnchorStyles.Right;
            bindingNavigator.CountItem = null;
            bindingNavigator.DeleteItem = null;
            bindingNavigator.Dock = DockStyle.None;
            bindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, toolStripLabel1, txtCurrentPage, toolStripLabel2, toolStripLabel3, lblCountPage, toolStripLabel5, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, toolStripLabel4, ComboBoxRowsPerPage, toolStripLabel6, toolStripSeparator1, toolStripLabel8, toolStripLabel7, lblCountRecord, toolStripLabel9, toolStripLabel10 });
            bindingNavigator.Location = new Point(0, 0);
            bindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator.Name = "bindingNavigator";
            bindingNavigator.PositionItem = null;
            bindingNavigator.Size = new Size(471, 28);
            bindingNavigator.TabIndex = 1;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new Size(23, 25);
            bindingNavigatorMoveFirstItem.Text = "移到第一页";
            bindingNavigatorMoveFirstItem.Click += bindingNavigatorMoveFirstItem_Click;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new Size(23, 25);
            bindingNavigatorMovePreviousItem.Text = "移到上一页";
            bindingNavigatorMovePreviousItem.Click += bindingNavigatorMovePreviousItem_Click;
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 28);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(20, 25);
            toolStripLabel1.Text = "第";
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.Margin = new Padding(0, 1, 0, 2);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(28, 25);
            txtCurrentPage.TextChanged += txtCurrentPage_TextChanged;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(20, 25);
            toolStripLabel2.Text = "页";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(20, 25);
            toolStripLabel3.Text = "共";
            // 
            // lblCountPage
            // 
            lblCountPage.Name = "lblCountPage";
            lblCountPage.Size = new Size(23, 25);
            lblCountPage.Text = "{0}";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(20, 25);
            toolStripLabel5.Text = "页";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new Size(23, 25);
            bindingNavigatorMoveNextItem.Text = "移到下一页";
            bindingNavigatorMoveNextItem.Click += bindingNavigatorMoveNextItem_Click;
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new Size(23, 25);
            bindingNavigatorMoveLastItem.Text = "移到最后一页";
            bindingNavigatorMoveLastItem.Click += bindingNavigatorMoveLastItem_Click;
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 28);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(59, 25);
            toolStripLabel4.Text = "每页显示:";
            // 
            // ComboBoxRowsPerPage
            // 
            ComboBoxRowsPerPage.AutoSize = false;
            ComboBoxRowsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRowsPerPage.DropDownWidth = 40;
            ComboBoxRowsPerPage.Items.AddRange(new object[] { "5", "10", "15", "30", "50", "100" });
            ComboBoxRowsPerPage.Margin = new Padding(0, 1, 0, 2);
            ComboBoxRowsPerPage.Name = "ComboBoxRowsPerPage";
            ComboBoxRowsPerPage.Size = new Size(46, 25);
            ComboBoxRowsPerPage.SelectedIndexChanged += ComboBoxRowsPerPage_SelectedIndexChanged;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(20, 25);
            toolStripLabel6.Text = "条";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(20, 25);
            toolStripLabel8.Text = "共";
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(0, 25);
            // 
            // lblCountRecord
            // 
            lblCountRecord.Name = "lblCountRecord";
            lblCountRecord.Size = new Size(23, 25);
            lblCountRecord.Text = "{1}";
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(20, 25);
            toolStripLabel9.Text = "条";
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(24, 25);
            toolStripLabel10.Text = "    ";
            // 
            // PagerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bindingNavigator);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PagerControl";
            Size = new Size(472, 29);
            ((System.ComponentModel.ISupportInitialize)bindingNavigator).EndInit();
            bindingNavigator.ResumeLayout(false);
            bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblCountPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox ComboBoxRowsPerPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel lblCountRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
    }
}
