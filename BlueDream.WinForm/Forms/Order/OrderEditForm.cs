using BlueDream.Model;
using BlueDream.WinForm;
using BlueDream.WinForm.Forms.Brand;
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



        private void DropDownList_CallBack(string p_Key, object p_Value)
        {
            switch (p_Key)
            {
                case "Brand":
                    BrandEntity t_BrandEntity = (BrandEntity)p_Value;
                    txt_Brand.Text = t_BrandEntity.BrandShortName;
                    txt_Brand.Tag = t_BrandEntity;
                    return;
                default: return;
            }
        }



        public void Init()
        {
            ////品牌
            //ApiBrand m_ApiBrand = new ApiBrand();
            //m_ApiBrand.Parameters.Add("p_SearchKey", "*");
            //cb_Brand.DataSource = m_ApiBrand.GetBrandTop10().ResultObj;
            //cb_Brand.DisplayMember = "BrandCn";
            //cb_Brand.ValueMember = "BrandID";

            //ApiUser m_ApiUser = new ApiUser();
            //m_ApiUser.Parameters.Add("p_SearchKey", "*");
            //cb_PersonInCharge.DataSource = m_ApiUser.GetUserTop10().ResultObj;
            //cb_PersonInCharge.DisplayMember = "NickName";
            //cb_PersonInCharge.ValueMember = "UserID";

            //ApiOrganization m_ApiOrganization = new ApiOrganization();
            //m_ApiOrganization.Parameters.Add("p_SearchKey", "*");

            //cb_PurchaseOrg.DataSource = m_ApiOrganization.GetOrganizationTop10().ResultObj;
            //cb_PurchaseOrg.DisplayMember = "OrgShortName";
            //cb_PurchaseOrg.ValueMember = "OrgID";

            //cb_SaleOrg.DataSource = m_ApiOrganization.GetOrganizationTop10().ResultObj;
            //cb_SaleOrg.DisplayMember = "OrgShortName";
            //cb_SaleOrg.ValueMember = "OrgID";
        }

        private void txt_Brand_Click(object sender, EventArgs e)
        {
            SelectBrandForm m_SelectBrandForm = new SelectBrandForm();
            m_SelectBrandForm.CallBack_Event += DropDownList_CallBack;
            m_SelectBrandForm.ShowDialog();
        }



        private void btnj_Save_Click(object sender, EventArgs e)
        {

        }

        private void txt_Brand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
