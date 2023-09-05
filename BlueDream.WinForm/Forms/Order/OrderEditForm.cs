using BlueDream.Model;
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

        private const string c_BrandReturnKey = "Brand";
        private const string c_PurchaseOrgReturnKey = "PurchaseOrg";
        private const string c_SaleOrgReturnKey = "SaleOrg";

        public OrderEditForm()
        {
            InitializeComponent();
            Init();
        }



        private void DropDownList_CallBack(string p_Key, object p_Value)
        {
            switch (p_Key)
            {
                case c_BrandReturnKey:
                    BrandEntity t_BrandEntity = (BrandEntity)p_Value;
                    txt_Brand.Text = t_BrandEntity.BrandShortName;
                    txt_Brand.Tag = t_BrandEntity;
                    return;

                case c_PurchaseOrgReturnKey:
                    OrganizationEntity t_PurchaseOrgEntity = (OrganizationEntity)p_Value;
                    txt_Purchase_Org.Text = t_PurchaseOrgEntity.OrgShortName;
                    txt_Purchase_Org.Tag = t_PurchaseOrgEntity;
                    return;

                case c_SaleOrgReturnKey:
                    OrganizationEntity t_SaleOrgEntity = (OrganizationEntity)p_Value;
                    txt_Sale_Org.Text = t_SaleOrgEntity.OrgShortName;
                    txt_Sale_Org.Tag = t_SaleOrgEntity;
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
            SelectBrandForm m_SelectBrandForm = new SelectBrandForm(c_BrandReturnKey);
            m_SelectBrandForm.CallBack_Event += DropDownList_CallBack;
            m_SelectBrandForm.ShowDialog();
        }


        private void txt_Purchase_Org_Click(object sender, EventArgs e)
        {
            SelectOrganizationForm m_SelectOrganizationForm = new SelectOrganizationForm(c_PurchaseOrgReturnKey);
            m_SelectOrganizationForm.CallBack_Event += DropDownList_CallBack;
            m_SelectOrganizationForm.ShowDialog();
        }

        private void txt_Sale_Org_Click(object sender, EventArgs e)
        {
            SelectOrganizationForm m_SelectOrganizationForm = new SelectOrganizationForm(c_SaleOrgReturnKey);
            m_SelectOrganizationForm.CallBack_Event += DropDownList_CallBack;
            m_SelectOrganizationForm.ShowDialog();
        }

        private void btnj_Save_Click(object sender, EventArgs e)
        {

        }

      
    }
}
