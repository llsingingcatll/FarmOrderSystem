namespace FarmOrderSystem
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.pnlChartArea = new System.Windows.Forms.Panel();
            this.lblChartNote = new System.Windows.Forms.Label();
            this.grpTopSalesDGV = new System.Windows.Forms.GroupBox();
            this.dgvTopSales = new System.Windows.Forms.DataGridView();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpFuture = new System.Windows.Forms.GroupBox();
            this.picLineMockup = new System.Windows.Forms.PictureBox();
            this.lblLineNote = new System.Windows.Forms.Label();
            this.btnLineOrder = new System.Windows.Forms.Button();
            this.lblExcelNote = new System.Windows.Forms.Label();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.grpTopSales = new System.Windows.Forms.GroupBox();
            this.lblRank5 = new System.Windows.Forms.Label();
            this.lblRank4 = new System.Windows.Forms.Label();
            this.lblRank3 = new System.Windows.Forms.Label();
            this.lblRank2 = new System.Windows.Forms.Label();
            this.lblRank1 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpChart.SuspendLayout();
            this.pnlChartArea.SuspendLayout();
            this.grpTopSalesDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSales)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.grpFuture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineMockup)).BeginInit();
            this.grpTopSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnLoadReport);
            this.pnlSearch.Controls.Add(this.cboMonth);
            this.pnlSearch.Controls.Add(this.lblMonth);
            this.pnlSearch.Controls.Add(this.cboYear);
            this.pnlSearch.Controls.Add(this.lblYear);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1280, 44);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLoadReport.FlatAppearance.BorderSize = 0;
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Location = new System.Drawing.Point(282, 8);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(90, 28);
            this.btnLoadReport.TabIndex = 4;
            this.btnLoadReport.Text = "載入報表";
            this.btnLoadReport.UseVisualStyleBackColor = false;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "全年",
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cboMonth.Location = new System.Drawing.Point(188, 10);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(80, 25);
            this.cboMonth.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMonth.Location = new System.Drawing.Point(146, 13);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(36, 18);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "月份";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023",
            "2022",
            "2021"});
            this.cboYear.Location = new System.Drawing.Point(52, 10);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(80, 25);
            this.cboYear.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblYear.Location = new System.Drawing.Point(10, 13);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 18);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "年份";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 44);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1280, 806);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpChart);
            this.pnlRight.Controls.Add(this.grpTopSalesDGV);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(280, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(8);
            this.pnlRight.Size = new System.Drawing.Size(1000, 806);
            this.pnlRight.TabIndex = 1;
            // 
            // grpChart
            // 
            this.grpChart.BackColor = System.Drawing.Color.White;
            this.grpChart.Controls.Add(this.pnlChartArea);
            this.grpChart.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.grpChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpChart.Location = new System.Drawing.Point(8, 8);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(980, 340);
            this.grpChart.TabIndex = 0;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "月業績趨勢 (chartRevenue)";
            // 
            // pnlChartArea
            // 
            this.pnlChartArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChartArea.Controls.Add(this.lblChartNote);
            this.pnlChartArea.Location = new System.Drawing.Point(10, 28);
            this.pnlChartArea.Name = "pnlChartArea";
            this.pnlChartArea.Size = new System.Drawing.Size(958, 300);
            this.pnlChartArea.TabIndex = 0;
            // 
            // lblChartNote
            // 
            this.lblChartNote.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Italic);
            this.lblChartNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblChartNote.Location = new System.Drawing.Point(0, 130);
            this.lblChartNote.Name = "lblChartNote";
            this.lblChartNote.Size = new System.Drawing.Size(958, 40);
            this.lblChartNote.TabIndex = 0;
            this.lblChartNote.Text = "從工具箱將Chart拖入此 Panel，或在 Load 事件中動態加入 chartRevenue";
            this.lblChartNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTopSalesDGV
            // 
            this.grpTopSalesDGV.BackColor = System.Drawing.Color.White;
            this.grpTopSalesDGV.Controls.Add(this.dgvTopSales);
            this.grpTopSalesDGV.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.grpTopSalesDGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpTopSalesDGV.Location = new System.Drawing.Point(8, 358);
            this.grpTopSalesDGV.Name = "grpTopSalesDGV";
            this.grpTopSalesDGV.Size = new System.Drawing.Size(980, 200);
            this.grpTopSalesDGV.TabIndex = 1;
            this.grpTopSalesDGV.TabStop = false;
            this.grpTopSalesDGV.Text = "訂單明細統計 (dgvTopSales)";
            // 
            // dgvTopSales
            // 
            this.dgvTopSales.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.dgvTopSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTopSales.ColumnHeadersHeight = 30;
            this.dgvTopSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTopSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.dgvTopSales.Location = new System.Drawing.Point(3, 23);
            this.dgvTopSales.Name = "dgvTopSales";
            this.dgvTopSales.ReadOnly = true;
            this.dgvTopSales.RowHeadersVisible = false;
            this.dgvTopSales.RowHeadersWidth = 51;
            this.dgvTopSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSales.Size = new System.Drawing.Size(974, 174);
            this.dgvTopSales.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpFuture);
            this.pnlLeft.Controls.Add(this.grpTopSales);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(280, 806);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpFuture
            // 
            this.grpFuture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(196)))));
            this.grpFuture.Controls.Add(this.picLineMockup);
            this.grpFuture.Controls.Add(this.lblLineNote);
            this.grpFuture.Controls.Add(this.btnLineOrder);
            this.grpFuture.Controls.Add(this.lblExcelNote);
            this.grpFuture.Controls.Add(this.btnImportExcel);
            this.grpFuture.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.grpFuture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.grpFuture.Location = new System.Drawing.Point(8, 228);
            this.grpFuture.Name = "grpFuture";
            this.grpFuture.Size = new System.Drawing.Size(258, 340);
            this.grpFuture.TabIndex = 1;
            this.grpFuture.TabStop = false;
            this.grpFuture.Text = "擴充功能示意 (未來串接)";
            // 
            // picLineMockup
            // 
            this.picLineMockup.BackColor = System.Drawing.Color.White;
            this.picLineMockup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLineMockup.Location = new System.Drawing.Point(10, 168);
            this.picLineMockup.Name = "picLineMockup";
            this.picLineMockup.Size = new System.Drawing.Size(236, 160);
            this.picLineMockup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLineMockup.TabIndex = 4;
            this.picLineMockup.TabStop = false;
            // 
            // lblLineNote
            // 
            this.lblLineNote.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Italic);
            this.lblLineNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblLineNote.Location = new System.Drawing.Point(10, 132);
            this.lblLineNote.Name = "lblLineNote";
            this.lblLineNote.Size = new System.Drawing.Size(236, 30);
            this.lblLineNote.TabIndex = 3;
            this.lblLineNote.Text = "功能開發中：未來串接 LINE Messaging API";
            // 
            // btnLineOrder
            // 
            this.btnLineOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnLineOrder.Enabled = false;
            this.btnLineOrder.FlatAppearance.BorderSize = 0;
            this.btnLineOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineOrder.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnLineOrder.ForeColor = System.Drawing.Color.White;
            this.btnLineOrder.Location = new System.Drawing.Point(10, 100);
            this.btnLineOrder.Name = "btnLineOrder";
            this.btnLineOrder.Size = new System.Drawing.Size(150, 28);
            this.btnLineOrder.TabIndex = 2;
            this.btnLineOrder.Text = "LINE 來單管理";
            this.btnLineOrder.UseVisualStyleBackColor = false;
            // 
            // lblExcelNote
            // 
            this.lblExcelNote.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Italic);
            this.lblExcelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblExcelNote.Location = new System.Drawing.Point(10, 62);
            this.lblExcelNote.Name = "lblExcelNote";
            this.lblExcelNote.Size = new System.Drawing.Size(236, 30);
            this.lblExcelNote.TabIndex = 1;
            this.lblExcelNote.Text = "功能開發中：未來可匯入 Excel 格式訂單";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnImportExcel.Enabled = false;
            this.btnImportExcel.FlatAppearance.BorderSize = 0;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(10, 30);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(150, 28);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "EXCEL 訂單匯入";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            // 
            // grpTopSales
            // 
            this.grpTopSales.BackColor = System.Drawing.Color.White;
            this.grpTopSales.Controls.Add(this.lblRank5);
            this.grpTopSales.Controls.Add(this.lblRank4);
            this.grpTopSales.Controls.Add(this.lblRank3);
            this.grpTopSales.Controls.Add(this.lblRank2);
            this.grpTopSales.Controls.Add(this.lblRank1);
            this.grpTopSales.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.grpTopSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.grpTopSales.Location = new System.Drawing.Point(8, 8);
            this.grpTopSales.Name = "grpTopSales";
            this.grpTopSales.Size = new System.Drawing.Size(258, 210);
            this.grpTopSales.TabIndex = 0;
            this.grpTopSales.TabStop = false;
            this.grpTopSales.Text = "熱銷前5名";
            // 
            // lblRank5
            // 
            this.lblRank5.BackColor = System.Drawing.Color.White;
            this.lblRank5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank5.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblRank5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblRank5.Location = new System.Drawing.Point(10, 164);
            this.lblRank5.Name = "lblRank5";
            this.lblRank5.Size = new System.Drawing.Size(236, 30);
            this.lblRank5.TabIndex = 4;
            this.lblRank5.Text = "No.5  (載入中)";
            this.lblRank5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRank4
            // 
            this.lblRank4.BackColor = System.Drawing.Color.White;
            this.lblRank4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank4.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblRank4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblRank4.Location = new System.Drawing.Point(10, 130);
            this.lblRank4.Name = "lblRank4";
            this.lblRank4.Size = new System.Drawing.Size(236, 30);
            this.lblRank4.TabIndex = 3;
            this.lblRank4.Text = "No.4  (載入中)";
            this.lblRank4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRank3
            // 
            this.lblRank3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.lblRank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank3.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblRank3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblRank3.Location = new System.Drawing.Point(10, 96);
            this.lblRank3.Name = "lblRank3";
            this.lblRank3.Size = new System.Drawing.Size(236, 30);
            this.lblRank3.TabIndex = 2;
            this.lblRank3.Text = "No.3  (載入中)";
            this.lblRank3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRank2
            // 
            this.lblRank2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblRank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank2.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblRank2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblRank2.Location = new System.Drawing.Point(10, 62);
            this.lblRank2.Name = "lblRank2";
            this.lblRank2.Size = new System.Drawing.Size(236, 30);
            this.lblRank2.TabIndex = 1;
            this.lblRank2.Text = "No.2  (載入中)";
            this.lblRank2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRank1
            // 
            this.lblRank1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.lblRank1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRank1.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblRank1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblRank1.Location = new System.Drawing.Point(10, 28);
            this.lblRank1.Name = "lblRank1";
            this.lblRank1.Size = new System.Drawing.Size(236, 30);
            this.lblRank1.TabIndex = 0;
            this.lblRank1.Text = "No.1  (載入中)";
            this.lblRank1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReport
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1280, 850);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "報表統計";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grpChart.ResumeLayout(false);
            this.pnlChartArea.ResumeLayout(false);
            this.grpTopSalesDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSales)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.grpFuture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLineMockup)).EndInit();
            this.grpTopSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox grpTopSales;
        private System.Windows.Forms.Label lblRank1;
        private System.Windows.Forms.Label lblRank2;
        private System.Windows.Forms.Label lblRank3;
        private System.Windows.Forms.Label lblRank4;
        private System.Windows.Forms.Label lblRank5;
        private System.Windows.Forms.GroupBox grpFuture;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Label lblExcelNote;
        private System.Windows.Forms.Button btnLineOrder;
        private System.Windows.Forms.Label lblLineNote;
        private System.Windows.Forms.PictureBox picLineMockup;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpChart;
        private System.Windows.Forms.Panel pnlChartArea;
        private System.Windows.Forms.Label lblChartNote;
        private System.Windows.Forms.GroupBox grpTopSalesDGV;
        private System.Windows.Forms.DataGridView dgvTopSales;
    }
}