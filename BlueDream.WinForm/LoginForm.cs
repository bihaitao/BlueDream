using BlueDream.Common; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BlueDream.WinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {

            HttpRequest m_HttpRequest = new HttpRequest();

            m_HttpRequest.Parameters.Add("UserName", txt_UserName.Text);
            m_HttpRequest.Parameters.Add("Password", txt_Password.Text);
            m_HttpRequest.Parameters.Add("VerifyCode", txt_Password.Text);
            
             
            CommonResult m_CommonResult = m_HttpRequest.Login();

            if (m_CommonResult.Success)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(m_CommonResult.Message);
            } 
        }
 

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
