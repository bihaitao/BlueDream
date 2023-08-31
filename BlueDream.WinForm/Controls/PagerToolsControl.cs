using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BlueDream.WinForm.Controls
{
    /// <summary>
    /// 分页组件
    /// </summary>
    public partial class PagerToolsControl : UserControl
    {
        /// <summary>
        /// 当前页改变时的事件委托
        /// </summary>
        /// <param name="sender">自身</param>
        /// <param name="e">事件数据类</param>
        public delegate void OnPagerIndexChangedEventHandler(object sender, C_EventArgsClass e);

        /// <summary>
        /// 每页行数改变时的事件委托
        /// </summary>
        /// <param name="sender">自身</param>
        /// <param name="e">事件数据类</param>
        public delegate void OnPagerNumChangedEventHandler(object sender, C_EventArgsClass e);

        /// <summary>
        /// 当前页改变时发生
        /// </summary>
        public event OnPagerIndexChangedEventHandler PagerIndexChanged = null;

        /// <summary>
        /// 每页行数改变时发生
        /// </summary>
        public event OnPagerNumChangedEventHandler PagerNumChanged = null;
        
        /// <summary>
        /// 总页数
        /// </summary>
        public int Total
        {
            get { return aTotal; }
        }

        /// <summary>
        /// 数据总数
        /// </summary>
        [Description("数据总数"), Browsable(false)]
        public int DataCount
        {
            get { return aDataCount; }
            set
            {
                aDataCount = value;
                aTotal = ((aDataCount + aPagerNum - 1) / aPagerNum);
                tlab_datacount.Text = aDataCountLable.Replace("#count", aDataCount.ToString());
                UpdataTotal();
            }
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        [Description("当前页"), Browsable(false)]
        public int Current
        {
            get { return aCurrent; }
            set
            {
                if ((value < 0) || (value > aTotal))
                    throw new Exception("当前页不能小于0或大于总页数");

                aCurrent = value;
                UpdataCurrent();
            }
        }

        /// <summary>
        /// 每页行数
        /// </summary>
        [Description("每页的行数"), Browsable(false)]
        public int PagerNum
        {
            get { return aPagerNum; }
            set
            {
                aPagerNum = value;

                aIsTrigger = false;
                /*更新完每页行数，要先更新总页数，再触发相关事件*/
                aTotal = ((aDataCount + aPagerNum - 1) / aPagerNum);
                UpdataTotal();
                aIsTrigger = true;

                OnPagerNumChanged();
            }
        }

        /// <summary>
        /// 是否触发事件
        /// </summary>
        [Description("控制分页组件是否响应事件，主要用于代码设置分页组件，而不触发事件"), Browsable(false)]
        public bool IsTrigger
        {
            get { return aIsTrigger; }
            set { aIsTrigger = value; }
        }

        [Description("设置或获取数据总数的显示消息内容;#count 为占位符，将自动替换成数据总数")]
        public string DataCountLable
        {
            get
            {
                return aDataCountLable;
            }
            set
            {
                aDataCountLable = value;
            }
        }

        private string aDataCountLable = "共 #count 行";

        /// <summary>
        /// 总页数
        /// </summary>
        private int aTotal = 0;

        /// <summary>
        /// 数据总数
        /// </summary>
        private int aDataCount = 0;

        /// <summary>
        /// 当前页数
        /// </summary>
        private int aCurrent = 0;

        /// <summary>
        /// 每页行数
        /// </summary>
        private int aPagerNum = 10;

        /// <summary>
        /// 每页行数列表
        /// </summary>
        private List<int> aPagerNumList = new List<int>(new int[] { 10, 20, 30, 50, 100 });

        /// <summary>
        /// 是否需要触发相关事件
        /// </summary>
        private bool aIsTrigger = true;

        /// <summary>
        /// 触发事件的当前页，用来防止当前页改变时的二次触发
        /// </summary>
        private int aTriggerIndex = 0;

        /// <summary>
        /// 分页组件
        /// </summary>
        public PagerToolsControl()
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;
            tlab_datacount.Text = aDataCountLable;
            aIsTrigger = false;
            foreach (int iObj in aPagerNumList)
            {
                tcom_num.Items.Add(iObj);
            }
            tcom_num.SelectedIndex = 0;
            aIsTrigger = true;
        }

        /// <summary>
        /// 更新总页数
        /// </summary>
        private void UpdataTotal()
        {
            tlab_total.Text = string.Format(tlab_total.Tag.ToString(), aTotal);

            tcomb_current.Items.Clear();
            for (int i = 0; i < aTotal; i++)
            {
                tcomb_current.Items.Add(i + 1);
            }

            if (aCurrent > aTotal)
                Current = aTotal;
            else
            {
                tcomb_current.SelectedIndex = aCurrent - 1;
                OnPagerIndexChanged();
                UpdataView();
            }
        }

        /// <summary>
        /// 更新当前页
        /// </summary>
        private void UpdataCurrent()
        {
            ttxt_current.Text = aCurrent.ToString();
            tcomb_current.SelectedIndex = aCurrent - 1;

            UpdataView();
            OnPagerIndexChanged();
        }

        /// <summary>
        /// 更新界面
        /// </summary>
        private void UpdataView()
        {
            if (aTotal == 0)
            {
                tbtn_first.Enabled = tbtn_last.Enabled
                    = tbtn_next.Enabled = tbtn_up.Enabled
                    = tbtn_refresh.Enabled = ttxt_current.Enabled
                    = tcomb_current.Enabled = false;
                return;
            }

            if ((aCurrent == 1) && (aCurrent < aTotal))
            {
                tbtn_first.Enabled = tbtn_up.Enabled = false;

                tbtn_last.Enabled = tbtn_next.Enabled
                    = tbtn_refresh.Enabled = ttxt_current.Enabled
                    = tcomb_current.Enabled = true;
            }
            else if ((aCurrent == 1) && (aCurrent == aTotal))
            {
                tbtn_first.Enabled = tbtn_up.Enabled
                    = tbtn_last.Enabled = tbtn_next.Enabled
                    = false;

                tbtn_refresh.Enabled = ttxt_current.Enabled
                    = tcomb_current.Enabled = true;
            }
            else if ((aCurrent > 1) && (aCurrent < aTotal))
            {
                tbtn_first.Enabled = tbtn_up.Enabled
                    = tbtn_last.Enabled = tbtn_next.Enabled
                    = tbtn_refresh.Enabled = ttxt_current.Enabled
                    = tcomb_current.Enabled = true;
            }
            else if ((aCurrent > 1) && (aCurrent == aTotal))
            {
                tbtn_last.Enabled = tbtn_next.Enabled = false;

                tbtn_first.Enabled = tbtn_up.Enabled
                    = tbtn_refresh.Enabled = ttxt_current.Enabled
                    = tcomb_current.Enabled = true;
            }
        }

        /// <summary>
        /// 更新每页行数
        /// </summary>
        private void UpdataPagerNum()
        {
            if ((tcom_num.SelectedItem != null) && (aPagerNum == ((int)tcom_num.SelectedItem))) return;

            foreach (object iItem in tcom_num.Items)
            {
                if (((int)iItem) == aPagerNum)
                {
                    tcom_num.SelectedItem = iItem;
                    return;
                }
            }
        }

        /// <summary>
        /// 当前页改变时调用事件
        /// </summary>
        private void OnPagerIndexChanged()
        {
            if (!aIsTrigger) return;
            if (aTriggerIndex == aCurrent) return;
            if (PagerIndexChanged != null)
            {
                C_EventArgsClass iObj = new C_EventArgsClass();
                iObj.CurrentPagerIndex = aCurrent;
                iObj.Total = aTotal;
                PagerIndexChanged(this, iObj);
                aTriggerIndex = aCurrent;
            }
        }

        /// <summary>
        /// 每页行数改变时调用事件
        /// </summary>
        private void OnPagerNumChanged()
        {
            if (!aIsTrigger) return;
            if (PagerNumChanged != null)
            {
                C_EventArgsClass iObj = new C_EventArgsClass();
                iObj.CurrentPagerIndex = aCurrent;
                iObj.Total = aTotal;
                iObj.PagerNum = aPagerNum;
                PagerNumChanged(this, iObj);
            }
        }

        private void tbtn_first_Click(object sender, EventArgs e)
        {
            Current = 1;
        }

        private void tbtn_up_Click(object sender, EventArgs e)
        {
            Current--;
        }

        private void tbtn_last_Click(object sender, EventArgs e)
        {
            Current = aTotal;
        }

        private void tbtn_next_Click(object sender, EventArgs e)
        {
            Current++;
        }

        private void tcomb_current_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current = tcomb_current.SelectedIndex + 1;
        }

        private void tcom_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!aIsTrigger) return;
            PagerNum = (int)tcom_num.SelectedItem;
        }

        private void ttxt_current_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Current = int.Parse(ttxt_current.Text);
            }

            if (e.KeyChar != 8)//退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
        }

        private void tcom_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int ipagernum = int.Parse(tcom_num.Text);
                if (!aPagerNumList.Contains(ipagernum))
                {
                    aPagerNumList.Add(ipagernum);
                    tcom_num.Items.Add(ipagernum);
                    aIsTrigger = false;
                    tcom_num.SelectedItem = ipagernum;
                    aIsTrigger = true;
                }
                //UpdataPagerNum();
                PagerNum = int.Parse(tcom_num.Text);
            }

            if (e.KeyChar != 8)//退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
        }
    }
}
