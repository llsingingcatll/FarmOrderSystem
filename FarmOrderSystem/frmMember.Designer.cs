namespace FarmOrderSystem
{
    partial class frmMember
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.grpMemberEdit = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.txtMemberNote = new System.Windows.Forms.TextBox();
            this.lblNoteL = new System.Windows.Forms.Label();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.lblAddressL = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdayL = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.lblEmailL = new System.Windows.Forms.Label();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneL = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblNameL = new System.Windows.Forms.Label();
            this.txtMemberNo = new System.Windows.Forms.TextBox();
            this.lblNoL = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.grpMemberEdit.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.Controls.Add(this.btnDeleteMember);
            this.pnlLeft.Controls.Add(this.btnNewMember);
            this.pnlLeft.Controls.Add(this.dgvMemberList);
            this.pnlLeft.Controls.Add(this.btnShowAll);
            this.pnlLeft.Controls.Add(this.btnSearchMember);
            this.pnlLeft.Controls.Add(this.txtSearchMember);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(390, 700);
            this.pnlLeft.TabIndex = 0;
            //
            // txtSearchMember
            //
            this.txtSearchMember.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtSearchMember.Location = new System.Drawing.Point(8, 8);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(220, 24);
            this.txtSearchMember.TabIndex = 0;
            //
            // btnSearchMember
            //
            this.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(234, 8);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(58, 26);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "搜尋";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            //
            // btnShowAll
            //
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(298, 8);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(70, 26);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "顯示全部";
            this.btnShowAll.UseVisualStyleBackColor = false;
            //
            // dgvMemberList
            //
            this.dgvMemberList.AllowUserToAddRows = false;
            this.dgvMemberList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMemberList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMemberList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvMemberList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMemberList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMemberList.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvMemberList.ColumnHeadersHeight = 30;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberList.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.dgvMemberList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvMemberList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.dgvMemberList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.dgvMemberList.GridColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvMemberList.Location = new System.Drawing.Point(8, 40);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersVisible = false;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(366, 600);
            this.dgvMemberList.TabIndex = 3;
            //
            // btnNewMember
            //
            this.btnNewMember.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnNewMember.FlatAppearance.BorderSize = 0;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.Location = new System.Drawing.Point(8, 648);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(178, 32);
            this.btnNewMember.TabIndex = 4;
            this.btnNewMember.Text = "新增會員";
            this.btnNewMember.UseVisualStyleBackColor = false;
            //
            // btnDeleteMember
            //
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(196, 648);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(178, 32);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "刪除會員";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            //
            // grpMemberEdit
            //
            this.grpMemberEdit.BackColor = System.Drawing.Color.White;
            this.grpMemberEdit.Controls.Add(this.btnCancelEdit);
            this.grpMemberEdit.Controls.Add(this.btnSaveMember);
            this.grpMemberEdit.Controls.Add(this.txtMemberNote);
            this.grpMemberEdit.Controls.Add(this.lblNoteL);
            this.grpMemberEdit.Controls.Add(this.txtTotalPurchase);
            this.grpMemberEdit.Controls.Add(this.lblTotalL);
            this.grpMemberEdit.Controls.Add(this.txtMemberAddress);
            this.grpMemberEdit.Controls.Add(this.lblAddressL);
            this.grpMemberEdit.Controls.Add(this.dtpBirthday);
            this.grpMemberEdit.Controls.Add(this.lblBirthdayL);
            this.grpMemberEdit.Controls.Add(this.txtMemberEmail);
            this.grpMemberEdit.Controls.Add(this.lblEmailL);
            this.grpMemberEdit.Controls.Add(this.txtMemberPhone);
            this.grpMemberEdit.Controls.Add(this.lblPhoneL);
            this.grpMemberEdit.Controls.Add(this.txtMemberName);
            this.grpMemberEdit.Controls.Add(this.lblNameL);
            this.grpMemberEdit.Controls.Add(this.txtMemberNo);
            this.grpMemberEdit.Controls.Add(this.lblNoL);
            this.grpMemberEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMemberEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpMemberEdit.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.grpMemberEdit.Location = new System.Drawing.Point(390, 0);
            this.grpMemberEdit.Name = "grpMemberEdit";
            this.grpMemberEdit.Padding = new System.Windows.Forms.Padding(12);
            this.grpMemberEdit.Size = new System.Drawing.Size(710, 700);
            this.grpMemberEdit.TabIndex = 1;
            this.grpMemberEdit.TabStop = false;
            this.grpMemberEdit.Text = "會員資料編輯";
            //
            // lblNoL
            //
            this.lblNoL.AutoSize = true;
            this.lblNoL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNoL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblNoL.Location = new System.Drawing.Point(16, 38);
            this.lblNoL.Name = "lblNoL";
            this.lblNoL.Size = new System.Drawing.Size(60, 17);
            this.lblNoL.TabIndex = 0;
            this.lblNoL.Text = "會員編號";
            //
            // txtMemberNo
            //
            this.txtMemberNo.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtMemberNo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberNo.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.txtMemberNo.Location = new System.Drawing.Point(100, 35);
            this.txtMemberNo.Name = "txtMemberNo";
            this.txtMemberNo.ReadOnly = true;
            this.txtMemberNo.Size = new System.Drawing.Size(160, 24);
            this.txtMemberNo.TabIndex = 1;
            //
            // lblNameL
            //
            this.lblNameL.AutoSize = true;
            this.lblNameL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNameL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblNameL.Location = new System.Drawing.Point(16, 72);
            this.lblNameL.Name = "lblNameL";
            this.lblNameL.Size = new System.Drawing.Size(48, 17);
            this.lblNameL.TabIndex = 2;
            this.lblNameL.Text = "姓名 *";
            //
            // txtMemberName
            //
            this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberName.Location = new System.Drawing.Point(100, 69);
            this.txtMemberName.MaxLength = 100;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 24);
            this.txtMemberName.TabIndex = 3;
            //
            // lblPhoneL
            //
            this.lblPhoneL.AutoSize = true;
            this.lblPhoneL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPhoneL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblPhoneL.Location = new System.Drawing.Point(16, 106);
            this.lblPhoneL.Name = "lblPhoneL";
            this.lblPhoneL.Size = new System.Drawing.Size(48, 17);
            this.lblPhoneL.TabIndex = 4;
            this.lblPhoneL.Text = "手機 *";
            //
            // txtMemberPhone
            //
            this.txtMemberPhone.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberPhone.Location = new System.Drawing.Point(100, 103);
            this.txtMemberPhone.MaxLength = 10;
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(160, 24);
            this.txtMemberPhone.TabIndex = 5;
            //
            // lblEmailL
            //
            this.lblEmailL.AutoSize = true;
            this.lblEmailL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblEmailL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblEmailL.Location = new System.Drawing.Point(16, 140);
            this.lblEmailL.Name = "lblEmailL";
            this.lblEmailL.Size = new System.Drawing.Size(42, 17);
            this.lblEmailL.TabIndex = 6;
            this.lblEmailL.Text = "Email";
            //
            // txtMemberEmail
            //
            this.txtMemberEmail.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberEmail.Location = new System.Drawing.Point(100, 137);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(260, 24);
            this.txtMemberEmail.TabIndex = 7;
            //
            // lblBirthdayL
            //
            this.lblBirthdayL.AutoSize = true;
            this.lblBirthdayL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblBirthdayL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblBirthdayL.Location = new System.Drawing.Point(16, 174);
            this.lblBirthdayL.Name = "lblBirthdayL";
            this.lblBirthdayL.Size = new System.Drawing.Size(36, 17);
            this.lblBirthdayL.TabIndex = 8;
            this.lblBirthdayL.Text = "生日";
            //
            // dtpBirthday
            //
            this.dtpBirthday.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(100, 171);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.ShowCheckBox = true;
            this.dtpBirthday.Size = new System.Drawing.Size(160, 24);
            this.dtpBirthday.TabIndex = 9;
            //
            // lblAddressL
            //
            this.lblAddressL.AutoSize = true;
            this.lblAddressL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblAddressL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblAddressL.Location = new System.Drawing.Point(16, 208);
            this.lblAddressL.Name = "lblAddressL";
            this.lblAddressL.Size = new System.Drawing.Size(36, 17);
            this.lblAddressL.TabIndex = 10;
            this.lblAddressL.Text = "地址";
            //
            // txtMemberAddress
            //
            this.txtMemberAddress.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberAddress.Location = new System.Drawing.Point(100, 205);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(360, 24);
            this.txtMemberAddress.TabIndex = 11;
            //
            // lblTotalL
            //
            this.lblTotalL.AutoSize = true;
            this.lblTotalL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblTotalL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblTotalL.Location = new System.Drawing.Point(16, 242);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(60, 17);
            this.lblTotalL.TabIndex = 12;
            this.lblTotalL.Text = "累計消費";
            //
            // txtTotalPurchase
            //
            this.txtTotalPurchase.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtTotalPurchase.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtTotalPurchase.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.txtTotalPurchase.Location = new System.Drawing.Point(100, 239);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.ReadOnly = true;
            this.txtTotalPurchase.Size = new System.Drawing.Size(160, 24);
            this.txtTotalPurchase.TabIndex = 13;
            this.txtTotalPurchase.Text = "NT$ 0";
            //
            // lblNoteL
            //
            this.lblNoteL.AutoSize = true;
            this.lblNoteL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNoteL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblNoteL.Location = new System.Drawing.Point(16, 276);
            this.lblNoteL.Name = "lblNoteL";
            this.lblNoteL.Size = new System.Drawing.Size(36, 17);
            this.lblNoteL.TabIndex = 14;
            this.lblNoteL.Text = "備註";
            //
            // txtMemberNote
            //
            this.txtMemberNote.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtMemberNote.Location = new System.Drawing.Point(100, 273);
            this.txtMemberNote.Multiline = true;
            this.txtMemberNote.Name = "txtMemberNote";
            this.txtMemberNote.Size = new System.Drawing.Size(360, 60);
            this.txtMemberNote.TabIndex = 15;
            //
            // btnSaveMember
            //
            this.btnSaveMember.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSaveMember.FlatAppearance.BorderSize = 0;
            this.btnSaveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMember.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveMember.ForeColor = System.Drawing.Color.White;
            this.btnSaveMember.Location = new System.Drawing.Point(100, 350);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(120, 36);
            this.btnSaveMember.TabIndex = 16;
            this.btnSaveMember.Text = "儲存";
            this.btnSaveMember.UseVisualStyleBackColor = false;
            //
            // btnCancelEdit
            //
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(230, 350);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(120, 36);
            this.btnCancelEdit.TabIndex = 17;
            this.btnCancelEdit.Text = "取消";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            //
            // frmMember
            //
            this.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.grpMemberEdit);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "會員資料管理";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.grpMemberEdit.ResumeLayout(false);
            this.grpMemberEdit.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.GroupBox grpMemberEdit;
        private System.Windows.Forms.Label lblNoL;
        private System.Windows.Forms.TextBox txtMemberNo;
        private System.Windows.Forms.Label lblNameL;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblPhoneL;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.Label lblEmailL;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.Label lblBirthdayL;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblAddressL;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.Label lblTotalL;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        private System.Windows.Forms.Label lblNoteL;
        private System.Windows.Forms.TextBox txtMemberNote;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}