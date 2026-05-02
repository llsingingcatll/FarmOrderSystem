namespace FarmOrderSystem
{
    partial class frmOrderQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.cboPickupType = new System.Windows.Forms.ComboBox();
            this.lblPickupLabel = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.lblChangeStatus = new System.Windows.Forms.Label();
            this.cboChangeStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.pnlStatusFlow = new System.Windows.Forms.Panel();
            this.lblFlow5 = new System.Windows.Forms.Label();
            this.lblFlowArrow4 = new System.Windows.Forms.Label();
            this.lblFlow4 = new System.Windows.Forms.Label();
            this.lblFlowArrow3 = new System.Windows.Forms.Label();
            this.lblFlow3 = new System.Windows.Forms.Label();
            this.lblFlowArrow2 = new System.Windows.Forms.Label();
            this.lblFlow2 = new System.Windows.Forms.Label();
            this.lblFlowArrow1 = new System.Windows.Forms.Label();
            this.lblFlow1 = new System.Windows.Forms.Label();
            this.勾選 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂單編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂購人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取貨 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合計 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportDelivery = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.pnlAction.SuspendLayout();
            this.pnlStatusFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblResultCount);
            this.pnlSearch.Controls.Add(this.btnClearSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchLabel);
            this.pnlSearch.Controls.Add(this.cboPickupType);
            this.pnlSearch.Controls.Add(this.lblPickupLabel);
            this.pnlSearch.Controls.Add(this.cboStatus);
            this.pnlSearch.Controls.Add(this.lblStatusLabel);
            this.pnlSearch.Controls.Add(this.dtpEnd);
            this.pnlSearch.Controls.Add(this.lblEndDate);
            this.pnlSearch.Controls.Add(this.dtpStart);
            this.pnlSearch.Controls.Add(this.lblStartDate);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1280, 44);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblResultCount
            // 
            this.lblResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblResultCount.Location = new System.Drawing.Point(1168, 13);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(62, 22);
            this.lblResultCount.TabIndex = 12;
            this.lblResultCount.Text = "共 0 筆";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(1084, 8);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(62, 28);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "清除";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1004, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtSearch.Location = new System.Drawing.Point(864, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 30);
            this.txtSearch.TabIndex = 9;
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblSearchLabel.Location = new System.Drawing.Point(782, 13);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(85, 22);
            this.lblSearchLabel.TabIndex = 8;
            this.lblSearchLabel.Text = "姓名/電話";
            // 
            // cboPickupType
            // 
            this.cboPickupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPickupType.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboPickupType.FormattingEnabled = true;
            this.cboPickupType.Items.AddRange(new object[] {
            "全部",
            "現場結單",
            "宅配到府"});
            this.cboPickupType.Location = new System.Drawing.Point(658, 8);
            this.cboPickupType.Name = "cboPickupType";
            this.cboPickupType.Size = new System.Drawing.Size(110, 30);
            this.cboPickupType.TabIndex = 7;
            // 
            // lblPickupLabel
            // 
            this.lblPickupLabel.AutoSize = true;
            this.lblPickupLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPickupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblPickupLabel.Location = new System.Drawing.Point(618, 13);
            this.lblPickupLabel.Name = "lblPickupLabel";
            this.lblPickupLabel.Size = new System.Drawing.Size(44, 22);
            this.lblPickupLabel.TabIndex = 6;
            this.lblPickupLabel.Text = "取貨";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "全部",
            "待確認",
            "已確認",
            "備貨中",
            "已出貨",
            "已完成",
            "已取消"});
            this.cboStatus.Location = new System.Drawing.Point(496, 8);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(110, 30);
            this.cboStatus.TabIndex = 5;
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblStatusLabel.Location = new System.Drawing.Point(452, 13);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(44, 22);
            this.lblStatusLabel.TabIndex = 4;
            this.lblStatusLabel.Text = "狀態";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(318, 8);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 30);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblEndDate.Location = new System.Drawing.Point(232, 13);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(78, 22);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "結束日期";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(100, 8);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 30);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblStartDate.Location = new System.Drawing.Point(10, 13);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 22);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "起始日期";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderList.ColumnHeadersHeight = 32;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.勾選,
            this.OrderID,
            this.訂單編號,
            this.訂購人,
            this.電話,
            this.取貨,
            this.合計,
            this.狀態,
            this.日期,
            this.備註});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOrderList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.dgvOrderList.Location = new System.Drawing.Point(0, 44);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowHeadersWidth = 80;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(1280, 360);
            this.dgvOrderList.TabIndex = 1;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            this.dgvOrderList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvOrderList_CurrentCellDirtyStateChanged);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.Controls.Add(this.lblDetailTitle);
            this.pnlDetail.Controls.Add(this.dgvOrderDetail);
            this.pnlDetail.Controls.Add(this.pnlAction);
            this.pnlDetail.Location = new System.Drawing.Point(0, 404);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1280, 336);
            this.pnlDetail.TabIndex = 3;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(8, 8);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(86, 24);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "訂單明細";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrderDetail.ColumnHeadersHeight = 30;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrderDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.dgvOrderDetail.Location = new System.Drawing.Point(8, 36);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(900, 286);
            this.dgvOrderDetail.TabIndex = 1;
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlAction.Controls.Add(this.btnExportDelivery);
            this.pnlAction.Controls.Add(this.lblChangeStatus);
            this.pnlAction.Controls.Add(this.cboChangeStatus);
            this.pnlAction.Controls.Add(this.btnUpdateStatus);
            this.pnlAction.Controls.Add(this.btnCancelOrder);
            this.pnlAction.Location = new System.Drawing.Point(920, 36);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(350, 286);
            this.pnlAction.TabIndex = 2;
            // 
            // lblChangeStatus
            // 
            this.lblChangeStatus.AutoSize = true;
            this.lblChangeStatus.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblChangeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblChangeStatus.Location = new System.Drawing.Point(16, 20);
            this.lblChangeStatus.Name = "lblChangeStatus";
            this.lblChangeStatus.Size = new System.Drawing.Size(112, 22);
            this.lblChangeStatus.TabIndex = 0;
            this.lblChangeStatus.Text = "更新訂單狀態";
            // 
            // cboChangeStatus
            // 
            this.cboChangeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChangeStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboChangeStatus.FormattingEnabled = true;
            this.cboChangeStatus.Items.AddRange(new object[] {
            "待確認",
            "已確認",
            "備貨中",
            "已出貨",
            "已完成"});
            this.cboChangeStatus.Location = new System.Drawing.Point(16, 50);
            this.cboChangeStatus.Name = "cboChangeStatus";
            this.cboChangeStatus.Size = new System.Drawing.Size(150, 30);
            this.cboChangeStatus.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(16, 90);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(150, 36);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "確認更新";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(16, 140);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(150, 36);
            this.btnCancelOrder.TabIndex = 3;
            this.btnCancelOrder.Text = "取消此訂單";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // pnlStatusFlow
            // 
            this.pnlStatusFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlStatusFlow.Controls.Add(this.lblFlow5);
            this.pnlStatusFlow.Controls.Add(this.lblFlowArrow4);
            this.pnlStatusFlow.Controls.Add(this.lblFlow4);
            this.pnlStatusFlow.Controls.Add(this.lblFlowArrow3);
            this.pnlStatusFlow.Controls.Add(this.lblFlow3);
            this.pnlStatusFlow.Controls.Add(this.lblFlowArrow2);
            this.pnlStatusFlow.Controls.Add(this.lblFlow2);
            this.pnlStatusFlow.Controls.Add(this.lblFlowArrow1);
            this.pnlStatusFlow.Controls.Add(this.lblFlow1);
            this.pnlStatusFlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusFlow.Location = new System.Drawing.Point(0, 770);
            this.pnlStatusFlow.Name = "pnlStatusFlow";
            this.pnlStatusFlow.Size = new System.Drawing.Size(1280, 30);
            this.pnlStatusFlow.TabIndex = 4;
            // 
            // lblFlow5
            // 
            this.lblFlow5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblFlow5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlow5.ForeColor = System.Drawing.Color.White;
            this.lblFlow5.Location = new System.Drawing.Point(338, 5);
            this.lblFlow5.Name = "lblFlow5";
            this.lblFlow5.Size = new System.Drawing.Size(60, 20);
            this.lblFlow5.TabIndex = 8;
            this.lblFlow5.Text = "已完成";
            this.lblFlow5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowArrow4
            // 
            this.lblFlowArrow4.AutoSize = true;
            this.lblFlowArrow4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlowArrow4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFlowArrow4.Location = new System.Drawing.Point(319, 6);
            this.lblFlowArrow4.Name = "lblFlowArrow4";
            this.lblFlowArrow4.Size = new System.Drawing.Size(23, 22);
            this.lblFlowArrow4.TabIndex = 7;
            this.lblFlowArrow4.Text = ">";
            // 
            // lblFlow4
            // 
            this.lblFlow4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblFlow4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlow4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblFlow4.Location = new System.Drawing.Point(256, 5);
            this.lblFlow4.Name = "lblFlow4";
            this.lblFlow4.Size = new System.Drawing.Size(60, 20);
            this.lblFlow4.TabIndex = 6;
            this.lblFlow4.Text = "已出貨";
            this.lblFlow4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowArrow3
            // 
            this.lblFlowArrow3.AutoSize = true;
            this.lblFlowArrow3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlowArrow3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFlowArrow3.Location = new System.Drawing.Point(237, 6);
            this.lblFlowArrow3.Name = "lblFlowArrow3";
            this.lblFlowArrow3.Size = new System.Drawing.Size(23, 22);
            this.lblFlowArrow3.TabIndex = 5;
            this.lblFlowArrow3.Text = ">";
            // 
            // lblFlow3
            // 
            this.lblFlow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblFlow3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlow3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblFlow3.Location = new System.Drawing.Point(174, 5);
            this.lblFlow3.Name = "lblFlow3";
            this.lblFlow3.Size = new System.Drawing.Size(60, 20);
            this.lblFlow3.TabIndex = 4;
            this.lblFlow3.Text = "備貨中";
            this.lblFlow3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowArrow2
            // 
            this.lblFlowArrow2.AutoSize = true;
            this.lblFlowArrow2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlowArrow2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFlowArrow2.Location = new System.Drawing.Point(155, 6);
            this.lblFlowArrow2.Name = "lblFlowArrow2";
            this.lblFlowArrow2.Size = new System.Drawing.Size(23, 22);
            this.lblFlowArrow2.TabIndex = 3;
            this.lblFlowArrow2.Text = ">";
            // 
            // lblFlow2
            // 
            this.lblFlow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblFlow2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlow2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblFlow2.Location = new System.Drawing.Point(92, 5);
            this.lblFlow2.Name = "lblFlow2";
            this.lblFlow2.Size = new System.Drawing.Size(60, 20);
            this.lblFlow2.TabIndex = 2;
            this.lblFlow2.Text = "已確認";
            this.lblFlow2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowArrow1
            // 
            this.lblFlowArrow1.AutoSize = true;
            this.lblFlowArrow1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlowArrow1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblFlowArrow1.Location = new System.Drawing.Point(73, 6);
            this.lblFlowArrow1.Name = "lblFlowArrow1";
            this.lblFlowArrow1.Size = new System.Drawing.Size(23, 22);
            this.lblFlowArrow1.TabIndex = 1;
            this.lblFlowArrow1.Text = ">";
            // 
            // lblFlow1
            // 
            this.lblFlow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblFlow1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblFlow1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblFlow1.Location = new System.Drawing.Point(10, 5);
            this.lblFlow1.Name = "lblFlow1";
            this.lblFlow1.Size = new System.Drawing.Size(60, 20);
            this.lblFlow1.TabIndex = 0;
            this.lblFlow1.Text = "待確認";
            this.lblFlow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 勾選
            // 
            this.勾選.FalseValue = "";
            this.勾選.HeaderText = "勾選";
            this.勾選.MinimumWidth = 6;
            this.勾選.Name = "勾選";
            this.勾選.TrueValue = "";
            this.勾選.Width = 125;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.Visible = false;
            this.OrderID.Width = 125;
            // 
            // 訂單編號
            // 
            this.訂單編號.DataPropertyName = "訂單編號";
            this.訂單編號.HeaderText = "訂單編號";
            this.訂單編號.MinimumWidth = 6;
            this.訂單編號.Name = "訂單編號";
            this.訂單編號.ReadOnly = true;
            this.訂單編號.Width = 125;
            // 
            // 訂購人
            // 
            this.訂購人.DataPropertyName = "訂購人";
            this.訂購人.HeaderText = "訂購人";
            this.訂購人.MinimumWidth = 6;
            this.訂購人.Name = "訂購人";
            this.訂購人.ReadOnly = true;
            this.訂購人.Width = 125;
            // 
            // 電話
            // 
            this.電話.DataPropertyName = "電話";
            this.電話.HeaderText = "電話";
            this.電話.MinimumWidth = 6;
            this.電話.Name = "電話";
            this.電話.ReadOnly = true;
            this.電話.Width = 125;
            // 
            // 取貨
            // 
            this.取貨.DataPropertyName = "取貨";
            this.取貨.HeaderText = "取貨";
            this.取貨.MinimumWidth = 6;
            this.取貨.Name = "取貨";
            this.取貨.ReadOnly = true;
            this.取貨.Width = 125;
            // 
            // 合計
            // 
            this.合計.DataPropertyName = "合計";
            this.合計.HeaderText = "合計";
            this.合計.MinimumWidth = 6;
            this.合計.Name = "合計";
            this.合計.ReadOnly = true;
            this.合計.Width = 125;
            // 
            // 狀態
            // 
            this.狀態.DataPropertyName = "狀態";
            this.狀態.HeaderText = "狀態";
            this.狀態.MinimumWidth = 6;
            this.狀態.Name = "狀態";
            this.狀態.ReadOnly = true;
            this.狀態.Width = 125;
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "日期";
            this.日期.HeaderText = "日期";
            this.日期.MinimumWidth = 6;
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            this.日期.Width = 125;
            // 
            // 備註
            // 
            this.備註.DataPropertyName = "備註";
            this.備註.HeaderText = "備註";
            this.備註.MinimumWidth = 6;
            this.備註.Name = "備註";
            this.備註.Width = 125;
            // 
            // btnExportDelivery
            // 
            this.btnExportDelivery.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExportDelivery.FlatAppearance.BorderSize = 0;
            this.btnExportDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportDelivery.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportDelivery.ForeColor = System.Drawing.Color.White;
            this.btnExportDelivery.Location = new System.Drawing.Point(16, 195);
            this.btnExportDelivery.Name = "btnExportDelivery";
            this.btnExportDelivery.Size = new System.Drawing.Size(150, 36);
            this.btnExportDelivery.TabIndex = 4;
            this.btnExportDelivery.Text = "匯出配送清單";
            this.btnExportDelivery.UseVisualStyleBackColor = false;
            this.btnExportDelivery.Click += new System.EventHandler(this.btnExportDelivery_Click);
            // 
            // frmOrderQuery
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.pnlStatusFlow);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmOrderQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂購單查詢與管理";
            this.Load += new System.EventHandler(this.frmOrderQuery_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.pnlStatusFlow.ResumeLayout(false);
            this.pnlStatusFlow.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblPickupLabel;
        private System.Windows.Forms.ComboBox cboPickupType;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblChangeStatus;
        private System.Windows.Forms.ComboBox cboChangeStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Panel pnlStatusFlow;
        private System.Windows.Forms.Label lblFlow1;
        private System.Windows.Forms.Label lblFlowArrow1;
        private System.Windows.Forms.Label lblFlow2;
        private System.Windows.Forms.Label lblFlowArrow2;
        private System.Windows.Forms.Label lblFlow3;
        private System.Windows.Forms.Label lblFlowArrow3;
        private System.Windows.Forms.Label lblFlow4;
        private System.Windows.Forms.Label lblFlowArrow4;
        private System.Windows.Forms.Label lblFlow5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 勾選;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂購人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取貨;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合計;
        private System.Windows.Forms.DataGridViewTextBoxColumn 狀態;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註;
        private System.Windows.Forms.Button btnExportDelivery;
    }
}