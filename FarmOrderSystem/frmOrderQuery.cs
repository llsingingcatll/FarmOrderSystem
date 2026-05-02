using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmOrderSystem
{
    public partial class frmOrderQuery : Form
    {
        // 類別層級變數：記錄目前點選的訂單ID
        int selectedOrderID = 0;

        public frmOrderQuery()
        {
            InitializeComponent();
        }


        private void frmOrderQuery_Load(object sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEnd.Value = DateTime.Now; // 日期預設為今天
            cboStatus.SelectedIndex = 0; // 篩選狀態預設值 
            cboChangeStatus.SelectedIndex = 0; // 顯示全部訂單

            初始化篩選條件();
            顯示訂單列表();

        }


        //  方法：初始化篩選條件， 暫時移除事件，避免設定值時重複觸發查詢
        void 初始化篩選條件()
        {
            dtpStart.ValueChanged -= dtpStart_ValueChanged;
            dtpEnd.ValueChanged -= dtpEnd_ValueChanged;
            cboStatus.SelectedIndexChanged -= cboStatus_SelectedIndexChanged;

            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date;
            cboStatus.SelectedIndex = 0;
            cboPickupType.SelectedIndex = 0;
            cboChangeStatus.SelectedIndex = 0;

            // 掛回事件
            dtpStart.ValueChanged += dtpStart_ValueChanged;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
        }

        //  方法：顯示訂單列表， dgv.DataSource = dt，OrderID 藏在隱藏欄位

        void 顯示訂單列表()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            string strSQL =
                 "SELECT OrderID, OrderNo AS 訂單編號, CustomerName AS 訂購人, " +
                "ContactPhone AS 電話, " +
                "CASE PickupType WHEN 'ONSITE' THEN '現場' ELSE '宅配' END AS 取貨, " +
                "TotalAmount AS 合計, OrderStatus AS 狀態, " +
                "CONVERT(VARCHAR,OrderDate,111) AS 日期, " +
                "Note AS 備註 " +  
                "FROM Orders WHERE OrderDate >= @Start AND OrderDate < @End ";

            bool 有狀態篩選 = cboStatus.SelectedItem != null
                           && cboStatus.SelectedItem.ToString() != ""
                           && cboStatus.SelectedItem.ToString() != "全部";

            bool 有關鍵字 = txtSearch.Text.Trim() != "";

            if (有狀態篩選)
                strSQL += "AND OrderStatus = @Status ";

            if (有關鍵字)
                strSQL += "AND (CustomerName LIKE @Keyword OR ContactPhone LIKE @Keyword) ";

            strSQL += "ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Start", dtpStart.Value.Date);
            cmd.Parameters.AddWithValue("@End", dtpEnd.Value.Date.AddDays(1));

            if (有狀態篩選)
                cmd.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString());

            if (有關鍵字)
                cmd.Parameters.AddWithValue("@Keyword", "%" + txtSearch.Text.Trim() + "%");

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            con.Close();

            dgvOrderList.AutoGenerateColumns = false;
            dgvOrderList.DataSource = dt;

            // 清空所有勾選
            foreach (DataGridViewRow row in dgvOrderList.Rows)
                row.Cells["勾選"].Value = "False";

            dgvOrderList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvOrderList.Columns["勾選"].Width = 50;

            lblResultCount.Text = $"共 {dt.Rows.Count} 筆";
            dgvOrderDetail.DataSource = null;
            selectedOrderID = 0;
        }



        //  方法：顯示訂單明細，從 OrderDetails 查詢並填入 dgvOrderDetail，點選訂單 → 顯示下方明細(dgv CellClick 取 id )

        void 顯示訂單明細(int orderID)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            string strSQL = "SELECT ProductName AS 產品, " +
                            "UnitPrice AS 單價, Quantity AS 數量, LineTotal AS 小計 " +
                            "FROM OrderDetails WHERE OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@OrderID", orderID);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            con.Close();

            dgvOrderDetail.DataSource = dt;

            // 加總金額：把 dt 裡的小計欄加總
            int 總金額 = 0;
            foreach (DataRow row in dt.Rows)
                總金額 += Convert.ToInt32(row["小計"]);

            lblDetailTitle.Text = $"訂單明細　合計：NT$ {總金額:N0}";
        }


        //  取得所有勾選的訂單ID，若無勾選則 fallback 到 selectedOrderID

        List<int> 取得勾選訂單IDs()
        {
            List<int> ids = new List<int>();

            foreach (DataGridViewRow row in dgvOrderList.Rows)
            {
                var val = row.Cells["勾選"].Value;
                if (val != null && val.ToString() == "True")
                    ids.Add(Convert.ToInt32(row.Cells["OrderID"].Value));
            }

            if (ids.Count == 0 && selectedOrderID != 0)
                ids.Add(selectedOrderID);

            return ids;
        }


        //  批次寫入 DB 並重新整理列表

        void 批次更新狀態(List<int> ids, string newStatus)
        {

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            foreach (int id in ids)
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Orders SET OrderStatus=@Status, UpdatedAt=GETDATE() WHERE OrderID=@OrderID", con);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@OrderID", id);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show($"已將 {ids.Count} 筆訂單更新為：{newStatus}");
            顯示訂單列表();
        }


        //  查詢按鈕

        private void btnSearch_Click(object sender, EventArgs e)
        {
            顯示訂單列表();
        }


        //  清除搜尋條件

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            初始化篩選條件();
            顯示訂單列表();
        }


        //  確認更新狀態按鈕

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            List<int> ids = 取得勾選訂單IDs();
            if (ids.Count == 0) { MessageBox.Show("請先勾選或點選一筆訂單"); return; }

            string newStatus = cboChangeStatus.SelectedItem.ToString();
            if (MessageBox.Show($"確定將 {ids.Count} 筆訂單更新為「{newStatus}」？",
                "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            批次更新狀態(ids, newStatus);
        }


        //  取消訂單按鈕

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            List<int> ids = 取得勾選訂單IDs();
            if (ids.Count == 0) { MessageBox.Show("請先勾選或點選一筆訂單"); return; }

            if (MessageBox.Show($"確定要取消這 {ids.Count} 筆訂單？",
                "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            批次更新狀態(ids, "已取消");
        }


        //  日期/狀態改變時自動重新查詢
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            顯示訂單列表();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            顯示訂單列表();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            顯示訂單列表();
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var orderIDVal = dgvOrderList.Rows[e.RowIndex].Cells["OrderID"].Value;
            if (orderIDVal == null || orderIDVal == DBNull.Value) return;

            selectedOrderID = Convert.ToInt32(orderIDVal);
            顯示訂單明細(selectedOrderID);
        }

        private void dgvOrderList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrderList.IsCurrentCellDirty)
                dgvOrderList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnExportDelivery_Click(object sender, EventArgs e)
        {
            List<int> ids = 取得勾選訂單IDs();
            if (ids.Count == 0) { MessageBox.Show("請先勾選要匯出的宅配訂單"); return; }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine($"配送清單　匯出時間：{DateTime.Now:yyyy/MM/dd HH:mm}");
            sb.AppendLine("========================================");

            foreach (int id in ids)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT o.OrderNo, o.CustomerName, o.ContactPhone, o.Note, " +
                    "d.ReceiverName, d.ReceiverPhone, d.City, d.District, d.Address, d.DeliveryNote " +
                    "FROM Orders o LEFT JOIN DeliveryInfo d ON o.OrderID = d.OrderID " +
                    "WHERE o.OrderID = @OrderID AND o.PickupType = 'DELIVERY'", con);
                cmd.Parameters.AddWithValue("@OrderID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sb.AppendLine($"訂單編號：{reader["OrderNo"]}");
                    sb.AppendLine($"訂購人：{reader["CustomerName"]}　電話：{reader["ContactPhone"]}");
                    sb.AppendLine($"收件人：{reader["ReceiverName"]}　電話：{reader["ReceiverPhone"]}");
                    sb.AppendLine($"地址：{reader["City"]}{reader["District"]}{reader["Address"]}");
                    if (reader["DeliveryNote"].ToString() != "")
                        sb.AppendLine($"配送備註：{reader["DeliveryNote"]}");
                    if (reader["Note"].ToString() != "")
                        sb.AppendLine($"訂單備註：{reader["Note"]}");
                    sb.AppendLine("----------------------------------------");
                }
                else
                {
                    sb.AppendLine($"OrderID {id} 非宅配訂單，略過");
                    sb.AppendLine("----------------------------------------");
                }

                reader.Close();
            }

            con.Close();

            // 存檔
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文字檔 (*.txt)|*.txt";
            sfd.FileName = $"配送清單_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8);
            MessageBox.Show($"已匯出：{sfd.FileName}");
        }
    }
}