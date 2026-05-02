namespace FarmOrderSystem
{
    partial class frmCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpPickupType = new System.Windows.Forms.GroupBox();
            this.pnlDeliveryInfo = new System.Windows.Forms.Panel();
            this.cboDeliveryCity = new System.Windows.Forms.ComboBox();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.txtDeliveryNote = new System.Windows.Forms.TextBox();
            this.lblDeliveryNote = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.cboDeliveryDistrict = new System.Windows.Forms.ComboBox();
            this.lblDeliveryAddr = new System.Windows.Forms.Label();
            this.txtDeliveryPhone = new System.Windows.Forms.TextBox();
            this.lblDeliveryPhone = new System.Windows.Forms.Label();
            this.txtDeliveryName = new System.Windows.Forms.TextBox();
            this.lblDeliveryName = new System.Windows.Forms.Label();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
            this.rdbOnSite = new System.Windows.Forms.RadioButton();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblAutoDetect = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpMemberLogin = new System.Windows.Forms.GroupBox();
            this.pnlMemberSection = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMemberPssswordHint = new System.Windows.Forms.Label();
            this.btnLoginMember = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMemberPhoneHint = new System.Windows.Forms.Label();
            this.rdbMember = new System.Windows.Forms.RadioButton();
            this.rdbGuest = new System.Windows.Forms.RadioButton();
            this.grpOrderDetail = new System.Windows.Forms.GroupBox();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.dgvCartItems = new System.Windows.Forms.DataGridView();
            this.產品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小計 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBackToOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.txtOrderNote = new System.Windows.Forms.TextBox();
            this.lblNoteLabel = new System.Windows.Forms.Label();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.lblPaymentLabel = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblFinalLabel = new System.Windows.Forms.Label();
            this.crownStatusStrip1 = new ReaLTaiizor.Controls.CrownStatusStrip();
            this.timerShoppingcar = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.grpPickupType.SuspendLayout();
            this.pnlDeliveryInfo.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpMemberLogin.SuspendLayout();
            this.pnlMemberSection.SuspendLayout();
            this.grpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.grpPickupType);
            this.pnlLeft.Controls.Add(this.grpCustomer);
            this.pnlLeft.Controls.Add(this.grpMemberLogin);
            this.pnlLeft.Controls.Add(this.grpOrderDetail);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.pnlLeft.Size = new System.Drawing.Size(670, 750);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpPickupType
            // 
            this.grpPickupType.BackColor = System.Drawing.Color.White;
            this.grpPickupType.Controls.Add(this.pnlDeliveryInfo);
            this.grpPickupType.Controls.Add(this.rdbDelivery);
            this.grpPickupType.Controls.Add(this.rdbOnSite);
            this.grpPickupType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpPickupType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpPickupType.Location = new System.Drawing.Point(10, 437);
            this.grpPickupType.Name = "grpPickupType";
            this.grpPickupType.Size = new System.Drawing.Size(648, 286);
            this.grpPickupType.TabIndex = 3;
            this.grpPickupType.TabStop = false;
            this.grpPickupType.Text = "取貨方式";
            // 
            // pnlDeliveryInfo
            // 
            this.pnlDeliveryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.pnlDeliveryInfo.Controls.Add(this.cboDeliveryCity);
            this.pnlDeliveryInfo.Controls.Add(this.lblDeliveryFee);
            this.pnlDeliveryInfo.Controls.Add(this.txtDeliveryNote);
            this.pnlDeliveryInfo.Controls.Add(this.lblDeliveryNote);
            this.pnlDeliveryInfo.Controls.Add(this.txtDeliveryAddress);
            this.pnlDeliveryInfo.Controls.Add(this.cboDeliveryDistrict);
            this.pnlDeliveryInfo.Controls.Add(this.lblDeliveryAddr);
            this.pnlDeliveryInfo.Controls.Add(this.txtDeliveryPhone);
            this.pnlDeliveryInfo.Controls.Add(this.lblDeliveryPhone);
            this.pnlDeliveryInfo.Controls.Add(this.txtDeliveryName);
            this.pnlDeliveryInfo.Controls.Add(this.lblDeliveryName);
            this.pnlDeliveryInfo.Location = new System.Drawing.Point(12, 60);
            this.pnlDeliveryInfo.Name = "pnlDeliveryInfo";
            this.pnlDeliveryInfo.Size = new System.Drawing.Size(630, 220);
            this.pnlDeliveryInfo.TabIndex = 2;
            this.pnlDeliveryInfo.Visible = false;
            // 
            // cboDeliveryCity
            // 
            this.cboDeliveryCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryCity.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDeliveryCity.FormattingEnabled = true;
            this.cboDeliveryCity.Items.AddRange(new object[] {
            "基隆市",
            "臺北市",
            "新北市",
            "桃園市",
            "新竹市",
            "新竹縣",
            "宜蘭縣",
            "",
            "苗栗縣",
            "臺中市",
            "彰化縣",
            "南投縣",
            "雲林縣",
            "",
            "嘉義市",
            "嘉義縣",
            "臺南市",
            "高雄市",
            "屏東縣",
            "",
            "花蓮縣",
            "臺東縣"});
            this.cboDeliveryCity.Location = new System.Drawing.Point(86, 76);
            this.cboDeliveryCity.Name = "cboDeliveryCity";
            this.cboDeliveryCity.Size = new System.Drawing.Size(86, 26);
            this.cboDeliveryCity.TabIndex = 11;
            this.cboDeliveryCity.SelectedIndexChanged += new System.EventHandler(this.cboDeliveryCity_SelectedIndexChanged);
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblDeliveryFee.Location = new System.Drawing.Point(8, 187);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(197, 16);
            this.lblDeliveryFee.TabIndex = 10;
            this.lblDeliveryFee.Text = "運費：NT$ 100（滿 1000 元免運）";
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeliveryNote.Location = new System.Drawing.Point(86, 144);
            this.txtDeliveryNote.Multiline = true;
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Size = new System.Drawing.Size(532, 40);
            this.txtDeliveryNote.TabIndex = 9;
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblDeliveryNote.Location = new System.Drawing.Point(1, 152);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(69, 19);
            this.lblDeliveryNote.TabIndex = 8;
            this.lblDeliveryNote.Text = "配送備註";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeliveryAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(86, 111);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(355, 27);
            this.txtDeliveryAddress.TabIndex = 7;
            // 
            // cboDeliveryDistrict
            // 
            this.cboDeliveryDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryDistrict.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDeliveryDistrict.FormattingEnabled = true;
            this.cboDeliveryDistrict.Location = new System.Drawing.Point(188, 77);
            this.cboDeliveryDistrict.Name = "cboDeliveryDistrict";
            this.cboDeliveryDistrict.Size = new System.Drawing.Size(79, 26);
            this.cboDeliveryDistrict.TabIndex = 6;
            this.cboDeliveryDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDeliveryDistrict_SelectedIndexChanged);
            // 
            // lblDeliveryAddr
            // 
            this.lblDeliveryAddr.AutoSize = true;
            this.lblDeliveryAddr.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblDeliveryAddr.Location = new System.Drawing.Point(3, 76);
            this.lblDeliveryAddr.Name = "lblDeliveryAddr";
            this.lblDeliveryAddr.Size = new System.Drawing.Size(69, 19);
            this.lblDeliveryAddr.TabIndex = 4;
            this.lblDeliveryAddr.Text = "配送地址";
            // 
            // txtDeliveryPhone
            // 
            this.txtDeliveryPhone.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeliveryPhone.Location = new System.Drawing.Point(86, 40);
            this.txtDeliveryPhone.MaxLength = 10;
            this.txtDeliveryPhone.Name = "txtDeliveryPhone";
            this.txtDeliveryPhone.Size = new System.Drawing.Size(140, 27);
            this.txtDeliveryPhone.TabIndex = 3;
            // 
            // lblDeliveryPhone
            // 
            this.lblDeliveryPhone.AutoSize = true;
            this.lblDeliveryPhone.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblDeliveryPhone.Location = new System.Drawing.Point(3, 40);
            this.lblDeliveryPhone.Name = "lblDeliveryPhone";
            this.lblDeliveryPhone.Size = new System.Drawing.Size(84, 19);
            this.lblDeliveryPhone.TabIndex = 2;
            this.lblDeliveryPhone.Text = "收件人電話";
            // 
            // txtDeliveryName
            // 
            this.txtDeliveryName.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeliveryName.Location = new System.Drawing.Point(86, 7);
            this.txtDeliveryName.Name = "txtDeliveryName";
            this.txtDeliveryName.Size = new System.Drawing.Size(180, 27);
            this.txtDeliveryName.TabIndex = 1;
            // 
            // lblDeliveryName
            // 
            this.lblDeliveryName.AutoSize = true;
            this.lblDeliveryName.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblDeliveryName.Location = new System.Drawing.Point(3, 11);
            this.lblDeliveryName.Name = "lblDeliveryName";
            this.lblDeliveryName.Size = new System.Drawing.Size(84, 19);
            this.lblDeliveryName.TabIndex = 0;
            this.lblDeliveryName.Text = "收件人姓名";
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.AutoSize = true;
            this.rdbDelivery.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.rdbDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdbDelivery.Location = new System.Drawing.Point(200, 32);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(82, 22);
            this.rdbDelivery.TabIndex = 1;
            this.rdbDelivery.Text = "宅配到府";
            this.rdbDelivery.CheckedChanged += new System.EventHandler(this.rdbDelivery_CheckedChanged);
            // 
            // rdbOnSite
            // 
            this.rdbOnSite.AutoSize = true;
            this.rdbOnSite.Checked = true;
            this.rdbOnSite.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.rdbOnSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdbOnSite.Location = new System.Drawing.Point(16, 32);
            this.rdbOnSite.Name = "rdbOnSite";
            this.rdbOnSite.Size = new System.Drawing.Size(156, 22);
            this.rdbOnSite.TabIndex = 0;
            this.rdbOnSite.TabStop = true;
            this.rdbOnSite.Text = "現場結單 (市集/門市)";
            this.rdbOnSite.CheckedChanged += new System.EventHandler(this.rdbOnSite_CheckedChanged);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.White;
            this.grpCustomer.Controls.Add(this.lblAutoDetect);
            this.grpCustomer.Controls.Add(this.txtContactPhone);
            this.grpCustomer.Controls.Add(this.lblContactPhone);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpCustomer.Location = new System.Drawing.Point(12, 326);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(648, 105);
            this.grpCustomer.TabIndex = 2;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "訂購人資料";
            // 
            // lblAutoDetect
            // 
            this.lblAutoDetect.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Italic);
            this.lblAutoDetect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblAutoDetect.Location = new System.Drawing.Point(272, 74);
            this.lblAutoDetect.Name = "lblAutoDetect";
            this.lblAutoDetect.Size = new System.Drawing.Size(370, 18);
            this.lblAutoDetect.TabIndex = 4;
            this.lblAutoDetect.Text = "訪客直接填寫即可；會員結帳後訂單自動記錄 MemberID";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContactPhone.Location = new System.Drawing.Point(110, 67);
            this.txtContactPhone.MaxLength = 10;
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(155, 27);
            this.txtContactPhone.TabIndex = 3;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblContactPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblContactPhone.Location = new System.Drawing.Point(12, 70);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(64, 18);
            this.lblContactPhone.TabIndex = 2;
            this.lblContactPhone.Text = "聯絡電話";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCustomerName.Location = new System.Drawing.Point(110, 35);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblCustomerName.Location = new System.Drawing.Point(12, 38);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(78, 18);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "訂購人姓名";
            // 
            // grpMemberLogin
            // 
            this.grpMemberLogin.BackColor = System.Drawing.Color.White;
            this.grpMemberLogin.Controls.Add(this.pnlMemberSection);
            this.grpMemberLogin.Controls.Add(this.rdbMember);
            this.grpMemberLogin.Controls.Add(this.rdbGuest);
            this.grpMemberLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpMemberLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpMemberLogin.Location = new System.Drawing.Point(10, 196);
            this.grpMemberLogin.Name = "grpMemberLogin";
            this.grpMemberLogin.Size = new System.Drawing.Size(648, 124);
            this.grpMemberLogin.TabIndex = 1;
            this.grpMemberLogin.TabStop = false;
            this.grpMemberLogin.Text = "是否以會員身份結帳 (選填)";
            // 
            // pnlMemberSection
            // 
            this.pnlMemberSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.pnlMemberSection.Controls.Add(this.txtPassword);
            this.pnlMemberSection.Controls.Add(this.lblMemberPssswordHint);
            this.pnlMemberSection.Controls.Add(this.btnLoginMember);
            this.pnlMemberSection.Controls.Add(this.txtPhone);
            this.pnlMemberSection.Controls.Add(this.lblMemberPhoneHint);
            this.pnlMemberSection.Location = new System.Drawing.Point(16, 58);
            this.pnlMemberSection.Name = "pnlMemberSection";
            this.pnlMemberSection.Size = new System.Drawing.Size(614, 60);
            this.pnlMemberSection.TabIndex = 2;
            this.pnlMemberSection.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(278, 9);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(123, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // lblMemberPssswordHint
            // 
            this.lblMemberPssswordHint.AutoSize = true;
            this.lblMemberPssswordHint.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMemberPssswordHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMemberPssswordHint.Location = new System.Drawing.Point(222, 14);
            this.lblMemberPssswordHint.Name = "lblMemberPssswordHint";
            this.lblMemberPssswordHint.Size = new System.Drawing.Size(42, 19);
            this.lblMemberPssswordHint.TabIndex = 3;
            this.lblMemberPssswordHint.Text = "密碼:";
            // 
            // btnLoginMember
            // 
            this.btnLoginMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLoginMember.FlatAppearance.BorderSize = 0;
            this.btnLoginMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMember.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoginMember.ForeColor = System.Drawing.Color.White;
            this.btnLoginMember.Location = new System.Drawing.Point(409, 11);
            this.btnLoginMember.Name = "btnLoginMember";
            this.btnLoginMember.Size = new System.Drawing.Size(109, 30);
            this.btnLoginMember.TabIndex = 2;
            this.btnLoginMember.Text = "登入會員";
            this.btnLoginMember.UseVisualStyleBackColor = false;
            this.btnLoginMember.Click += new System.EventHandler(this.btnLookupMember_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(94, 10);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 29);
            this.txtPhone.TabIndex = 1;
            // 
            // lblMemberPhoneHint
            // 
            this.lblMemberPhoneHint.AutoSize = true;
            this.lblMemberPhoneHint.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMemberPhoneHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMemberPhoneHint.Location = new System.Drawing.Point(3, 15);
            this.lblMemberPhoneHint.Name = "lblMemberPhoneHint";
            this.lblMemberPhoneHint.Size = new System.Drawing.Size(72, 19);
            this.lblMemberPhoneHint.TabIndex = 0;
            this.lblMemberPhoneHint.Text = "手機號碼:";
            // 
            // rdbMember
            // 
            this.rdbMember.AutoSize = true;
            this.rdbMember.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.rdbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.rdbMember.Location = new System.Drawing.Point(130, 32);
            this.rdbMember.Name = "rdbMember";
            this.rdbMember.Size = new System.Drawing.Size(110, 22);
            this.rdbMember.TabIndex = 1;
            this.rdbMember.Text = "會員登入結帳";
            this.rdbMember.CheckedChanged += new System.EventHandler(this.rdbMember_CheckedChanged);
            // 
            // rdbGuest
            // 
            this.rdbGuest.AutoSize = true;
            this.rdbGuest.Checked = true;
            this.rdbGuest.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.rdbGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdbGuest.Location = new System.Drawing.Point(16, 32);
            this.rdbGuest.Name = "rdbGuest";
            this.rdbGuest.Size = new System.Drawing.Size(82, 22);
            this.rdbGuest.TabIndex = 0;
            this.rdbGuest.TabStop = true;
            this.rdbGuest.Text = "訪客結帳";
            this.rdbGuest.CheckedChanged += new System.EventHandler(this.rdbGuest_CheckedChanged);
            // 
            // grpOrderDetail
            // 
            this.grpOrderDetail.BackColor = System.Drawing.Color.White;
            this.grpOrderDetail.Controls.Add(this.lblCartTotal);
            this.grpOrderDetail.Controls.Add(this.dgvCartItems);
            this.grpOrderDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpOrderDetail.Location = new System.Drawing.Point(10, 10);
            this.grpOrderDetail.Name = "grpOrderDetail";
            this.grpOrderDetail.Size = new System.Drawing.Size(648, 180);
            this.grpOrderDetail.TabIndex = 0;
            this.grpOrderDetail.TabStop = false;
            this.grpOrderDetail.Text = "訂單明細";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCartTotal.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.lblCartTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblCartTotal.Location = new System.Drawing.Point(420, 148);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(216, 24);
            this.lblCartTotal.TabIndex = 1;
            this.lblCartTotal.Text = "合計  NT$ 0";
            this.lblCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCartItems
            // 
            this.dgvCartItems.AllowUserToAddRows = false;
            this.dgvCartItems.AllowUserToDeleteRows = false;
            this.dgvCartItems.AllowUserToResizeColumns = false;
            this.dgvCartItems.AllowUserToResizeRows = false;
            this.dgvCartItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartItems.ColumnHeadersHeight = 30;
            this.dgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCartItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.產品名稱,
            this.數量,
            this.單價,
            this.小計,
            this.ProductID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCartItems.EnableHeadersVisualStyles = false;
            this.dgvCartItems.Location = new System.Drawing.Point(10, 28);
            this.dgvCartItems.Name = "dgvCartItems";
            this.dgvCartItems.ReadOnly = true;
            this.dgvCartItems.RowHeadersVisible = false;
            this.dgvCartItems.RowHeadersWidth = 51;
            this.dgvCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartItems.Size = new System.Drawing.Size(626, 137);
            this.dgvCartItems.TabIndex = 0;
            // 
            // 產品名稱
            // 
            this.產品名稱.HeaderText = "產品名稱";
            this.產品名稱.MinimumWidth = 6;
            this.產品名稱.Name = "產品名稱";
            this.產品名稱.ReadOnly = true;
            this.產品名稱.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.產品名稱.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.產品名稱.Width = 121;
            // 
            // 數量
            // 
            this.數量.HeaderText = "數量";
            this.數量.MinimumWidth = 4;
            this.數量.Name = "數量";
            this.數量.ReadOnly = true;
            this.數量.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.數量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.數量.Width = 81;
            // 
            // 單價
            // 
            this.單價.HeaderText = "單價";
            this.單價.MinimumWidth = 4;
            this.單價.Name = "單價";
            this.單價.ReadOnly = true;
            this.單價.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.單價.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.單價.Width = 81;
            // 
            // 小計
            // 
            this.小計.HeaderText = "小計";
            this.小計.MinimumWidth = 6;
            this.小計.Name = "小計";
            this.小計.ReadOnly = true;
            this.小計.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小計.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.小計.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductID.Visible = false;
            this.ProductID.Width = 140;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.grpPayment);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(670, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.pnlRight.Size = new System.Drawing.Size(230, 750);
            this.pnlRight.TabIndex = 1;
            // 
            // grpPayment
            // 
            this.grpPayment.BackColor = System.Drawing.Color.White;
            this.grpPayment.Controls.Add(this.button1);
            this.grpPayment.Controls.Add(this.btnBackToOrder);
            this.grpPayment.Controls.Add(this.btnConfirmOrder);
            this.grpPayment.Controls.Add(this.txtOrderNote);
            this.grpPayment.Controls.Add(this.lblNoteLabel);
            this.grpPayment.Controls.Add(this.cboPayment);
            this.grpPayment.Controls.Add(this.lblPaymentLabel);
            this.grpPayment.Controls.Add(this.lblFinalTotal);
            this.grpPayment.Controls.Add(this.lblFinalLabel);
            this.grpPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.grpPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpPayment.Location = new System.Drawing.Point(5, 10);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(213, 521);
            this.grpPayment.TabIndex = 0;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "結帳確認";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "寄送訂購確認單";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnBackToOrder.FlatAppearance.BorderSize = 0;
            this.btnBackToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrder.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBackToOrder.ForeColor = System.Drawing.Color.White;
            this.btnBackToOrder.Location = new System.Drawing.Point(10, 474);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(188, 34);
            this.btnBackToOrder.TabIndex = 7;
            this.btnBackToOrder.Text = "繼續購物";
            this.btnBackToOrder.UseVisualStyleBackColor = false;
            this.btnBackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Location = new System.Drawing.Point(10, 385);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(188, 45);
            this.btnConfirmOrder.TabIndex = 6;
            this.btnConfirmOrder.Text = "確認下單";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // txtOrderNote
            // 
            this.txtOrderNote.BackColor = System.Drawing.Color.White;
            this.txtOrderNote.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.txtOrderNote.Location = new System.Drawing.Point(10, 183);
            this.txtOrderNote.Multiline = true;
            this.txtOrderNote.Name = "txtOrderNote";
            this.txtOrderNote.Size = new System.Drawing.Size(188, 192);
            this.txtOrderNote.TabIndex = 5;
            // 
            // lblNoteLabel
            // 
            this.lblNoteLabel.AutoSize = true;
            this.lblNoteLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblNoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblNoteLabel.Location = new System.Drawing.Point(10, 158);
            this.lblNoteLabel.Name = "lblNoteLabel";
            this.lblNoteLabel.Size = new System.Drawing.Size(64, 18);
            this.lblNoteLabel.TabIndex = 4;
            this.lblNoteLabel.Text = "訂單備註";
            // 
            // cboPayment
            // 
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "現金",
            "LINEPay",
            "銀行轉帳"});
            this.cboPayment.Location = new System.Drawing.Point(10, 120);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(188, 25);
            this.cboPayment.TabIndex = 3;
            // 
            // lblPaymentLabel
            // 
            this.lblPaymentLabel.AutoSize = true;
            this.lblPaymentLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblPaymentLabel.Location = new System.Drawing.Point(10, 100);
            this.lblPaymentLabel.Name = "lblPaymentLabel";
            this.lblPaymentLabel.Size = new System.Drawing.Size(64, 18);
            this.lblPaymentLabel.TabIndex = 2;
            this.lblPaymentLabel.Text = "付款方式";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblFinalTotal.Location = new System.Drawing.Point(10, 55);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(188, 36);
            this.lblFinalTotal.TabIndex = 1;
            this.lblFinalTotal.Text = "NT$ 0";
            // 
            // lblFinalLabel
            // 
            this.lblFinalLabel.AutoSize = true;
            this.lblFinalLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblFinalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblFinalLabel.Location = new System.Drawing.Point(10, 35);
            this.lblFinalLabel.Name = "lblFinalLabel";
            this.lblFinalLabel.Size = new System.Drawing.Size(64, 18);
            this.lblFinalLabel.TabIndex = 0;
            this.lblFinalLabel.Text = "應付金額";
            // 
            // crownStatusStrip1
            // 
            this.crownStatusStrip1.AutoSize = false;
            this.crownStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.crownStatusStrip1.Location = new System.Drawing.Point(0, 726);
            this.crownStatusStrip1.Name = "crownStatusStrip1";
            this.crownStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.crownStatusStrip1.Size = new System.Drawing.Size(670, 24);
            this.crownStatusStrip1.SizingGrip = false;
            this.crownStatusStrip1.TabIndex = 2;
            this.crownStatusStrip1.Text = "crownStatusStrip1";
            // 
            // timerShoppingcar
            // 
            this.timerShoppingcar.Interval = 60000;
            this.timerShoppingcar.Tick += new System.EventHandler(this.timerShoppingcar_Tick);
            // 
            // frmCart
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.crownStatusStrip1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "購物車結帳";
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.pnlLeft.ResumeLayout(false);
            this.grpPickupType.ResumeLayout(false);
            this.grpPickupType.PerformLayout();
            this.pnlDeliveryInfo.ResumeLayout(false);
            this.pnlDeliveryInfo.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpMemberLogin.ResumeLayout(false);
            this.grpMemberLogin.PerformLayout();
            this.pnlMemberSection.ResumeLayout(false);
            this.pnlMemberSection.PerformLayout();
            this.grpOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox grpOrderDetail;
        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.GroupBox grpMemberLogin;
        private System.Windows.Forms.RadioButton rdbGuest;
        private System.Windows.Forms.RadioButton rdbMember;
        private System.Windows.Forms.Button btnLoginMember;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label lblAutoDetect;
        private System.Windows.Forms.GroupBox grpPickupType;
        private System.Windows.Forms.RadioButton rdbOnSite;
        private System.Windows.Forms.RadioButton rdbDelivery;
        private System.Windows.Forms.Panel pnlDeliveryInfo;
        private System.Windows.Forms.Label lblDeliveryName;
        private System.Windows.Forms.TextBox txtDeliveryName;
        private System.Windows.Forms.Label lblDeliveryPhone;
        private System.Windows.Forms.TextBox txtDeliveryPhone;
        private System.Windows.Forms.Label lblDeliveryAddr;
        private System.Windows.Forms.ComboBox cboDeliveryDistrict;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryNote;
        private System.Windows.Forms.TextBox txtDeliveryNote;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblFinalLabel;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblPaymentLabel;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.Label lblNoteLabel;
        private System.Windows.Forms.TextBox txtOrderNote;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnBackToOrder;
        private System.Windows.Forms.ComboBox cboDeliveryCity;
        private ReaLTaiizor.Controls.CrownStatusStrip crownStatusStrip1;
        private System.Windows.Forms.Timer timerShoppingcar;
        private System.Windows.Forms.Panel pnlMemberSection;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMemberPssswordHint;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMemberPhoneHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小計;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Button button1;
    }
}