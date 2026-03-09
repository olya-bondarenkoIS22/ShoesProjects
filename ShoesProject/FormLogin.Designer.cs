namespace ShoesProject
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            pnMain = new Panel();
            lbLogin = new Label();
            lbPassword = new Label();
            txtlogin = new TextBox();
            txtPassword = new TextBox();
            btnQuest = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(141, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(btnQuest);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(txtlogin);
            pnMain.Controls.Add(lbPassword);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(25, 109);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(332, 232);
            pnMain.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(131, 21);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(70, 22);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(122, 85);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 22);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Парлоль:";
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(41, 49);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(250, 30);
            txtlogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(41, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnQuest
            // 
            btnQuest.BackColor = Color.Chartreuse;
            btnQuest.FlatAppearance.BorderSize = 0;
            btnQuest.FlatStyle = FlatStyle.Flat;
            btnQuest.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnQuest.Location = new Point(91, 185);
            btnQuest.Name = "btnQuest";
            btnQuest.Size = new Size(150, 30);
            btnQuest.TabIndex = 4;
            btnQuest.Text = "Войти как гость";
            btnQuest.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(91, 149);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private TextBox txtPassword;
        private TextBox txtlogin;
        private Label lbPassword;
        private Label lbLogin;
        private Button btnLogin;
        private Button btnQuest;
    }
}
