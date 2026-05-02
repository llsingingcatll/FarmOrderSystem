using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmOrderSystem
{
    public partial class frmRegister : Form
    {
        // 外部可讀取：註冊成功後讓 frmCart 自動帶入
        public int RegisteredMemberID = 0;
        public string RegisteredMemberName = "";
        public string RegisteredMemberPhone = "";

        // 從 frmCart 傳入的手機號碼
        public string InitPhone = "";

        public frmRegister()
        {
            InitializeComponent();
        }

        
        //  Form 載入
        //  1. 帶入手機號碼
        //  2. 載入縣市下拉（從 GlobalData.CityList）
        //  3. 詳細地址提示文字效果
        
        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtRegPhone.Text = InitPhone;
            dtpRegBirthday.Value = DateTime.Now;

            // 載入縣市下拉（從 GlobalData.CityList）
            cboDeliveryCity.Items.Clear();
            foreach (string city in GlobalData.CityList)
                cboDeliveryCity.Items.Add(city);

            // 詳細地址提示文字效果
            txtDeliveryAddress.Text = "詳細地址（路/街/巷/號）";
            txtDeliveryAddress.ForeColor = System.Drawing.Color.Gray;
            txtDeliveryAddress.Enter += (s, ev) =>
            {
                if (txtDeliveryAddress.Text == "詳細地址（路/街/巷/號）")
                {
                    txtDeliveryAddress.Text = "";
                    txtDeliveryAddress.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtDeliveryAddress.Leave += (s, ev) =>
            {
                if (txtDeliveryAddress.Text.Trim() == "")
                {
                    txtDeliveryAddress.Text = "詳細地址（路/街/巷/號）";
                    txtDeliveryAddress.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        
        //  選縣市 → 更新鄉鎮下拉
        //  從 GlobalData.DistrictData 取對應的鄉鎮清單
       
        private void cboDeliveryCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeliveryDistrict.Items.Clear();

            // 取得選到的縣市，從 GlobalData.DistrictData 載入鄉鎮

            string city = cboDeliveryCity.SelectedItem.ToString();
            if (GlobalData.DistrictData.ContainsKey(city))
                foreach (string district in GlobalData.DistrictData[city])
                    cboDeliveryDistrict.Items.Add(district);
            if (cboDeliveryDistrict.Items.Count > 0)
                cboDeliveryDistrict.SelectedIndex = 0;
        }

       
        //  儲存並登入
        //  Step1：驗證必填
        //  Step2：查最大 MemberID 組合 MemberNo
        //  Step3：組合地址 INSERT Members
        //  Step4：寫入 GlobalVar
        //  Step5：成功訊息 → 關閉
       
        private void btnRegSave_Click(object sender, EventArgs e)
        {
            // Step1：驗證必填
            if (txtRegName.Text.Trim() == "")
            {
                MessageBox.Show("請填寫姓名");
                txtRegName.Focus();
                return;
            }
            if (txtRegPhone.Text.Trim() == "")
            {
                MessageBox.Show("請填寫手機號碼");
                txtRegPhone.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            // 查目前最大 MemberID，組合 MemberNo

            string strSQLMax = "SELECT ISNULL(MAX(MemberID), 0) FROM Members";
            SqlCommand cmdMax = new SqlCommand(strSQLMax, con);
            int maxID = Convert.ToInt32(cmdMax.ExecuteScalar()) + 1;
            string memberNo = "M" + maxID.ToString("D6");
            txtMemberID.Text = memberNo; // 顯示在 UI 的唯讀欄位

            // Step3：組合完整地址，INSERT Members

            string city = cboDeliveryCity.SelectedItem != null ? cboDeliveryCity.SelectedItem.ToString() : "";
            string district = cboDeliveryDistrict.SelectedItem != null ? cboDeliveryDistrict.SelectedItem.ToString() : "";
            string detail = txtDeliveryAddress.Text.Trim() == "詳細地址（路/街/巷/號）" ? "" : txtDeliveryAddress.Text.Trim();
            string fullAddress = city + district + detail;

            string strSQL =
                "INSERT INTO Members " +
                "(MemberNo, MemberName, Phone, Email, Birthday, Address, TotalPurchase, IsActive) " +
                "VALUES (@No, @Name, @Phone, @Email, @Birthday, @Address, 0, 1); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@No", memberNo);
            cmd.Parameters.AddWithValue("@Name", txtRegName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtRegPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", txtRegEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Birthday", dtpRegBirthday.Value.Date);
            cmd.Parameters.AddWithValue("@Address", fullAddress);
            int newMemberID = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            // Step4：寫入 GlobalVar，讓 frmCart 自動帶入姓名電話

            GlobalVar.CurrentMemberID = newMemberID;
            GlobalVar.CurrentMemberName = txtRegName.Text.Trim();
            GlobalVar.CurrentMemberPhone = txtRegPhone.Text.Trim();
            RegisteredMemberID = newMemberID;
            RegisteredMemberName = txtRegName.Text.Trim();
            RegisteredMemberPhone = txtRegPhone.Text.Trim();

            // Step5：成功訊息，設 DialogResult = OK 讓 frmCart 知道註冊成功，關閉

            MessageBox.Show($"歡迎加入，{GlobalVar.CurrentMemberName}！\n會員編號：{memberNo}");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        //  取消 → 關閉視窗
        
        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保留空方法，避免編譯錯誤
        private void txtDeliveryAddress_TextChanged(object sender, EventArgs e) { }
        private void checkBoxSignUp_CheckedChanged(object sender) { }
    }
}