using BlueDream.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueDream.WinForm
{
    public partial class OrderEditForm : Form
    {

        public OrderEditForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            //品牌
            ApiBrand m_ApiBrand = new ApiBrand();
            m_ApiBrand.Parameters.Add("p_SearchKey", "*");
            cb_Brand.DataSource = m_ApiBrand.GetBrandTop10().ResultObj;
            cb_Brand.DisplayMember = "BrandCn";
            cb_Brand.ValueMember = "BrandID";

            ApiUser m_ApiUser = new ApiUser();
            m_ApiUser.Parameters.Add("p_SearchKey", "*");
            cb_PersonInCharge.DataSource = m_ApiUser.GetUserTop10().ResultObj;
            cb_PersonInCharge.DisplayMember = "NickName";
            cb_PersonInCharge.ValueMember = "UserID";

            ApiOrganization m_ApiOrganization = new ApiOrganization();
            m_ApiOrganization.Parameters.Add("p_SearchKey", "*");

            cb_PurchaseOrg.DataSource = m_ApiOrganization.GetOrganizationTop10().ResultObj;
            cb_PurchaseOrg.DisplayMember = "OrgShortName";
            cb_PurchaseOrg.ValueMember = "OrgID";

            cb_SaleOrg.DataSource = m_ApiOrganization.GetOrganizationTop10().ResultObj;
            cb_SaleOrg.DisplayMember = "OrgShortName";
            cb_SaleOrg.ValueMember = "OrgID";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //检索订单
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
        private void cb_Brand_TextUpdate(object sender, EventArgs e)
        {

        }


        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

            //清空combobox
            ComboBox m_ComboBox = sender as ComboBox;
            m_ComboBox.Items.Clear();

            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            m_ComboBox.DroppedDown = true;
        }


    }
}
