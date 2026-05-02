namespace FarmOrderSystem
{
    partial class frmProduct
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
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.grpProductEdit = new System.Windows.Forms.GroupBox();
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.rdbOffShelf = new System.Windows.Forms.RadioButton();
            this.rdbOnShelf = new System.Windows.Forms.RadioButton();
            this.lblShelfL = new System.Windows.Forms.Label();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.picProductEdit = new System.Windows.Forms.PictureBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.lblDescL = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblUnitL = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPriceL = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lblOriginL = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblNameL = new System.Windows.Forms.Label();
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.lblNoL = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.grpProductEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.Controls.Add(this.btnNewProduct);
            this.pnlLeft.Controls.Add(this.dgvProductList);
            this.pnlLeft.Controls.Add(this.cboFilterStatus);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(300, 800);
            this.pnlLeft.TabIndex = 0;
            //
            // cboFilterStatus
            //
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
                "全部",
                "上架中",
                "已下架"});
            this.cboFilterStatus.Location = new System.Drawing.Point(8, 8);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(120, 25);
            this.cboFilterStatus.TabIndex = 0;
            //
            // dgvProductList
            //
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvProductList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProductList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductList.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.dgvProductList.ColumnHeadersHeight = 30;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductList.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.dgvProductList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvProductList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.dgvProductList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.dgvProductList.GridColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.dgvProductList.Location = new System.Drawing.Point(8, 40);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(282, 716);
            this.dgvProductList.TabIndex = 1;
            //
            // btnNewProduct
            //
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(8, 762);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(282, 30);
            this.btnNewProduct.TabIndex = 2;
            this.btnNewProduct.Text = "新增產品";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            //
            // grpProductEdit
            //
            this.grpProductEdit.BackColor = System.Drawing.Color.White;
            this.grpProductEdit.Controls.Add(this.btnCancelProd);
            this.grpProductEdit.Controls.Add(this.btnDeleteProduct);
            this.grpProductEdit.Controls.Add(this.btnSaveProduct);
            this.grpProductEdit.Controls.Add(this.rdbOffShelf);
            this.grpProductEdit.Controls.Add(this.rdbOnShelf);
            this.grpProductEdit.Controls.Add(this.lblShelfL);
            this.grpProductEdit.Controls.Add(this.lblImagePath);
            this.grpProductEdit.Controls.Add(this.btnSelectImage);
            this.grpProductEdit.Controls.Add(this.picProductEdit);
            this.grpProductEdit.Controls.Add(this.txtProductDesc);
            this.grpProductEdit.Controls.Add(this.lblDescL);
            this.grpProductEdit.Controls.Add(this.cboUnit);
            this.grpProductEdit.Controls.Add(this.lblUnitL);
            this.grpProductEdit.Controls.Add(this.nudPrice);
            this.grpProductEdit.Controls.Add(this.lblPriceL);
            this.grpProductEdit.Controls.Add(this.txtOrigin);
            this.grpProductEdit.Controls.Add(this.lblOriginL);
            this.grpProductEdit.Controls.Add(this.txtProductName);
            this.grpProductEdit.Controls.Add(this.lblNameL);
            this.grpProductEdit.Controls.Add(this.txtProductNo);
            this.grpProductEdit.Controls.Add(this.lblNoL);
            this.grpProductEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProductEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpProductEdit.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.grpProductEdit.Location = new System.Drawing.Point(300, 0);
            this.grpProductEdit.Name = "grpProductEdit";
            this.grpProductEdit.Padding = new System.Windows.Forms.Padding(12);
            this.grpProductEdit.Size = new System.Drawing.Size(900, 800);
            this.grpProductEdit.TabIndex = 1;
            this.grpProductEdit.TabStop = false;
            this.grpProductEdit.Text = "產品編輯";
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
            this.lblNoL.Text = "產品編號";
            //
            // txtProductNo
            //
            this.txtProductNo.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtProductNo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtProductNo.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.txtProductNo.Location = new System.Drawing.Point(100, 35);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.ReadOnly = true;
            this.txtProductNo.Size = new System.Drawing.Size(80, 24);
            this.txtProductNo.TabIndex = 1;
            //
            // lblNameL
            //
            this.lblNameL.AutoSize = true;
            this.lblNameL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNameL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblNameL.Location = new System.Drawing.Point(16, 72);
            this.lblNameL.Name = "lblNameL";
            this.lblNameL.Size = new System.Drawing.Size(60, 17);
            this.lblNameL.TabIndex = 2;
            this.lblNameL.Text = "產品名稱";
            //
            // txtProductName
            //
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtProductName.Location = new System.Drawing.Point(100, 69);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 24);
            this.txtProductName.TabIndex = 3;
            //
            // lblOriginL
            //
            this.lblOriginL.AutoSize = true;
            this.lblOriginL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblOriginL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblOriginL.Location = new System.Drawing.Point(16, 106);
            this.lblOriginL.Name = "lblOriginL";
            this.lblOriginL.Size = new System.Drawing.Size(36, 17);
            this.lblOriginL.TabIndex = 4;
            this.lblOriginL.Text = "產地";
            //
            // txtOrigin
            //
            this.txtOrigin.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtOrigin.Location = new System.Drawing.Point(100, 103);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(180, 24);
            this.txtOrigin.TabIndex = 5;
            //
            // lblPriceL
            //
            this.lblPriceL.AutoSize = true;
            this.lblPriceL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPriceL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblPriceL.Location = new System.Drawing.Point(16, 140);
            this.lblPriceL.Name = "lblPriceL";
            this.lblPriceL.Size = new System.Drawing.Size(72, 17);
            this.lblPriceL.TabIndex = 6;
            this.lblPriceL.Text = "單價 NT$";
            //
            // nudPrice
            //
            this.nudPrice.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.nudPrice.Location = new System.Drawing.Point(100, 137);
            this.nudPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.nudPrice.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(90, 24);
            this.nudPrice.TabIndex = 7;
            //
            // lblUnitL
            //
            this.lblUnitL.AutoSize = true;
            this.lblUnitL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblUnitL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblUnitL.Location = new System.Drawing.Point(16, 174);
            this.lblUnitL.Name = "lblUnitL";
            this.lblUnitL.Size = new System.Drawing.Size(36, 17);
            this.lblUnitL.TabIndex = 8;
            this.lblUnitL.Text = "單位";
            //
            // cboUnit
            //
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
                "把",
                "顆",
                "包",
                "箱"});
            this.cboUnit.Location = new System.Drawing.Point(100, 171);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(80, 25);
            this.cboUnit.TabIndex = 9;
            //
            // lblDescL
            //
            this.lblDescL.AutoSize = true;
            this.lblDescL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblDescL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblDescL.Location = new System.Drawing.Point(16, 208);
            this.lblDescL.Name = "lblDescL";
            this.lblDescL.Size = new System.Drawing.Size(60, 17);
            this.lblDescL.TabIndex = 10;
            this.lblDescL.Text = "產品描述";
            //
            // txtProductDesc
            //
            this.txtProductDesc.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.txtProductDesc.Location = new System.Drawing.Point(100, 205);
            this.txtProductDesc.Multiline = true;
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(400, 70);
            this.txtProductDesc.TabIndex = 11;
            //
            // picProductEdit
            //
            this.picProductEdit.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.picProductEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductEdit.Location = new System.Drawing.Point(16, 290);
            this.picProductEdit.Name = "picProductEdit";
            this.picProductEdit.Size = new System.Drawing.Size(160, 120);
            this.picProductEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductEdit.TabIndex = 12;
            this.picProductEdit.TabStop = false;
            //
            // btnSelectImage
            //
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(16, 416);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(160, 26);
            this.btnSelectImage.TabIndex = 13;
            this.btnSelectImage.Text = "選擇圖片 (選填)";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            //
            // lblImagePath
            //
            this.lblImagePath.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.lblImagePath.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117);
            this.lblImagePath.Location = new System.Drawing.Point(16, 446);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(500, 16);
            this.lblImagePath.TabIndex = 14;
            this.lblImagePath.Text = "未選擇圖片 (預設: Images/default_product.png)";
            //
            // lblShelfL
            //
            this.lblShelfL.AutoSize = true;
            this.lblShelfL.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblShelfL.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66);
            this.lblShelfL.Location = new System.Drawing.Point(16, 476);
            this.lblShelfL.Name = "lblShelfL";
            this.lblShelfL.Size = new System.Drawing.Size(60, 17);
            this.lblShelfL.TabIndex = 15;
            this.lblShelfL.Text = "上下架";
            //
            // rdbOnShelf
            //
            this.rdbOnShelf.AutoSize = true;
            this.rdbOnShelf.Checked = true;
            this.rdbOnShelf.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.rdbOnShelf.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.rdbOnShelf.Location = new System.Drawing.Point(100, 474);
            this.rdbOnShelf.Name = "rdbOnShelf";
            this.rdbOnShelf.Size = new System.Drawing.Size(68, 21);
            this.rdbOnShelf.TabIndex = 16;
            this.rdbOnShelf.TabStop = true;
            this.rdbOnShelf.Text = "上架中";
            //
            // rdbOffShelf
            //
            this.rdbOffShelf.AutoSize = true;
            this.rdbOffShelf.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.rdbOffShelf.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.rdbOffShelf.Location = new System.Drawing.Point(190, 474);
            this.rdbOffShelf.Name = "rdbOffShelf";
            this.rdbOffShelf.Size = new System.Drawing.Size(56, 21);
            this.rdbOffShelf.TabIndex = 17;
            this.rdbOffShelf.Text = "下架";
            //
            // btnSaveProduct
            //
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(16, 510);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 36);
            this.btnSaveProduct.TabIndex = 18;
            this.btnSaveProduct.Text = "儲存";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            //
            // btnDeleteProduct
            //
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(124, 510);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 36);
            this.btnDeleteProduct.TabIndex = 19;
            this.btnDeleteProduct.Text = "刪除產品";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            //
            // btnCancelProd
            //
            this.btnCancelProd.BackColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.btnCancelProd.FlatAppearance.BorderSize = 0;
            this.btnCancelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelProd.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnCancelProd.ForeColor = System.Drawing.Color.White;
            this.btnCancelProd.Location = new System.Drawing.Point(232, 510);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(100, 36);
            this.btnCancelProd.TabIndex = 20;
            this.btnCancelProd.Text = "取消";
            this.btnCancelProd.UseVisualStyleBackColor = false;
            //
            // frmProduct
            //
            this.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.grpProductEdit);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "產品管理 - 上下架";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.grpProductEdit.ResumeLayout(false);
            this.grpProductEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.GroupBox grpProductEdit;
        private System.Windows.Forms.Label lblNoL;
        private System.Windows.Forms.TextBox txtProductNo;
        private System.Windows.Forms.Label lblNameL;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblOriginL;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblPriceL;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblUnitL;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblDescL;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.PictureBox picProductEdit;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblShelfL;
        private System.Windows.Forms.RadioButton rdbOnShelf;
        private System.Windows.Forms.RadioButton rdbOffShelf;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnCancelProd;
    }
}