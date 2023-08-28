using BlueDream.Common;
using BlueDream.Model;
using BlueDream.WinForm.Bll.WebApi;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueDream.WinForm.Forms.Purchase
{
    public partial class ClothingOrderEditForm : Form
    {
        public ClothingOrderEditForm()
        {
            InitializeComponent();
            InitCompanyList();

            //foreach(var t_Item in CompanyDic)
            //{
            //    cmb_purchase.Items.Add(new )

            //}
        }

        private void InitCompanyList()
        {
            ApiSystem m_ApiSystem = new ApiSystem();
            CommonResult m_CommonResult =m_ApiSystem.GetRigth();


            ApiOrganization m_ApiApiOrganization = new ApiOrganization();
            m_ApiApiOrganization.Parameters.Add("p_SearchKey", "");
            ApiResult<List<OrganizationEntity>> m_Result = m_ApiApiOrganization.GetOrganization();
            cmb_purchase.Items.Clear();
            cmb_purchase.DataSource = m_Result.ResultObj;
            cmb_purchase.DisplayMember = "CompanyName";
            cmb_purchase.ValueMember = "CompanyID";

        }



        /// <summary>
        /// comboBox1文件内容发现改变时 触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_purchase_TextUpdate(object sender, EventArgs e)
        {
            //清空combobox
            ComboBox cb = sender as ComboBox;
            cb.Items.Clear();

            //临时存放备查数据
            List<string> temp = new List<string>();

            //foreach (var t_Item in CompanyDic)
            //{
            //    if (t_Item.Contains(cb.Text))
            //    {
            //        temp.Add(t_Item);
            //    }
            //}

            if (temp.Count < 1)
            {//修复输入不存在的数据源然后点击其他地方会报错
                cb.Items.Add("");
                cb.Text = "";
                return;
            }

            try
            {
                //combobox添加已经查到的关键词
                cb.Items.AddRange(temp.ToArray());
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                cb.SelectionStart = cb.Text.Length;
                //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
                Cursor = Cursors.Default;
                //自动弹出下拉框
                cb.DroppedDown = true;
            }
            catch
            {
                cb.SelectedIndex = -1;
            }
        }

    }
}
