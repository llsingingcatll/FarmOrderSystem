namespace FarmOrderSystem
{
    partial class frmOrder : System.Windows.Forms.Form
    {
        
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList產品圖片 = new System.Windows.Forms.ImageList(this.components);
            this.lblLogoText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHot = new System.Windows.Forms.Label();
            this.lblHot1 = new System.Windows.Forms.Label();
            this.lblHot2 = new System.Windows.Forms.Label();
            this.lblHot3 = new System.Windows.Forms.Label();
            this.lblHot4 = new System.Windows.Forms.Label();
            this.lblHot5 = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.colImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAddBar = new System.Windows.Forms.Panel();
            this.lblSelectedProd = new System.Windows.Forms.Label();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblAddHint = new System.Windows.Forms.Label();
            this.pnlProductTop = new System.Windows.Forms.Panel();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStockHeader = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlCartSide = new System.Windows.Forms.Panel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lstCartPreview = new System.Windows.Forms.ListBox();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountAmtLabel = new System.Windows.Forms.Label();
            this.lblDiscountAmt = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlAddBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.pnlProductTop.SuspendLayout();
            this.pnlCartSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList產品圖片
            // 
            this.imageList產品圖片.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList產品圖片.ImageSize = new System.Drawing.Size(120, 120);
            this.imageList產品圖片.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblLogoText
            // 
            this.lblLogoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblLogoText.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(8, 8);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(44, 44);
            this.lblLogoText.TabIndex = 1;
            this.lblLogoText.Text = "農";
            this.lblLogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.btnMyAccount);
            this.pnlHeader.Controls.Add(this.btnLogin);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblLogoText);
            this.pnlHeader.Controls.Add(this.lblSystemName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnMyAccount.Location = new System.Drawing.Point(853, 12);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(153, 40);
            this.btnMyAccount.TabIndex = 6;
            this.btnMyAccount.Text = "管理我的會員";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(1033, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "會員 / 管理員登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(8, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(44, 44);
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(60, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(420, 60);
            this.lblSystemName.TabIndex = 2;
            this.lblSystemName.Text = "小農蔬菜直送 - 線上訂購";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblHot);
            this.pnlFilter.Controls.Add(this.lblHot1);
            this.pnlFilter.Controls.Add(this.lblHot2);
            this.pnlFilter.Controls.Add(this.lblHot3);
            this.pnlFilter.Controls.Add(this.lblHot4);
            this.pnlFilter.Controls.Add(this.lblHot5);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 60);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1200, 44);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblHot.Location = new System.Drawing.Point(10, 7);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(97, 24);
            this.lblHot.TabIndex = 2;
            this.lblHot.Text = "熱銷前5名";
            // 
            // lblHot1
            // 
            this.lblHot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblHot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHot1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblHot1.Location = new System.Drawing.Point(138, 7);
            this.lblHot1.Name = "lblHot1";
            this.lblHot1.Size = new System.Drawing.Size(100, 30);
            this.lblHot1.TabIndex = 3;
            this.lblHot1.Text = "---";
            this.lblHot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHot2
            // 
            this.lblHot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblHot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHot2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblHot2.Location = new System.Drawing.Point(256, 7);
            this.lblHot2.Name = "lblHot2";
            this.lblHot2.Size = new System.Drawing.Size(100, 30);
            this.lblHot2.TabIndex = 4;
            this.lblHot2.Text = "---";
            this.lblHot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHot3
            // 
            this.lblHot3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblHot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHot3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHot3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblHot3.Location = new System.Drawing.Point(378, 7);
            this.lblHot3.Name = "lblHot3";
            this.lblHot3.Size = new System.Drawing.Size(100, 30);
            this.lblHot3.TabIndex = 5;
            this.lblHot3.Text = "---";
            this.lblHot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHot4
            // 
            this.lblHot4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblHot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHot4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHot4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblHot4.Location = new System.Drawing.Point(500, 7);
            this.lblHot4.Name = "lblHot4";
            this.lblHot4.Size = new System.Drawing.Size(100, 30);
            this.lblHot4.TabIndex = 6;
            this.lblHot4.Text = "---";
            this.lblHot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHot5
            // 
            this.lblHot5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblHot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHot5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHot5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHot5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblHot5.Location = new System.Drawing.Point(618, 8);
            this.lblHot5.Name = "lblHot5";
            this.lblHot5.Size = new System.Drawing.Size(100, 30);
            this.lblHot5.TabIndex = 7;
            this.lblHot5.Text = "---";
            this.lblHot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblDiscountTitle.Location = new System.Drawing.Point(8, 399);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(78, 21);
            this.lblDiscountTitle.TabIndex = 0;
            this.lblDiscountTitle.Text = "套用優惠:";
            // 
            // cboDiscount
            // 
            this.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDiscount.Location = new System.Drawing.Point(116, 396);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(170, 28);
            this.cboDiscount.TabIndex = 1;
            this.cboDiscount.SelectedIndexChanged += new System.EventHandler(this.cboDiscount_SelectedIndexChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlCartSide);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 104);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 696);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlLeft.Controls.Add(this.lvProducts);
            this.pnlLeft.Controls.Add(this.pnlAddBar);
            this.pnlLeft.Controls.Add(this.pnlProductTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(900, 696);
            this.pnlLeft.TabIndex = 0;
            // 
            // lvProducts
            // 
            this.lvProducts.BackColor = System.Drawing.Color.White;
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImg,
            this.colNo,
            this.colName,
            this.colOrigin,
            this.colPrice,
            this.colUnit,
            this.colStock,
            this.colStatus});
            this.lvProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.LargeImageList = this.imageList產品圖片;
            this.lvProducts.Location = new System.Drawing.Point(0, 47);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(900, 597);
            this.lvProducts.SmallImageList = this.imageList產品圖片;
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            this.lvProducts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseMove);
            // 
            // colImg
            // 
            this.colImg.Text = "圖片";
            this.colImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colImg.Width = 130;
            // 
            // colNo
            // 
            this.colNo.Text = "編號";
            this.colNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNo.Width = 70;
            // 
            // colName
            // 
            this.colName.Text = "產品名稱";
            this.colName.Width = 180;
            // 
            // colOrigin
            // 
            this.colOrigin.Text = "產地";
            this.colOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOrigin.Width = 120;
            // 
            // colPrice
            // 
            this.colPrice.Text = "單價";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.Text = "單位";
            this.colUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 70;
            // 
            // colStock
            // 
            this.colStock.Text = "庫存";
            this.colStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStock.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.Text = "狀態";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 80;
            // 
            // pnlAddBar
            // 
            this.pnlAddBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.pnlAddBar.Controls.Add(this.lblSelectedProd);
            this.pnlAddBar.Controls.Add(this.lblQtyLabel);
            this.pnlAddBar.Controls.Add(this.nudQty);
            this.pnlAddBar.Controls.Add(this.btnAddToCart);
            this.pnlAddBar.Controls.Add(this.lblAddHint);
            this.pnlAddBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddBar.Location = new System.Drawing.Point(0, 644);
            this.pnlAddBar.Name = "pnlAddBar";
            this.pnlAddBar.Size = new System.Drawing.Size(900, 52);
            this.pnlAddBar.TabIndex = 1;
            // 
            // lblSelectedProd
            // 
            this.lblSelectedProd.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblSelectedProd.Location = new System.Drawing.Point(8, 16);
            this.lblSelectedProd.Name = "lblSelectedProd";
            this.lblSelectedProd.Size = new System.Drawing.Size(300, 22);
            this.lblSelectedProd.TabIndex = 0;
            this.lblSelectedProd.Text = "請先點選上方產品列";
            // 
            // lblQtyLabel
            // 
            this.lblQtyLabel.AutoSize = true;
            this.lblQtyLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblQtyLabel.Location = new System.Drawing.Point(330, 18);
            this.lblQtyLabel.Name = "lblQtyLabel";
            this.lblQtyLabel.Size = new System.Drawing.Size(40, 18);
            this.lblQtyLabel.TabIndex = 1;
            this.lblQtyLabel.Text = "數量:";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudQty.Location = new System.Drawing.Point(378, 14);
            this.nudQty.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(70, 29);
            this.nudQty.TabIndex = 2;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(460, 10);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(140, 34);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "加入購物車";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblAddHint
            // 
            this.lblAddHint.AutoSize = true;
            this.lblAddHint.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Italic);
            this.lblAddHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblAddHint.Location = new System.Drawing.Point(615, 18);
            this.lblAddHint.Name = "lblAddHint";
            this.lblAddHint.Size = new System.Drawing.Size(183, 15);
            this.lblAddHint.TabIndex = 4;
            this.lblAddHint.Text = "已加入的商品可再次加入以累加數量";
            // 
            // pnlProductTop
            // 
            this.pnlProductTop.BackColor = System.Drawing.Color.White;
            this.pnlProductTop.Controls.Add(this.lblProductTitle);
            this.pnlProductTop.Controls.Add(this.cboFilter);
            this.pnlProductTop.Controls.Add(this.txtSearch);
            this.pnlProductTop.Controls.Add(this.lblStockHeader);
            this.pnlProductTop.Controls.Add(this.btnSearch);
            this.pnlProductTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductTop.Location = new System.Drawing.Point(0, 0);
            this.pnlProductTop.Name = "pnlProductTop";
            this.pnlProductTop.Size = new System.Drawing.Size(900, 47);
            this.pnlProductTop.TabIndex = 2;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblProductTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(86, 24);
            this.lblProductTitle.TabIndex = 0;
            this.lblProductTitle.Text = "產品分類";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboFilter.Location = new System.Drawing.Point(118, 8);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(149, 28);
            this.cboFilter.TabIndex = 1;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.Location = new System.Drawing.Point(273, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblStockHeader
            // 
            this.lblStockHeader.AutoSize = true;
            this.lblStockHeader.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStockHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblStockHeader.Location = new System.Drawing.Point(569, 11);
            this.lblStockHeader.Name = "lblStockHeader";
            this.lblStockHeader.Size = new System.Drawing.Size(274, 18);
            this.lblStockHeader.TabIndex = 4;
            this.lblStockHeader.Text = "點選產品後，調整數量再按「加入購物車」";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(471, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜尋產品";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlCartSide
            // 
            this.pnlCartSide.BackColor = System.Drawing.Color.White;
            this.pnlCartSide.Controls.Add(this.cboDiscount);
            this.pnlCartSide.Controls.Add(this.lblDiscountTitle);
            this.pnlCartSide.Controls.Add(this.lblCartTitle);
            this.pnlCartSide.Controls.Add(this.lblCartCount);
            this.pnlCartSide.Controls.Add(this.lstCartPreview);
            this.pnlCartSide.Controls.Add(this.lblSubtotalLabel);
            this.pnlCartSide.Controls.Add(this.lblSubtotal);
            this.pnlCartSide.Controls.Add(this.lblDiscountAmtLabel);
            this.pnlCartSide.Controls.Add(this.lblDiscountAmt);
            this.pnlCartSide.Controls.Add(this.lblTotalLabel);
            this.pnlCartSide.Controls.Add(this.lblTotal);
            this.pnlCartSide.Controls.Add(this.btnCheckout);
            this.pnlCartSide.Controls.Add(this.btnClearCart);
            this.pnlCartSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCartSide.Location = new System.Drawing.Point(900, 0);
            this.pnlCartSide.Name = "pnlCartSide";
            this.pnlCartSide.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCartSide.Size = new System.Drawing.Size(300, 696);
            this.pnlCartSide.TabIndex = 1;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblCartTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(130, 28);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "購物清單";
            // 
            // lblCartCount
            // 
            this.lblCartCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCartCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblCartCount.Location = new System.Drawing.Point(201, 364);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(85, 29);
            this.lblCartCount.TabIndex = 1;
            this.lblCartCount.Text = "共 0 項";
            this.lblCartCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCartPreview
            // 
            this.lstCartPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.lstCartPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCartPreview.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstCartPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lstCartPreview.ItemHeight = 23;
            this.lstCartPreview.Location = new System.Drawing.Point(6, 49);
            this.lstCartPreview.Name = "lstCartPreview";
            this.lstCartPreview.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCartPreview.Size = new System.Drawing.Size(280, 278);
            this.lstCartPreview.TabIndex = 2;
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSubtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblSubtotalLabel.Location = new System.Drawing.Point(13, 440);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(192, 20);
            this.lblSubtotalLabel.TabIndex = 3;
            this.lblSubtotalLabel.Text = "小計:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblSubtotal.Location = new System.Drawing.Point(11, 440);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(280, 22);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "NT$ 0";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountAmtLabel
            // 
            this.lblDiscountAmtLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscountAmtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblDiscountAmtLabel.Location = new System.Drawing.Point(13, 475);
            this.lblDiscountAmtLabel.Name = "lblDiscountAmtLabel";
            this.lblDiscountAmtLabel.Size = new System.Drawing.Size(192, 20);
            this.lblDiscountAmtLabel.TabIndex = 5;
            this.lblDiscountAmtLabel.Text = "折扣:";
            // 
            // lblDiscountAmt
            // 
            this.lblDiscountAmt.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblDiscountAmt.Location = new System.Drawing.Point(11, 475);
            this.lblDiscountAmt.Name = "lblDiscountAmt";
            this.lblDiscountAmt.Size = new System.Drawing.Size(280, 22);
            this.lblDiscountAmt.TabIndex = 6;
            this.lblDiscountAmt.Text = "- NT$ 0";
            this.lblDiscountAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(11, 514);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(192, 20);
            this.lblTotalLabel.TabIndex = 7;
            this.lblTotalLabel.Text = "合計:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblTotal.Location = new System.Drawing.Point(11, 534);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(280, 28);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "NT$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(8, 584);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(280, 44);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "前往結帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnClearCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(6, 644);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(280, 30);
            this.btnClearCart.TabIndex = 10;
            this.btnClearCart.Text = "清空購物車";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // frmOrder
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小農蔬菜直送 - 線上訂購";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlAddBar.ResumeLayout(false);
            this.pnlAddBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.pnlProductTop.ResumeLayout(false);
            this.pnlProductTop.PerformLayout();
            this.pnlCartSide.ResumeLayout(false);
            this.pnlCartSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemName;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.Label lblHot;
        private System.Windows.Forms.Label lblHot1;
        private System.Windows.Forms.Label lblHot2;
        private System.Windows.Forms.Label lblHot3;
        private System.Windows.Forms.Label lblHot4;
        private System.Windows.Forms.Label lblHot5;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlProductTop;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblStockHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFilter;

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader colImg;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colOrigin;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader colStatus;

        private System.Windows.Forms.Panel pnlAddBar;
        private System.Windows.Forms.Label lblSelectedProd;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblAddHint;

        private System.Windows.Forms.Panel pnlCartSide;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.ListBox lstCartPreview;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountAmtLabel;
        private System.Windows.Forms.Label lblDiscountAmt;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClearCart;
        public System.Windows.Forms.ImageList imageList產品圖片;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMyAccount;
    }
}