namespace FarmOrderSystem
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogoLogin = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdbMemberLogin = new System.Windows.Forms.RadioButton();
            this.rdbAdminLogin = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.timerlogin = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.lblLogoLogin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblLogoLogin
            // 
            this.lblLogoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblLogoLogin.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogoLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogoLogin.Location = new System.Drawing.Point(172, 12);
            this.lblLogoLogin.Name = "lblLogoLogin";
            this.lblLogoLogin.Size = new System.Drawing.Size(56, 56);
            this.lblLogoLogin.TabIndex = 0;
            this.lblLogoLogin.Text = "農";
            this.lblLogoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "會員登入";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbMemberLogin
            // 
            this.rdbMemberLogin.AutoSize = true;
            this.rdbMemberLogin.Checked = true;
            this.rdbMemberLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbMemberLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.rdbMemberLogin.Location = new System.Drawing.Point(90, 136);
            this.rdbMemberLogin.Name = "rdbMemberLogin";
            this.rdbMemberLogin.Size = new System.Drawing.Size(73, 29);
            this.rdbMemberLogin.TabIndex = 2;
            this.rdbMemberLogin.TabStop = true;
            this.rdbMemberLogin.Text = "會員";
            this.rdbMemberLogin.CheckedChanged += new System.EventHandler(this.rdbMemberLogin_CheckedChanged);
            // 
            // rdbAdminLogin
            // 
            this.rdbAdminLogin.AutoSize = true;
            this.rdbAdminLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdbAdminLogin.Location = new System.Drawing.Point(220, 136);
            this.rdbAdminLogin.Name = "rdbAdminLogin";
            this.rdbAdminLogin.Size = new System.Drawing.Size(93, 29);
            this.rdbAdminLogin.TabIndex = 3;
            this.rdbAdminLogin.Text = "管理員";
            this.rdbAdminLogin.CheckedChanged += new System.EventHandler(this.rdbAdminLogin_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblUsername.Location = new System.Drawing.Point(85, 183);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "手機號碼";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsername.Location = new System.Drawing.Point(85, 211);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 31);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblPassword.Location = new System.Drawing.Point(85, 245);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 25);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "密碼";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(85, 281);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(80, 348);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 40);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginError
            // 
            this.lblLoginError.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblLoginError.Location = new System.Drawing.Point(80, 270);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(240, 18);
            this.lblLoginError.TabIndex = 8;
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginError.Visible = false;
            // 
            // timerlogin
            // 
            this.timerlogin.Interval = 60000;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(86, 315);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(223, 19);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "帳號密碼錯誤，請注意大小寫 。";
            this.lblError.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rdbAdminLogin);
            this.Controls.Add(this.rdbMemberLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogoLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdbMemberLogin;
        private System.Windows.Forms.RadioButton rdbAdminLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Timer timerlogin;
        private System.Windows.Forms.Label lblError;
    }
}