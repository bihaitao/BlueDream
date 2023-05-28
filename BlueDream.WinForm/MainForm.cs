using BlueDream.Common;
using BlueDream.WinForm.Forms;
using BlueDream.WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueDream.WinForm
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm m_LoginForm = new LoginForm();
            DialogResult m_DialogResult = m_LoginForm.ShowDialog();

            if (m_DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
         
            InitMenuTree();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        

        private void ctl_Menu_TreeView_DoubleClick(object sender, EventArgs e)
        {
            //如果找到的已经打开的Tab则显示，否则创建
            foreach(TabPage t_TabPage in ctl_Main_Tab.TabPages)
            {
                if(t_TabPage.Name == ((TreeView)sender).SelectedNode.Name)
                { 
                    ctl_Main_Tab.SelectTab(t_TabPage);
                    return;
                }
            }

            //开始创建新的TabPage并加载From
            TabPage m_TabPage = new TabPage()
            {
                Name = ((TreeView)sender).SelectedNode.Name,
                Text = ((TreeView)sender).SelectedNode.Text,
            };
            ctl_Main_Tab.TabPages.Add(m_TabPage);
  
            string m_FormFullName = StringTools.GetNotNullString(((TreeView)sender).SelectedNode.Tag);

            //反射生成窗体
            Form m_Form = (Form)Assembly.GetExecutingAssembly().CreateInstance(m_FormFullName);
            //设置窗体没有边框，加入到选项卡中
            m_Form.FormBorderStyle = FormBorderStyle.None;
            m_Form.TopLevel = false; 
            m_Form.ControlBox = false;
            m_Form.Dock = DockStyle.Fill;
            //将窗体的父窗体设置为新添加的TabPage
            m_Form.Parent = m_TabPage;
            //显示当前TabPage
            ctl_Main_Tab.SelectTab(m_TabPage);
            m_Form.Show();
          
        }

        private void InitMenuTree()
        {
            Dictionary<string, string> m_MenuDic = MenuModel.GetMenuDic();


            this.ctl_Menu_TreeView.Nodes.Add(new TreeNode()
            {
                Name = "test1",
                Text = "test1",
                Tag = m_MenuDic["test1"]
            });
            this.ctl_Menu_TreeView.Nodes.Add(new TreeNode()
            {
                Name = "test2",
                Text = "test2",
                Tag = m_MenuDic["test2"]
            });
        }

        private void ctl_Main_Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }


        
        
    }
}
