namespace PagerLib
{
    /// <summary>
    /// 分页控件
    /// </summary>
    public partial class PagerControl : UserControl
    {
        #region property
        private int m_LastPage;
        /// <summary>
        /// 获取与设置每页记录数 
        /// </summary>
        private int m_PageSize;

        public int PageSize
        {
            get
            {
                if (m_PageSize <= 0)
                {
                    return 5;
                }
                return m_PageSize;
            }
            set
            {
                if (m_PageSize == value)
                {
                    return;
                }
                m_PageSize = value;
                this.ComboBoxRowsPerPage.Text = m_PageSize.ToString();
                CalcPageValue();
            }
        }
        /// <summary>
        /// 获取总页数
        /// </summary>
        private int m_PageCount;

        public int PageCount
        {
            get { return m_PageCount; }
            set
            {
                if (m_PageCount == value)
                {
                    return;
                }
                m_PageCount = value;
                CalcPageValue();
            }
        }
        /// <summary>
        /// 获取与设置当前页数
        /// </summary>     
        private int m_PageIndex;

        public int PageIndex
        {
            get
            {
                return m_PageIndex;
            }
            set
            {
                if (m_PageIndex == value)
                {
                    return;
                }
                m_PageIndex = value;
                this.txtCurrentPage.Text = m_PageIndex.ToString();
            }
        }
        /// <summary>
        /// 总记录数
        /// </summary>     
        private int m_DataCount;

        public int DataCount
        {
            get { return m_DataCount; }
            set
            {
                if (m_DataCount == value)
                {
                    return;
                }
                m_DataCount = value;
                CalcPageValue();
            }
        }
        #endregion

        #region ctor
        ///<summary>
        /// 构造函数
        /// </summary>
        public PagerControl()
        {
            InitializeComponent();
            //this.BackColorChanged += new EventHandler(PagerControl_BackColorChanged);
            //this.BackColor = Color.FromArgb(194, 217, 247);
            //this.bindingNavigator.BackColor = this.BackColor;
        }
        #endregion

        #region method
        /// <summary>
        /// 计算控件的各属性值
        /// </summary>
        private void CalcPageValue()
        {
            //每页显示的记录数为空，则返回不计算
            if (m_PageSize <= 0)
            {
                return;
            }
            //计算。如果总记录数与每页显示的记录数可以整除，则总页数即为总记录数与每页显示的记录数的除数
            if (m_DataCount % m_PageSize == 0)
            {
                m_PageCount = (int)(m_DataCount / m_PageSize);
            }
            //否则总页数为总记录数与每页显示的记录数的除数加1
            else
            {
                m_PageCount = (int)(m_DataCount / m_PageSize) + 1;
            }
            //默认设置当前页为第1页
            this.PageIndex = 1;
            //更新按钮可用性和属性值
            UpdateAllValue();
        }
        /// <summary>
        /// 更新按钮可用性和属性值
        /// </summary>
        private void UpdateAllValue()
        {
            //默认将按钮均可用
            this.bindingNavigatorMoveFirstItem.Enabled = true;
            this.bindingNavigatorMovePreviousItem.Enabled = true;
            this.bindingNavigatorMoveLastItem.Enabled = true;
            this.bindingNavigatorMoveNextItem.Enabled = true;
            //如果当前页不大于1，则前一页与第一页按钮不可用
            if (this.PageIndex <= 1)
            {
                this.bindingNavigatorMoveFirstItem.Enabled = false;
                this.bindingNavigatorMovePreviousItem.Enabled = false;
            }
            //如果当前页不小于总页数，则后一页与最后页按钮不可用
            if (this.PageIndex >= this.PageCount)
            {
                this.bindingNavigatorMoveLastItem.Enabled = false;
                this.bindingNavigatorMoveNextItem.Enabled = false;
            }
            //更新界面显示的属性值
            this.txtCurrentPage.Text = this.PageIndex.ToString();
            m_LastPage = Convert.ToInt32(this.txtCurrentPage.Text);
            this.lblCountPage.Text = this.PageCount.ToString();
            this.ComboBoxRowsPerPage.Text = this.PageSize.ToString();
            this.lblCountRecord.Text = this.DataCount.ToString();
            //触发事件，通知外部注册更新当前显示页数记录等信息。
            OnPageChange();
            //OnPageChange(this);
        }
        #endregion

        #region events
        /// <summary>
        /// 第一条
        /// </summary>
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.PageIndex = 1;
            //UpdateAllValue();
        }
        /// <summary>
        /// 上一条
        /// </summary>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.PageIndex--;
            //UpdateAllValue();
        }
        /// <summary>
        /// 下一条
        /// </summary>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.PageIndex++;
            //UpdateAllValue();
        }
        /// <summary>
        /// 最后条
        /// </summary>
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.PageIndex = PageCount;
            //UpdateAllValue();
        }
        /// <summary>
        /// 每页显示几条改变事件
        /// </summary>
        private void ComboBoxRowsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PageSize = Convert.ToInt32(this.ComboBoxRowsPerPage.SelectedItem.ToString());
        }

        /// <summary>
        /// 当前页数改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCurrentPage_TextChanged(object sender, EventArgs e)
        {
            if (this.bindingNavigator.Enabled == false)
            {
                return;
            }
            int newPage;
            if (!Int32.TryParse(this.txtCurrentPage.Text, out newPage))
            {
                this.txtCurrentPage.Text = m_LastPage.ToString();
                return;
            }
            if (PageCount == 0)
            {
                return;
            }
            if (newPage > this.PageCount || newPage < 0)
            {
                this.txtCurrentPage.Text = m_LastPage.ToString();
                return;
            }
            this.m_PageIndex = newPage;
            UpdateAllValue();
        }
        ///// <summary>
        ///// 分页控件背景颜色随着母窗体的背景颜色变化而变化
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void PagerControl_BackColorChanged(object sender, EventArgs e)
        //{
        //    this.bindingNavigator.BackColor = this.BackColor;
        //}
        #endregion

        #region 外部事件注册
        /// <summary>
        /// 无参事件，需要用户自己知道是哪个对象触发该事件
        /// </summary>
        public event Action PageChange;
        /// <summary>
        /// 触发无对象事件
        /// </summary>
        private void OnPageChange()
        {
            Action temp = Interlocked.CompareExchange(ref PageChange, null, null);
            if (temp != null)
            {
                temp();
            }
        }

        ///// <summary>
        ///// 有对象事件，可以得到触发该事件的分页控件对象
        ///// </summary>
        //public event Action<object> PageChangeWithObject;
        ///// <summary>
        ///// 触发有对象事件
        ///// </summary>
        ///// <param name="sender">对象</param>
        //private void OnPageChange(PagerControl sender)
        //{
        //    Action<object> temp = Interlocked.CompareExchange(ref PageChangeWithObject, null, null);
        //    if (temp != null)
        //    {
        //        temp(sender);
        //    }
        //}
        #endregion

         
    }
}
