namespace FarmOrderSystem
{
    partial class frmDiscount
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
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnNewDiscount = new System.Windows.Forms.Button();
            this.dgvDiscountList = new System.Windows.Forms.DataGridView();
            this.grpDiscountEdit = new System.Windows.Forms.GroupBox();
            this.btnCancelDiscount = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.nudSortOrder = new System.Windows.Forms.NumericUpDown();
            this.lblSortL = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.chkIsBogo = new System.Windows.Forms.CheckBox();
            this.lblRateNote = new System.Windows.Forms.Label();
            this.nudDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.lblRateL = new System.Windows.Forms.Label();
            this.nudMinAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmtL = new System.Windows.Forms.Label();
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.lblTypeL = new System.Windows.Forms.Label();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            this.lblNameL = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountList)).BeginInit();
            this.grpDiscountEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAmount)).BeginInit();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.Controls.Add(this.btnDeleteDiscount);
            this.pnlLeft.Controls.Add(this.btnNewDiscount);
            this.pnlLeft.Controls.Add(this.dgvDiscountList);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(270, 650);
            this.pnlLeft.TabIndex = 0;
            //
            // dgvDiscountList
            //
            this.dgvDiscountList.AllowUserToAddRows = false;
            this.dgvDiscountList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDiscountList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscountList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvDiscountList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDiscountList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscountList.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvDiscountList.ColumnHeadersHeight = 30;
            this.dgvDiscountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiscountList.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.dgvDiscountList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvDiscountList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.dgvDiscountList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.dgvDiscountList.GridColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvDiscountList.Location = new System.Drawing.Point(8, 8);
            this.dgvDiscountList.Name = "dgvDiscountList";
            this.dgvDiscountList.ReadOnly = true;
            this.dgvDiscountList.RowHeadersVisible = false;
            this.dgvDiscountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscountList.Size = new System.Drawing.Size(252, 562);
            this.dgvDiscountList.TabIndex = 0;
            //
            // btnNewDiscount
            //
            this.btnNewDiscount.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnNewDiscount.FlatAppearance.BorderSize = 0;
            this.btnNewDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDiscount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewDiscount.ForeColor = System.Drawing.Color.White;
            this.btnNewDiscount.Location = new System.Drawing.Point(8, 576);
            this.btnNewDiscount.Name = "btnNewDiscount";
            this.btnNewDiscount.Size = new System.Drawing.Size(122, 30);
            this.btnNewDiscount.TabIndex = 1;
            this.btnNewDiscount.Text = "新增折扣";
            this.btnNewDiscount.UseVisualStyleBackColor = false;
            //
            // btnDeleteDiscount
            //
            this.btnDeleteDiscount.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteDiscount.FlatAppearance.BorderSize = 0;
            this.btnDeleteDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.Location = new System.Drawing.Point(138, 576);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(122, 30);
            this.btnDeleteDiscount.TabIndex = 2;
            this.btnDeleteDiscount.Text = "刪除";
            this.btnDeleteDiscount.UseVisualStyleBackColor = false;
            //
            // grpDiscountEdit
            //
            this.grpDiscountEdit.BackColor = System.Drawing.Color.White;
            this.grpDiscountEdit.Controls.Add(this.btnCancelDiscount);
            this.grpDiscountEdit.Controls.Add(this.btnSaveDiscount);
            this.grpDiscountEdit.Controls.Add(this.nudSortOrder);
            this.grpDiscountEdit.Controls.Add(this.lblSortL);
            this.grpDiscountEdit.Controls.Add(this.chkIsActive);
            this.grpDiscountEdit.Controls.Add(this.chkIsBogo);
            this.grpDiscountEdit.Controls.Add(this.lblRateNote);
            this.grpDiscountEdit.Controls.Add(this.nudDiscountRate);
            this.grpDiscountEdit.Controls.Add(this.lblRateL);
            this.grpDiscountEdit.Controls.Add(this.nudMinAmount);
            this.grpDiscountEdit.Controls.Add(this.lblAmtL);
            this.grpDiscountEdit.Controls.Add(this.cboDiscountType);
            this.grpDiscountEdit.Controls.Add(this.lblTypeL);
            this.grpDiscountEdit.Controls.Add(this.txtDiscountName);
            this.grpDiscountEdit.Controls.Add(this.lblNameL);
            this.grpDiscountEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDiscountEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpDiscountEdit.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.grpDiscountEdit.Location = new System.Drawing.Point(270, 0);
            this.grpDiscountEdit.Name = "grpDiscountEdit";
            this.grpDiscountEdit.Padding = new System.Windows.Forms.Padding(12);
            this.grpDiscountEdit.Size = new System.Drawing.Size(630, 650);
            this.grpDiscountEdit.TabIndex = 1;
            this.grpDiscountEdit.TabStop = false;
            this.grpDiscountEdit.Text = "折扣編輯";
            //
            // lblNameL
            //
            this.lblNameL.AutoSize = true;
            this.lblNameL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNameL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblNameL.Location = new System.Drawing.Point(16, 38);
            this.lblNameL.Name = "lblNameL";
            this.lblNameL.Size = new System.Drawing.Size(72, 17);
            this.lblNameL.TabIndex = 0;
            this.lblNameL.Text = "折扣名稱 *";
            //
            // txtDiscountName
            //
            this.txtDiscountName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtDiscountName.Location = new System.Drawing.Point(110, 35);
            this.txtDiscountName.MaxLength = 100;
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(260, 24);
            this.txtDiscountName.TabIndex = 1;
            //
            // lblTypeL
            //
            this.lblTypeL.AutoSize = true;
            this.lblTypeL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblTypeL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblTypeL.Location = new System.Drawing.Point(16, 74);
            this.lblTypeL.Name = "lblTypeL";
            this.lblTypeL.Size = new System.Drawing.Size(36, 17);
            this.lblTypeL.TabIndex = 2;
            this.lblTypeL.Text = "類型";
            //
            // cboDiscountType
            //
            this.cboDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscountType.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Items.AddRange(new object[] {
                "不折扣",
                "買一送一",
                "滿額打折"});
            this.cboDiscountType.Location = new System.Drawing.Point(110, 71);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(180, 25);
            this.cboDiscountType.TabIndex = 3;
            //
            // lblAmtL
            //
            this.lblAmtL.AutoSize = true;
            this.lblAmtL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblAmtL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblAmtL.Location = new System.Drawing.Point(16, 112);
            this.lblAmtL.Name = "lblAmtL";
            this.lblAmtL.Size = new System.Drawing.Size(72, 17);
            this.lblAmtL.TabIndex = 4;
            this.lblAmtL.Text = "消費門檻";
            //
            // nudMinAmount
            //
            this.nudMinAmount.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.nudMinAmount.Location = new System.Drawing.Point(110, 109);
            this.nudMinAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudMinAmount.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudMinAmount.Name = "nudMinAmount";
            this.nudMinAmount.Size = new System.Drawing.Size(100, 24);
            this.nudMinAmount.TabIndex = 5;
            //
            // lblRateL
            //
            this.lblRateL.AutoSize = true;
            this.lblRateL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblRateL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblRateL.Location = new System.Drawing.Point(16, 148);
            this.lblRateL.Name = "lblRateL";
            this.lblRateL.Size = new System.Drawing.Size(60, 17);
            this.lblRateL.TabIndex = 6;
            this.lblRateL.Text = "折扣率 %";
            //
            // nudDiscountRate
            //
            this.nudDiscountRate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.nudDiscountRate.Location = new System.Drawing.Point(110, 145);
            this.nudDiscountRate.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudDiscountRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiscountRate.Name = "nudDiscountRate";
            this.nudDiscountRate.Size = new System.Drawing.Size(80, 24);
            this.nudDiscountRate.TabIndex = 7;
            this.nudDiscountRate.Value = new decimal(new int[] { 100, 0, 0, 0 });
            //
            // lblRateNote
            //
            this.lblRateNote.AutoSize = true;
            this.lblRateNote.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Italic);
            this.lblRateNote.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblRateNote.Location = new System.Drawing.Point(198, 150);
            this.lblRateNote.Name = "lblRateNote";
            this.lblRateNote.Size = new System.Drawing.Size(156, 13);
            this.lblRateNote.TabIndex = 8;
            this.lblRateNote.Text = "(買一送一時此欄無效)";
            //
            // chkIsBogo
            //
            this.chkIsBogo.AutoSize = true;
            this.chkIsBogo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.chkIsBogo.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.chkIsBogo.Location = new System.Drawing.Point(16, 184);
            this.chkIsBogo.Name = "chkIsBogo";
            this.chkIsBogo.Size = new System.Drawing.Size(220, 21);
            this.chkIsBogo.TabIndex = 9;
            this.chkIsBogo.Text = "買一送一 (勾選後門檻/折扣率停用)";
            //
            // chkIsActive
            //
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.chkIsActive.Location = new System.Drawing.Point(16, 216);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(92, 21);
            this.chkIsActive.TabIndex = 10;
            this.chkIsActive.Text = "啟用此方案";
            //
            // lblSortL
            //
            this.lblSortL.AutoSize = true;
            this.lblSortL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblSortL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblSortL.Location = new System.Drawing.Point(16, 252);
            this.lblSortL.Name = "lblSortL";
            this.lblSortL.Size = new System.Drawing.Size(36, 17);
            this.lblSortL.TabIndex = 11;
            this.lblSortL.Text = "排序";
            //
            // nudSortOrder
            //
            this.nudSortOrder.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.nudSortOrder.Location = new System.Drawing.Point(110, 249);
            this.nudSortOrder.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.nudSortOrder.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudSortOrder.Name = "nudSortOrder";
            this.nudSortOrder.Size = new System.Drawing.Size(70, 24);
            this.nudSortOrder.TabIndex = 12;
            //
            // btnSaveDiscount
            //
            this.btnSaveDiscount.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSaveDiscount.FlatAppearance.BorderSize = 0;
            this.btnSaveDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDiscount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveDiscount.ForeColor = System.Drawing.Color.White;
            this.btnSaveDiscount.Location = new System.Drawing.Point(16, 292);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(110, 36);
            this.btnSaveDiscount.TabIndex = 13;
            this.btnSaveDiscount.Text = "儲存";
            this.btnSaveDiscount.UseVisualStyleBackColor = false;
            //
            // btnCancelDiscount
            //
            this.btnCancelDiscount.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnCancelDiscount.FlatAppearance.BorderSize = 0;
            this.btnCancelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDiscount.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnCancelDiscount.ForeColor = System.Drawing.Color.White;
            this.btnCancelDiscount.Location = new System.Drawing.Point(134, 292);
            this.btnCancelDiscount.Name = "btnCancelDiscount";
            this.btnCancelDiscount.Size = new System.Drawing.Size(110, 36);
            this.btnCancelDiscount.TabIndex = 14;
            this.btnCancelDiscount.Text = "取消";
            this.btnCancelDiscount.UseVisualStyleBackColor = false;
            //
            // frmDiscount
            //
            this.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.grpDiscountEdit);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "折扣方案管理";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountList)).EndInit();
            this.grpDiscountEdit.ResumeLayout(false);
            this.grpDiscountEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAmount)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.DataGridView dgvDiscountList;
        private System.Windows.Forms.Button btnNewDiscount;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.GroupBox grpDiscountEdit;
        private System.Windows.Forms.Label lblNameL;
        private System.Windows.Forms.TextBox txtDiscountName;
        private System.Windows.Forms.Label lblTypeL;
        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.Label lblAmtL;
        private System.Windows.Forms.NumericUpDown nudMinAmount;
        private System.Windows.Forms.Label lblRateL;
        private System.Windows.Forms.NumericUpDown nudDiscountRate;
        private System.Windows.Forms.Label lblRateNote;
        private System.Windows.Forms.CheckBox chkIsBogo;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblSortL;
        private System.Windows.Forms.NumericUpDown nudSortOrder;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.Button btnCancelDiscount;
    }
}