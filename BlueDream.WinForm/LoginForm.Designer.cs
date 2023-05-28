namespace BlueDream.WinForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            txt_UserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Password = new TextBox();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(115, 143);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "登    录";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(115, 54);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(171, 23);
            txt_UserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 2;
            label1.Text = "用户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 4;
            label2.Text = "密  码：";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(115, 94);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(171, 23);
            txt_Password.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(211, 143);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "取    消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 221);
            Controls.Add(btn_Cancel);
            Controls.Add(label2);
            Controls.Add(txt_Password);
            Controls.Add(label1);
            Controls.Add(txt_UserName);
            Controls.Add(btn_Login);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimumSize = new Size(430, 260);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox txt_UserName;
        private Label label1;
        private Label label2;
        private TextBox txt_Password;
        private Button btn_Cancel;
    }
}