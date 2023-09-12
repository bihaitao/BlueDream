using BlueDream.Common;
using BlueDream.Model;
using BlueDream.Model.Common;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Org.BouncyCastle.Asn1.X509;
using SqlSugar;
using Sunny.UI;

namespace BlueDream.WinForm
{
    public partial class OrderEditForm : Form
    {
        private bool m_IsAdd = true;

        private const string c_SelectBrandReturnKey = "SelectBrandReturnKey";
        private const string c_SelectPurchaseOrgReturnKey = "SelectPurchaseOrgReturnKey";
        private const string c_SelectSaleOrgReturnKey = "SelectSaleOrgReturnKey";
        private const string c_SelectPersonInCharge = "SelectPersonInCharge";

        private const string c_AddOrderItemReturnKey = "AddOrderItemReturnKey";

        private const string c_UpdateOrderItemReturnKey = "UpdateOrderItemReturnKey";
        /// <summary>
        /// 订单实体
        /// </summary>
        OrderModel m_OrderModel = new OrderModel();


        /// <summary>
        /// 气泡提示
        /// </summary>
        private Dictionary<string, ToolTip> m_ToolTipDic = new Dictionary<string, ToolTip>();

        /// <summary>
        /// 气泡提示对应的控件
        /// </summary>
        private Dictionary<string, IWin32Window> m_IWin32WindowDic = new Dictionary<string, IWin32Window>();

        public OrderEditForm()
        {
            InitializeComponent();
            Init();
        }


        public OrderEditForm(long p_OrderID)
        {
            m_IsAdd = false;

            InitializeComponent();
            Init();

            //------------------------------------------------------------------------------------------------

            ApiOrder m_ApiOrder = new ApiOrder();
            m_ApiOrder.Parameters.Add("p_OrderID", p_OrderID);
            CommonResult m_CommonResult_Order = m_ApiOrder.GetOrderByID();

            if (!m_CommonResult_Order.Success)
            {
                MessageBox.Show(m_CommonResult_Order.ExMessage);
                this.Close();
                return;
            }
            m_OrderModel = JsonTools.JsonToObject<OrderModel>(m_CommonResult_Order.ResultObj);

            txt_OrderNo.Text = m_OrderModel.OrderNo;
            txt_CustomerOrderNo.Text = m_OrderModel.CustomerOrderNo;
            //================================================================================================

            //------------------------------------------------------------------------------------------------
            ApiBrand m_ApiBrand = new ApiBrand();
            m_ApiBrand.Parameters.Add("p_BrandID", m_OrderModel.BrandID);
            CommonResult m_CommonResult_Brand = m_ApiBrand.GetBrandByID();
            if (!m_CommonResult_Brand.Success)
            {
                MessageBox.Show(m_CommonResult_Brand.ExMessage);
            }
            BrandEntity m_BrandEntity = JsonTools.JsonToObject<BrandEntity>(m_CommonResult_Brand.ResultObj);
            txt_Brand.Text = m_BrandEntity.BrandShortName;
            txt_Brand.Tag = m_BrandEntity;
            //================================================================================================


            //------------------------------------------------------------------------------------------------
            ApiUser m_ApiUser = new ApiUser();
            m_ApiUser.Parameters.Add("p_UserID", m_OrderModel.PersonInChargeID);
            CommonResult m_CommonResult_User = m_ApiUser.GetUserByID();
            if (!m_CommonResult_User.Success)
            {
                MessageBox.Show(m_CommonResult_User.ExMessage);
            }
            UserEntity m_UserEntity = JsonTools.JsonToObject<UserEntity>(m_CommonResult_User.ResultObj);
            txt_PersonInCharge.Text = m_UserEntity.NickName;
            txt_PersonInCharge.Tag = m_UserEntity;
            //================================================================================================

            //------------------------------------------------------------------------------------------------
            ApiOrganization m_ApiOrganization = new ApiOrganization();
            m_ApiOrganization.Parameters.Add("p_OrganizationID", m_OrderModel.PurchaseOrgID);
            CommonResult m_CommonResult_PurchaseOrg = m_ApiOrganization.GetOrganizationByID();
            if (!m_CommonResult_PurchaseOrg.Success)
            {
                MessageBox.Show(m_CommonResult_PurchaseOrg.ExMessage);
            }
            OrganizationEntity m_PurchaseOrg = JsonTools.JsonToObject<OrganizationEntity>(m_CommonResult_PurchaseOrg.ResultObj);
            txt_Purchase_Org.Text = m_PurchaseOrg.OrganizationShortName;
            txt_Purchase_Org.Tag = m_PurchaseOrg;
            //================================================================================================

            //------------------------------------------------------------------------------------------------
            m_ApiOrganization.Parameters.Clear();
            m_ApiOrganization.Parameters.Add("p_OrganizationID", m_OrderModel.PurchaseOrgID);
            CommonResult m_CommonResult_SaleOrg = m_ApiOrganization.GetOrganizationByID();
            if (!m_CommonResult_SaleOrg.Success)
            {
                MessageBox.Show(m_CommonResult_SaleOrg.ExMessage);
            }
            OrganizationEntity m_SaleOrg = JsonTools.JsonToObject<OrganizationEntity>(m_CommonResult_SaleOrg.ResultObj);
            txt_Sale_Org.Text = m_PurchaseOrg.OrganizationShortName;
            txt_Sale_Org.Tag = m_PurchaseOrg;
            //================================================================================================

            //------------------------------------------------------------------------------------------------
          
            if(m_OrderModel.OrderItemList.Count==0)
            {
                dgv_Main.DataSource = null;
            }
            else
            {
                dgv_Main.DataSource = m_OrderModel.OrderItemList;
            }
            
            dgv_Main.Refresh();

            //================================================================================================
        }

        private void DropDownList_CallBack(string p_Key, object p_Value)
        {
            switch (p_Key)
            {
                case c_SelectBrandReturnKey:
                    BrandEntity t_BrandEntity = (BrandEntity)p_Value;
                    txt_Brand.Text = t_BrandEntity.BrandShortName;
                    txt_Brand.Tag = t_BrandEntity;
                    return;

                case c_SelectPurchaseOrgReturnKey:
                    OrganizationEntity t_PurchaseOrgEntity = (OrganizationEntity)p_Value;
                    txt_Purchase_Org.Text = t_PurchaseOrgEntity.OrganizationShortName;
                    txt_Purchase_Org.Tag = t_PurchaseOrgEntity;
                    return;

                case c_SelectSaleOrgReturnKey:
                    OrganizationEntity t_SaleOrgEntity = (OrganizationEntity)p_Value;
                    txt_Sale_Org.Text = t_SaleOrgEntity.OrganizationShortName;
                    txt_Sale_Org.Tag = t_SaleOrgEntity;
                    return;

                case c_SelectPersonInCharge:
                    UserEntity t_PersonInChargeEntity = (UserEntity)p_Value;
                    txt_PersonInCharge.Text = t_PersonInChargeEntity.NickName;
                    txt_PersonInCharge.Tag = t_PersonInChargeEntity;
                    return;

                case c_AddOrderItemReturnKey:
                    OrderItemEntity t_OrderItemEntity = (OrderItemEntity)p_Value;
                    m_OrderModel.OrderItemList.Add(t_OrderItemEntity);
                    dgv_Main.DataSource = null;
                    dgv_Main.DataSource = m_OrderModel.OrderItemList;
                    dgv_Main.Refresh();
                    return;
                case c_UpdateOrderItemReturnKey: 
                    dgv_Main.DataSource = null;
                    dgv_Main.DataSource = m_OrderModel.OrderItemList;
                    dgv_Main.Refresh();
                    return;
                default: return;
            }
        }



        public void Init()
        {
            ApiResult<List<CurrencyModel>> m_CurrencyResult = new ApiDic().GetCurrencyList();
            cb_CurrencyCode.DataSource = m_CurrencyResult.ResultObj;
            cb_CurrencyCode.DisplayMember = "CurrencyName";
            cb_CurrencyCode.ValueMember = "CurrencyCode";
            dgv_Main.AutoGenerateColumns = false;
        }

        private void InitDataGridViewColumn(DataGridView p_DataGridView, string p_ColumnName, string p_HeadTex)
        {
            p_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = p_ColumnName,
                Name = p_ColumnName,
                HeaderText = p_HeadTex
            });
        }

        private void txt_Brand_Click(object sender, EventArgs e)
        {
            SelectBrandForm m_SelectBrandForm = new SelectBrandForm(c_SelectBrandReturnKey);
            m_SelectBrandForm.CallBack_Event += DropDownList_CallBack;
            m_SelectBrandForm.ShowDialog();
        }

        private void txt_Purchase_Org_Click(object sender, EventArgs e)
        {
            SelectOrganizationForm m_SelectOrganizationForm = new SelectOrganizationForm(c_SelectPurchaseOrgReturnKey);
            m_SelectOrganizationForm.CallBack_Event += DropDownList_CallBack;
            m_SelectOrganizationForm.ShowDialog();
        }

        private void txt_Sale_Org_Click(object sender, EventArgs e)
        {
            SelectOrganizationForm m_SelectOrganizationForm = new SelectOrganizationForm(c_SelectSaleOrgReturnKey);
            m_SelectOrganizationForm.CallBack_Event += DropDownList_CallBack;
            m_SelectOrganizationForm.ShowDialog();
        }

        private void txt_PersonInCharge_Click(object sender, EventArgs e)
        {
            SelectUserForm m_SelectUserForm = new SelectUserForm(c_SelectPersonInCharge);
            m_SelectUserForm.CallBack_Event += DropDownList_CallBack;
            m_SelectUserForm.ShowDialog();
        }

        private void btnj_Save_Click(object sender, EventArgs e)
        {

        }


        bool b = true;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ApiOrder m_ApiOrder = new ApiOrder();
            if (m_IsAdd)
            {
                m_OrderModel.OrderID = StringTools.GetNewGuidLong();
            }

            m_OrderModel.OrderNo = txt_OrderNo.Text.Trim();
            m_OrderModel.CustomerOrderNo = txt_CustomerOrderNo.Text.Trim();
            m_OrderModel.BrandID = ((BrandEntity)txt_Brand.Tag).BrandID;
            m_OrderModel.BrandName = ((BrandEntity)txt_Brand.Tag).BrandShortName;
            m_OrderModel.PersonInChargeID = ((UserEntity)txt_PersonInCharge.Tag).UserID;
            m_OrderModel.PersonInChargeUser = ((UserEntity)txt_PersonInCharge.Tag).NickName;
            m_OrderModel.SaleOrgID = ((OrganizationEntity)txt_Sale_Org.Tag).OrganizationID;
            m_OrderModel.SaleOrgName = ((OrganizationEntity)txt_Sale_Org.Tag).OrganizationShortName;
            m_OrderModel.PurchaseOrgID = ((OrganizationEntity)txt_Purchase_Org.Tag).OrganizationID;
            m_OrderModel.PurchaseOrgName = ((OrganizationEntity)txt_Purchase_Org.Tag).OrganizationShortName;
            m_OrderModel.OrderCurrencyCode = cb_CurrencyCode.SelectedValue.ToString();
            m_OrderModel.RemarksInfo = txt_Remark.Text.Trim();

            BaseTools.InitBase(m_OrderModel);

            foreach (OrderItemEntity t_OrderItemEntity in m_OrderModel.OrderItemList)
            {
                t_OrderItemEntity.OrderID = m_OrderModel.OrderID;
                BaseTools.InitBase(t_OrderItemEntity);
            }

            CommonResult m_CommonResult = m_ApiOrder.Save(m_OrderModel);
            MessageBox.Show(m_CommonResult.Message);
        }

        private void ShowTips(IWin32Window p_IWin32Window, string p_Key, string p_Value)
        {
            if (m_ToolTipDic.ContainsKey(p_Key))
            {
                ToolTip t_ToolTip = m_ToolTipDic[p_Key];
                t_ToolTip.Show(p_Value, p_IWin32Window);
            }
            else
            {
                ToolTip m_ToolTip = new ToolTip();
                m_ToolTip.Show(p_Value, p_IWin32Window);
                m_ToolTipDic.Add(p_Key, m_ToolTip);
                m_IWin32WindowDic.Add(p_Key, p_IWin32Window);
            }
        }

        private void HiddenTips()
        {
            foreach (string m_Key in m_ToolTipDic.Keys)
            {
                m_ToolTipDic[m_Key].Hide(m_IWin32WindowDic[m_Key]);
            }

            m_ToolTipDic.Clear();
            m_IWin32WindowDic.Clear();
        }

        private void OrderEditForm_Click(object sender, EventArgs e)
        {
            HiddenTips();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            OrderItemEditForm m_OrderItemEditForm = new OrderItemEditForm(c_AddOrderItemReturnKey);
            m_OrderItemEditForm.CallBack_Event += DropDownList_CallBack;
            m_OrderItemEditForm.ShowDialog();
        }

        private void btn_DelItem_Click(object sender, EventArgs e)
        {
            for (int t_Index = 0; t_Index < dgv_Main.SelectedRows.Count; t_Index++)
            {
                OrderItemEntity m_OrderItemEntity = dgv_Main.SelectedRows[t_Index].DataBoundItem as OrderItemEntity;

                m_OrderModel.OrderItemList.Remove(m_OrderItemEntity);
            }

            dgv_Main.DataSource = null;
            dgv_Main.DataSource = m_OrderModel.OrderItemList;
            dgv_Main.Refresh();

        }

        private void dgv_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            long m_OrderItemID = Convert.ToInt64(dgv_Main.Rows[e.RowIndex].Cells["OrderItemID"].Value);
            OrderItemEntity m_OrderItemEntity = m_OrderModel.OrderItemList.Find(t => t.OrderItemID == m_OrderItemID);
            OrderItemEditForm m_OrderItemEditForm = new OrderItemEditForm(c_UpdateOrderItemReturnKey, m_OrderItemEntity);
            m_OrderItemEditForm.StartPosition = FormStartPosition.CenterParent;
            m_OrderItemEditForm.CallBack_Event += DropDownList_CallBack;
            m_OrderItemEditForm.ShowDialog();
        }
    }
}
