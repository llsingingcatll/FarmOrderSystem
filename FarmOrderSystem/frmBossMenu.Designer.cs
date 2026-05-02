namespace FarmOrderSystem
{
    partial class frmBossMenu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblLogoMenu = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.lblMenuTitle);
            this.pnlHeader.Controls.Add(this.lblLogoMenu);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(82, 10);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(300, 30);
            this.lblMenuTitle.TabIndex = 1;
            this.lblMenuTitle.Text = "小農管理後台";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLogoMenu
            // 
            this.lblLogoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblLogoMenu.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogoMenu.ForeColor = System.Drawing.Color.White;
            this.lblLogoMenu.Location = new System.Drawing.Point(16, 12);
            this.lblLogoMenu.Name = "lblLogoMenu";
            this.lblLogoMenu.Size = new System.Drawing.Size(56, 56);
            this.lblLogoMenu.TabIndex = 0;
            this.lblLogoMenu.Text = "農";
            this.lblLogoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 90);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(340, 20);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "請選擇功能";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnOrderQuery.FlatAppearance.BorderSize = 0;
            this.btnOrderQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderQuery.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.btnOrderQuery.ForeColor = System.Drawing.Color.White;
            this.btnOrderQuery.Location = new System.Drawing.Point(40, 120);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(320, 48);
            this.btnOrderQuery.TabIndex = 2;
            this.btnOrderQuery.Text = "訂單查詢管理";
            this.btnOrderQuery.UseVisualStyleBackColor = false;
            this.btnOrderQuery.Click += new System.EventHandler(this.btnOrderQuery_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(40, 178);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(320, 48);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "報表統計";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(40, 236);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(320, 48);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "會員管理";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(40, 294);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(320, 48);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "產品上下架管理";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(40, 352);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(320, 48);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "折扣方案管理";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(40, 420);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(320, 38);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmBossMenu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnOrderQuery);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBossMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理後台 - 小農管理系統";
            this.Load += new System.EventHandler(this.frmBossMenu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogoMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnLogout;
    }
}