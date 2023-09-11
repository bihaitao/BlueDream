using BlueDream.Common;
using BlueDream.Model;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Org.BouncyCastle.Asn1.X509;
using SqlSugar;
using Sunny.UI;

namespace BlueDream.WinForm
{
    public partial class OrderEditForm : Form
    {

        private const string c_SelectBrandReturnKey = "SelectBrandReturnKey";
        private const string c_SelectPurchaseOrgReturnKey = "SelectPurchaseOrgReturnKey";
        private const string c_SelectSaleOrgReturnKey = "SelectSaleOrgReturnKey";
        private const string c_SelectPersonInCharge = "SelectPersonInCharge";

        private const string c_AddOrderItemReturnKey = "AddOrderItemReturnKey";

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
            ApiOrder m_ApiOrder = new ApiOrder(); 
            m_ApiOrder.Parameters.Add("p_OrderID", p_OrderID);
            CommonResult m_CommonResult = m_ApiOrder.Order_GetOrderModel();
            m_OrderModel = (OrderModel)m_CommonResult.ResultObj;
            txt_Brand.Text = m_OrderModel.BrandName;



            InitializeComponent();
            Init();
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
                    txt_Purchase_Org.Text = t_PurchaseOrgEntity.OrgShortName;
                    txt_Purchase_Org.Tag = t_PurchaseOrgEntity;
                    return;

                case c_SelectSaleOrgReturnKey:
                    OrganizationEntity t_SaleOrgEntity = (OrganizationEntity)p_Value;
                    txt_Sale_Org.Text = t_SaleOrgEntity.OrgShortName;
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

                default: return;
            }
        }



        public void Init()
        {
            ApiResult<List<CurrencyModel>> m_CurrencyResult = new ApiDic().GetCurrencyModels();
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
            if (b)
            {
                b = false;
                new ToolTip().Show("1111111", txt_OrderNo);
                new ToolTip().Show("2222222", txt_CustomerOrderNo);
            }
            else
            {
                b = true;
                new ToolTip().Show("aaaaa", txt_OrderNo);
                new ToolTip().Show("bbbbbb", txt_CustomerOrderNo);
            }
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
            for (int t_Index = 0; t_Index < dgv_Main.SelectedRows.Count;t_Index++)
            {
                OrderItemEntity m_OrderItemEntity = dgv_Main.SelectedRows[t_Index].DataBoundItem as OrderItemEntity;
                
                m_OrderModel.OrderItemList.Remove(m_OrderItemEntity); 
            }

            dgv_Main.DataSource = null;
            dgv_Main.DataSource = m_OrderModel.OrderItemList;
            dgv_Main.Refresh();

        }
    }
}
