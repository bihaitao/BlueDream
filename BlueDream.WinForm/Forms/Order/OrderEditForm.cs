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
        private const string c_PersonInCharge = "PersonInCharge";


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

                case c_PersonInCharge:
                    UserEntity t_PersonInChargeEntity = (UserEntity)p_Value;
                    txt_PersonInCharge.Text = t_PersonInChargeEntity.NickName;
                    txt_PersonInCharge.Tag = t_PersonInChargeEntity;
                    return;

                default: return;
            }
        }



        public void Init()
        {
            ApiResult<List<CurrencyModel>> m_CurrencyResult = new ApiDic().GetCurrencyModels();

            cb_CurrencyCode.DataSource = m_CurrencyResult.ResultObj;
            cb_CurrencyCode.DisplayMember = "CurrencyName";
            cb_CurrencyCode.ValueMember = "CurrencyCode";
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

        private void txt_PersonInCharge_Click(object sender, EventArgs e)
        {
            SelectUserForm m_SelectUserForm = new SelectUserForm(c_PersonInCharge);
            m_SelectUserForm.CallBack_Event += DropDownList_CallBack;
            m_SelectUserForm.ShowDialog();
        }

        private void btnj_Save_Click(object sender, EventArgs e)
        {

        }


    }
}
