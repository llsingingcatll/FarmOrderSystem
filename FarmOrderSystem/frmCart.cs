using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FarmOrderSystem
{
    public partial class frmCart : Form
    {
        // 類別層級變數
        int newOrderID = 0;
        Random rnd = new Random(); // 用Random產生訂單號

        public frmCart()
        {
            InitializeComponent();

        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            載入訂單明細();
            cboDeliveryCity.DataSource = GlobalData.CityList; // 縣市下拉式選單
            cboDeliveryDistrict.DataSource = null; // 行政區設為null
            timerShoppingcar.Enabled = true;

            if (GlobalVar.CurrentMemberID > 0) // 如果訂購頁已登入會員
            {
                rdbMember.Checked = true;           // 切換到會員結帳
                txtCustomerName.Text = GlobalVar.CurrentMemberName;
                txtContactPhone.Text = GlobalVar.CurrentMemberPhone;
                // 隱藏手機/密碼欄位/提醒訪客訊息，改顯示已登入狀態
                txtPhone.Enabled = false;
                txtPassword.Enabled = false;
                lblAutoDetect.Visible = false;
                rdbGuest.Enabled = false; // 無法再切換到訪客模式
                btnLoginMember.Enabled = false; // 不需要再查詢
            }


        }

        // 方法：載入訂單明細，倒出暫存在全域變數的購物車資料
        void 載入訂單明細()
        {
            dgvCartItems.Rows.Clear();

            foreach (CartItem item in GlobalVar.Cart.Values)
            {
                dgvCartItems.Rows.Add(
                    item.ProductName,
                    $"{item.Quantity }{item.Unit}",
                    "NT$ " + item.UnitPrice.ToString("N0"),
                    "NT$ " + item.LineTotal.ToString("N0"),
                    item.ProductID

                );
            }

            更新合計金額();
        }

        // 方法：更新合計金額
        void 更新合計金額()
        {
            int 小計 = GlobalVar.GetSubTotal();
            int 折扣 = GlobalVar.GetDiscountAmount(小計);
            int 合計 = 小計 - 折扣;

            lblCartTotal.Text = "合計  NT$ " + 合計.ToString("N0");
            lblFinalTotal.Text = "NT$ " + 合計.ToString("N0");
        }


        // 方法：寫入訂單主檔，先取得 newOrderID，再寫入訂單明細

        int 寫入訂單主檔(SqlConnection con, string orderNo, int 小計, int 折扣, int 運費, int 合計)
        {
            string strSQL =
                "INSERT INTO Orders " +
                "(OrderNo, MemberID, IsGuestOrder, CustomerName, ContactPhone, " +
                "PickupType, DiscountID, SubTotal, DiscountAmount, DeliveryFee, " +
                "TotalAmount, PaymentMethod, OrderStatus, Note) " +
                "VALUES " +
                "(@OrderNo, @MemberID, @IsGuest, @CustomerName, @ContactPhone, " +
                "@PickupType, @DiscountID, @SubTotal, @DiscountAmt, @DeliveryFee, " +
                "@TotalAmount, @Payment, N'待確認', @Note); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@OrderNo", orderNo);

            // 會員 or 訪客
            if (GlobalVar.CurrentMemberID == 0)
            {
                cmd.Parameters.AddWithValue("@MemberID", DBNull.Value);
                cmd.Parameters.AddWithValue("@IsGuest", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@MemberID", GlobalVar.CurrentMemberID);
                cmd.Parameters.AddWithValue("@IsGuest", 0);
            }

            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactPhone", txtContactPhone.Text.Trim());

            // 取貨方式
            if (rdbDelivery.Checked == true)
                cmd.Parameters.AddWithValue("@PickupType", "DELIVERY");
            else
                cmd.Parameters.AddWithValue("@PickupType", "ONSITE");

            cmd.Parameters.AddWithValue("@DiscountID", GlobalVar.CurrentDiscountID);
            cmd.Parameters.AddWithValue("@SubTotal", 小計);
            cmd.Parameters.AddWithValue("@DiscountAmt", 折扣);
            cmd.Parameters.AddWithValue("@DeliveryFee", 運費);
            cmd.Parameters.AddWithValue("@TotalAmount", 合計);

            // 付款方式（沒選就預設現金）
            if (cboPayment.SelectedItem != null)
                cmd.Parameters.AddWithValue("@Payment", cboPayment.SelectedItem.ToString());
            else
                cmd.Parameters.AddWithValue("@Payment", "現金");

            cmd.Parameters.AddWithValue("@Note", txtOrderNote.Text.Trim());

            // ExecuteScalar：執行 INSERT 後用 SCOPE_IDENTITY() 取得剛新增的 OrderID
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // 方法：寫入訂單明細（逐筆 INSERT OrderDetails）

        void 寫入訂單明細(SqlConnection con)
        {
            foreach (CartItem item in GlobalVar.Cart.Values)
            {
                string strSQLDetail =
                    "INSERT INTO OrderDetails " +
                    "(OrderID, ProductID, ProductName, UnitPrice, Unit, Quantity, LineTotal) " +
                    "VALUES (@OrderID, @ProductID, @ProductName, @UnitPrice, @Unit, @Quantity, @LineTotal)";

                SqlCommand cmdDetail = new SqlCommand(strSQLDetail, con);

                // 帶入 OrderDetails 參數
                cmdDetail.Parameters.AddWithValue("@OrderID", newOrderID);
                cmdDetail.Parameters.AddWithValue("@ProductID", item.ProductID);
                cmdDetail.Parameters.AddWithValue("@ProductName", item.ProductName);
                cmdDetail.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                cmdDetail.Parameters.AddWithValue("@Unit", item.Unit);
                cmdDetail.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmdDetail.Parameters.AddWithValue("@LineTotal", item.LineTotal);
                cmdDetail.ExecuteNonQuery();
            }
        }

        // 方法：寫入宅配資訊（僅宅配時呼叫）

        void 寫入宅配資訊(SqlConnection con)
        {
            string strSQLDelivery =
                "INSERT INTO DeliveryInfo " +
                "(OrderID, ReceiverName, ReceiverPhone, City, District, Address, DeliveryNote) " +
                "VALUES (@OrderID, @ReceiverName, @ReceiverPhone, @City, @District, @Address, @Note)";

            SqlCommand cmdDelivery = new SqlCommand(strSQLDelivery, con);

            // 帶入 DeliveryInfo 參數
            cmdDelivery.Parameters.AddWithValue("@OrderID", newOrderID);
            cmdDelivery.Parameters.AddWithValue("@ReceiverName", txtDeliveryName.Text.Trim());
            cmdDelivery.Parameters.AddWithValue("@ReceiverPhone", txtDeliveryPhone.Text.Trim());
            cmdDelivery.Parameters.AddWithValue("@City", cboDeliveryCity.Text.Trim());
            cmdDelivery.Parameters.AddWithValue("@District", cboDeliveryDistrict.Text.Trim());
            cmdDelivery.Parameters.AddWithValue("@Address", txtDeliveryAddress.Text.Trim());
            cmdDelivery.Parameters.AddWithValue("@Note", txtDeliveryNote.Text.Trim());
            cmdDelivery.ExecuteNonQuery();
        }


        // 事件：取貨方式切換

        private void rdbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            pnlDeliveryInfo.Visible = rdbDelivery.Checked;
        }

        private void rdbOnSite_CheckedChanged(object sender, EventArgs e)
        {
            pnlDeliveryInfo.Visible = false;
        }


        // 事件：訂購身分切換

        private void rdbMember_CheckedChanged(object sender, EventArgs e)
        {
            pnlMemberSection.Visible = rdbMember.Checked;
        }

        private void rdbGuest_CheckedChanged(object sender, EventArgs e)
        {
            pnlMemberSection.Visible = false;
            txtCustomerName.Text = "";
            txtContactPhone.Text = "";
        }


        // 事件：登入會員

        private void btnLookupMember_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (phone == "" || password == "")
            {
                MessageBox.Show("請輸入註冊手機及密碼");
                return;
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            // 會員登入比對資料庫手機+密碼
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Members WHERE Phone=@Phone AND Password=@Password AND IsActive=1", con);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                GlobalVar.CurrentMemberID = (int)reader["MemberID"];
                GlobalVar.CurrentMemberName = reader["MemberName"].ToString();
                GlobalVar.CurrentMemberPhone = reader["Phone"].ToString();
                MessageBox.Show($"歡迎回來，{GlobalVar.CurrentMemberName}！");
                txtCustomerName.Text = GlobalVar.CurrentMemberName; // 登入成功自動填入訂購人姓名
                txtContactPhone.Text = GlobalVar.CurrentMemberPhone; // 登入成功自動填入訂購人電話
            }
            else
            {
                MessageBox.Show("帳號密碼錯誤，請注意大小寫。");
                if (MessageBox.Show("是否要註冊會員? ", "Yes / No", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new frmRegister().ShowDialog();
                }

            }

            reader.Close();
            con.Close();
        }


        // 事件：確認下單

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            // Step1：檢查必填欄位
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("請填寫訂購人姓名");
                txtCustomerName.Focus();
                return;
            }
            if (txtContactPhone.Text.Trim() == "")
            {
                MessageBox.Show("請填寫聯絡電話");
                txtContactPhone.Focus();
                return;
            }
            if (rdbDelivery.Checked && txtDeliveryName.Text.Trim() == "")
            {
                MessageBox.Show("請填寫收件人姓名");
                txtDeliveryName.Focus();
                return;
            }
            if (rdbDelivery.Checked && txtDeliveryAddress.Text.Trim() == "")
            {
                MessageBox.Show("請填寫配送地址");
                txtDeliveryAddress.Focus();
                return;
            }

            // Step2：組合訂單編號
            string orderNo = "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(10, 99).ToString();

            // Step3：計算金額
            int 小計 = GlobalVar.GetSubTotal();
            int 折扣 = GlobalVar.GetDiscountAmount(小計);
            int 運費 = rdbDelivery.Checked ? GlobalVar.DeliveryFee : 0;
            if (rdbDelivery.Checked && 小計 >= GlobalVar.FreeDeliveryMin) 運費 = 0;
            int 合計 = 小計 - 折扣 + 運費;

            // Step4~6：共用同一條連線
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            newOrderID = 寫入訂單主檔(con, orderNo, 小計, 折扣, 運費, 合計); // Step4
            寫入訂單明細(con);                                                 // Step5
            if (rdbDelivery.Checked) 寫入宅配資訊(con);                       // Step6

            con.Close();

            // Step7：成功訊息 → 清空購物車 → 關閉

            MessageBox.Show("訂單 " + orderNo + " 已成立！\n感謝您的訂購！");
            GlobalVar.ClearCart();
            this.Close();
        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDeliveryCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確保有選中項目
            if (cboDeliveryCity.SelectedItem == null) return;

            string selectedCity = cboDeliveryCity.SelectedItem.ToString();

            // 根據縣市從全域變數抓取行政區
            if (GlobalData.DistrictData.ContainsKey(selectedCity))
            {
                // 設定給 District 的 ComboBox
                cboDeliveryDistrict.DataSource = GlobalData.DistrictData[selectedCity];
            }
        }

        private void cboDeliveryDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 當行政區改變時，不需要再寫程式碼去連動縣市，取得最後完整的地址字串
            if (cboDeliveryDistrict.SelectedItem != null)
            {
                string fullAddress = cboDeliveryCity.Text + cboDeliveryDistrict.Text;
                Console.WriteLine($"目前選擇區域：{fullAddress}");
            }
        }

        private void timerShoppingcar_Tick(object sender, EventArgs e)
        {
            timerShoppingcar.Enabled = false; // 只跳一次
            MessageBox.Show("數量有限，要搶要快!"); // 超過10分鐘顯示
        }
    }
}