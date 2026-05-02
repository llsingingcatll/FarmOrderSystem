using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace FarmOrderSystem
{
    public partial class frmOrder : Form
    {
        // 類別層級變數 
        List<int> listProductID = new List<int>();
        List<string> listProductNo = new List<string>();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<string> listOrigin = new List<string>();
        List<string> listUnit = new List<string>();
        List<string> listDescription = new List<string>();
        List<string> listCategoryName = new List<string>();

        string 目前篩選分類 = "";
        int 目前Tooltip產品ID = -1;

        public frmOrder()
        {
            InitializeComponent();
        }

        //  Form 載入

        private void frmOrder_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 30;
            toolTip1.ReshowDelay = 2;

            載入折扣下拉選單();
            載入分類下拉選單(); // SelectedIndex=0 觸發事件，但 listProductID.Count==0 所以直接 return
            讀取產品資料庫();
            顯示ListView產品列表();
            btnMyAccount.Visible = false; // 預設隱藏會員管理按鈕
            更新登入狀態();

            // 熱銷品暫時寫死，有訂單資料後可改成從 OrderDetails 統計
            lblHot1.Text = "有機高麗菜";
            lblHot2.Text = "青江菜";
            lblHot3.Text = "秋葵";
            lblHot4.Text = "玉米筍";
            lblHot5.Text = "三星蔥";
        }


        //  方法：載入分類下拉（從 DB 動態撈，新增分類不用改程式）

        void 載入分類下拉選單()
        {
            cboFilter.Items.Clear();
            cboFilter.Items.Add("全部產品");

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT CategoryName FROM Products WHERE IsOnShelf=1 AND CategoryName IS NOT NULL ORDER BY CategoryName", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                cboFilter.Items.Add(reader["CategoryName"].ToString());

            reader.Close();
            con.Close();

            cboFilter.SelectedIndex = 0;
        }


        //  方法：載入折扣下拉

        void 載入折扣下拉選單()
        {
            cboDiscount.Items.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Discounts WHERE IsActive=1 ORDER BY SortOrder", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                cboDiscount.Items.Add(reader["DiscountName"].ToString());

            reader.Close();
            con.Close();

            if (cboDiscount.Items.Count > 0)
            {
                cboDiscount.SelectedIndex = 0;
                cboDiscount_SelectedIndexChanged(null, null); // 主動觸發讀取折扣詳細資料到 GlobalVar
            }
        }


        //  方法：讀取產品資料庫，依目前篩選分類 決定 SQL，用參數化防 SQL Injection

        void 讀取產品資料庫()
        {
            listProductID.Clear();
            listProductNo.Clear();
            listProductName.Clear();
            listPrice.Clear();
            listOrigin.Clear();
            listUnit.Clear();
            listDescription.Clear();
            listCategoryName.Clear();

            imageList產品圖片 = new ImageList();
            imageList產品圖片.ImageSize = new Size(240, 220);
            imageList產品圖片.ColorDepth = ColorDepth.Depth32Bit;

            // 全部產品用簡單 SQL，有分類才加 WHERE CategoryName
            string strSQL = "";
            if (目前篩選分類 == "" || 目前篩選分類 == "全部產品")
                strSQL = "SELECT * FROM Products WHERE IsOnShelf=1 ORDER BY SortOrder";
            else
                strSQL = "SELECT * FROM Products WHERE IsOnShelf=1 AND CategoryName=@Category ORDER BY SortOrder";

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);

            if (目前篩選分類 != "" && 目前篩選分類 != "全部產品")
                cmd.Parameters.AddWithValue("@Category", 目前篩選分類);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listProductID.Add(Convert.ToInt32(reader["ProductID"]));
                listProductNo.Add(reader["ProductNo"].ToString());
                listProductName.Add(reader["ProductName"].ToString());
                listPrice.Add(Convert.ToInt32(reader["Price"]));
                listOrigin.Add(reader["Origin"].ToString());
                listUnit.Add(reader["Unit"].ToString());
                listDescription.Add(reader["Description"].ToString());
                listCategoryName.Add(reader["CategoryName"].ToString());

                // FileStream 開圖避免鎖檔
                string imgPath = GlobalVar.imageDir + @"\" + reader["ImageFile"].ToString();
                FileStream fs = File.OpenRead(imgPath);
                imageList產品圖片.Images.Add(Image.FromStream(fs));
                fs.Close();
            }

            reader.Close();
            con.Close();
        }


        //  方法：顯示 ListView 產品列表

        void 顯示ListView產品列表()
        {
            lvProducts.Clear();
            lvProducts.View = View.LargeIcon;
            lvProducts.LargeImageList = imageList產品圖片;

            for (int i = 0; i < listProductID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]}　NT${listPrice[i]:N0}/{listUnit[i]}";
                item.Tag = listProductID[i]; // ProductID 藏 Tag
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.ForeColor = Color.FromArgb(33, 33, 33);
                lvProducts.Items.Add(item);
            }
        }


        //  方法：重新載入（讀取 + 顯示 + 更新購物車）

        void 重新載入()
        {
            讀取產品資料庫();
            顯示ListView產品列表();
            更新購物車側欄();
        }


        //  方法：更新右側購物車側欄

        void 更新購物車側欄()
        {
            lstCartPreview.Items.Clear();

            foreach (CartItem item in GlobalVar.Cart.Values)
                lstCartPreview.Items.Add($"{item.ProductName} x{item.Quantity} = NT$ {item.LineTotal:N0}");

            int 小計 = GlobalVar.GetSubTotal();
            int 折扣 = GlobalVar.GetDiscountAmount(小計);

            lblSubtotal.Text = $"NT$ {小計:N0}";
            lblDiscountAmt.Text = $"- NT$ {折扣:N0}";
            lblTotal.Text = $"NT$ {(小計 - 折扣):N0}";
            lblCartCount.Text = $"共 {GlobalVar.Cart.Count} 項";
        }


        // 方法：會員狀態切換
        void 更新登入狀態()
        {
            if (GlobalVar.CurrentMemberID > 0)
            {
                // 會員已登入
                btnLogin.Text = "登出";
                btnMyAccount.Visible = true;
                btnMyAccount.Text = $"管理我的會員";
            }
            else
            {
                // 未登入
                btnLogin.Text = "會員/管理員登入";
                btnMyAccount.Visible = false;
            }
        }

        //  事件：切換點選產品

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                int idx = lvProducts.SelectedIndices[0];
                lblSelectedProd.Text = $"已選：{listProductName[idx]}  (NT$ {listPrice[idx]:N0} / {listUnit[idx]})";
                btnAddToCart.Enabled = true;
                nudQty.Value = 1;
            }
            else
            {
                lblSelectedProd.Text = "請先點選上方產品列";
                btnAddToCart.Enabled = false;
            }
        }

        //  事件：點選加入購物車

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先點選商品！");
                return;
            }

            int idx = lvProducts.SelectedIndices[0];
            int productID = listProductID[idx];
            int qty = (int)nudQty.Value;

            if (GlobalVar.Cart.ContainsKey(productID))
                GlobalVar.Cart[productID].Quantity += qty;
            else
                GlobalVar.Cart[productID] = new CartItem
                {
                    ProductID = productID,
                    ProductName = listProductName[idx],
                    UnitPrice = listPrice[idx],
                    Unit = listUnit[idx],
                    Quantity = qty
                };

            更新購物車側欄();
            MessageBox.Show($"{listProductName[idx]} x{qty} 已加入購物車！");
        }

        // 清空購物車

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (GlobalVar.Cart.Count == 0) return;

            if (MessageBox.Show("確定要清空購物車？", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalVar.ClearCart();
                更新購物車側欄();
            }
        }

        // 事件：結帳
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (GlobalVar.Cart.Count == 0)
            {
                MessageBox.Show("購物車是空的，請先選購商品！");
                return;
            }

            frmCart myCart = new frmCart();
            myCart.ShowDialog();
            更新購物車側欄(); // 結帳完回來後更新側欄（若清空了會顯示 0 項）
        }

        // 事件：關鍵字查詢產品

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "") {重新載入(); return;}

            讀取產品資料庫();
            lvProducts.Clear();
            lvProducts.View = View.LargeIcon;
            lvProducts.LargeImageList = imageList產品圖片;

            int count = 0;
            for (int i = 0; i < listProductName.Count; i++)
            {
                if (listProductName[i].Contains(keyword) == false) continue;

                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]}　NT${listPrice[i]:N0}/{listUnit[i]}　{listOrigin[i]}";
                item.Tag = listProductID[i];
                item.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                item.ForeColor = Color.FromArgb(33, 33, 33);
                lvProducts.Items.Add(item);
                count++;
            }

            if (count == 0)
                MessageBox.Show("查無此商品");
            else
                MessageBox.Show($"共找到 {count} 筆資料");
        }

        // 事件：分類篩選產品

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilter.SelectedItem == null) return;
            if (listProductID.Count == 0) return; // 初始化階段 List 還沒載入，直接 return

            目前篩選分類 = cboFilter.SelectedItem.ToString();
            重新載入();
        }


        // 事件：下拉式選單篩選產品

        private void cboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiscount.SelectedIndex < 0) return;

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Discounts WHERE DiscountName=@Name AND IsActive=1", con);
            cmd.Parameters.AddWithValue("@Name", cboDiscount.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                GlobalVar.CurrentDiscountID = (int)reader["DiscountID"];
                GlobalVar.CurrentDiscountName = reader["DiscountName"].ToString();
                GlobalVar.CurrentDiscountType = reader["DiscountType"].ToString();
                GlobalVar.CurrentDiscountRate = (double)reader["DiscountRate"];
                GlobalVar.CurrentMinAmount = (int)reader["MinAmount"];
                GlobalVar.CurrentIsBogo = (bool)reader["IsBogo"];
            }

            reader.Close();
            con.Close();

            更新購物車側欄();
        }

        //  事件：游標移至產品顯示文案
        private void lvProducts_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvProducts.GetItemAt(e.X, e.Y);

            if (item == null)
            {
                目前Tooltip產品ID = -1;
                toolTip1.Hide(lvProducts);
                return;
            }

            int idx = item.Index;
            int productID = listProductID[idx];

            if (productID == 目前Tooltip產品ID) return;

            目前Tooltip產品ID = productID;

            string tipText = $"【{listProductName[idx]}】\n" +
                             $"產地：{listOrigin[idx]}\n" +
                             $"單價：NT$ {listPrice[idx]:N0} / {listUnit[idx]}\n\n" +
                             listDescription[idx];

            toolTip1.Show(tipText, lvProducts, e.X + 15, e.Y + 10, 8000);
        }
        
        // 事件：點選要登入管理員或會員
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GlobalVar.CurrentMemberID > 0)
            {
                // 已登入 → 登出
                GlobalVar.ClearMember();
                更新登入狀態();
                return;
            }

            frmLogin myLogin = new frmLogin();
            myLogin.ShowDialog();

            更新登入狀態();

            if (GlobalVar.IsAdminLoggedIn)
                new frmBossMenu().Show();
        }
        //  事件：會員登入後可看見管理我的會員
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            // 直接開啟會員資料 Form（之後再新增這個 Form）
            // new frmMyAccount().ShowDialog();
            MessageBox.Show("即將推出管理我的會員功能，敬請期待！");
        }        
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // 不執行（Trim 在 btnSearch_Click 裡做就好）
        }

    }
}