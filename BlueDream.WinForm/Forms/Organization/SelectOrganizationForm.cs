using BlueDream.Model;
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
    public partial class SelectOrganizationForm : Form
    {
        private string m_ReturnKey = "";

        public delegate void CallBack(string p_Key, object p_Value);//定义委托
        public event CallBack CallBack_Event;//事件变量

        public SelectOrganizationForm(string p_ReturnKey)
        {
            m_ReturnKey = p_ReturnKey;

            InitializeComponent();
            InitPager();
            LoadData(1, dgv_Main_Pager.PageSize, "*", true);
        }

        private void InitPager()
        {
            dgv_Main_Pager.PageSize = 10;
            dgv_Main_Pager.PageChange += Dgv_Main_Pager_PageChange;
        }

        private void LoadData(int p_PageSize, int p_PageIndex, string p_SearchKey, bool p_InitPage)
        {
            if (string.IsNullOrWhiteSpace(p_SearchKey))
            {
                p_SearchKey = "*";
            }

            dgv_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //品牌
            ApiOrganization m_ApiOrganization = new ApiOrganization();

            m_ApiOrganization.Parameters.Add("p_SearchKey", p_SearchKey);
            m_ApiOrganization.Parameters.Add("p_PageSize", p_PageSize);
            m_ApiOrganization.Parameters.Add("p_PageIndex", p_PageIndex);
            ApiPageResult<List<OrganizationEntity>> m_ApiPageResult = m_ApiOrganization.GetOrganizationListByPage();

            dgv_Main.DataSource = m_ApiPageResult.ResultObj;
            dgv_Main.AutoGenerateColumns = false;
            dgv_Main.Columns.Clear();
            InitDataGridViewColumn(dgv_Main, "OrgID", "组织ID");
            dgv_Main.Columns["OrgID"].Visible = false;

            InitDataGridViewColumn(dgv_Main, "OrgCode", "组织编码");
            InitDataGridViewColumn(dgv_Main, "OrgShortName", "简称");


            
            InitDataGridViewColumn(dgv_Main, "OrgCnName", "中文名称");
            InitDataGridViewColumn(dgv_Main, "OrgEnName", "英文名称");

            dgv_Main_Pager.DataCount = m_ApiPageResult.TotalCount;
        }

        private void Dgv_Main_Pager_PageChange()
        {
            LoadData(dgv_Main_Pager.PageSize, dgv_Main_Pager.PageIndex, txt_Search.Text.Trim(), true);
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

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (dgv_Main.SelectedRows.Count == 0)
            {
                return;
            }

            List<OrganizationEntity> m_OrgList = (List<OrganizationEntity>)dgv_Main.DataSource;

            OrganizationEntity m_OrganizationEntity = m_OrgList[dgv_Main.SelectedRows[0].Index];

            CallBack_Event(m_ReturnKey, m_OrganizationEntity);

            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadData(dgv_Main_Pager.PageSize, dgv_Main_Pager.PageIndex, txt_Search.Text.Trim(), true);
        }


    }
}
