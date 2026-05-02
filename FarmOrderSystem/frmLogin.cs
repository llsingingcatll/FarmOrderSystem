using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FarmOrderSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.IntegratedSecurity = true;
            scsb.InitialCatalog = "FarmOrderDB";
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            timerlogin.Enabled = true; // 啟用timer

        }

        // 事件：登入會員
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // 會員登入
            if (rdbMemberLogin.Checked)
            {
                string phone = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                if (phone == "" || password == "") { MessageBox.Show("請輸入註冊手機號碼及密碼"); return; }

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                // 會員登入比對資料庫手機+密碼
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Members WHERE Phone=@Phone AND Password=@Password AND IsActive=1", con);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    GlobalVar.CurrentMemberID = (int)reader["MemberID"];
                    GlobalVar.CurrentMemberName = reader["MemberName"].ToString();
                    GlobalVar.CurrentMemberPhone = reader["Phone"].ToString();
                    GlobalVar.使用者權限 = (int)reader["RoleLevel"];
                    GlobalVar.使用者名稱 = reader["MemberName"].ToString();
                    reader.Close();
                    con.Close();
                    MessageBox.Show($"歡迎回來，{GlobalVar.CurrentMemberName}！");
                    this.Close();
                }
                else
                {
                    reader.Close();
                    con.Close();
                    lblError.Text = "查無此會員";
                    lblError.Visible = true;

                }
                return;
            }

            // 管理員登入
            string str帳號, str密碼 = "";
            str帳號 = txtUsername.Text.Trim();
            str密碼 = txtPassword.Text.Trim();

            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admins " +
                    "WHERE Account COLLATE Latin1_General_CS_AS  = @Account " +
                    "AND Password COLLATE Latin1_General_CS_AS = @Password " +
                    " AND IsActive = 1", con); // 用 COLLATE 指定大小寫必須完全相符資料庫
                cmd.Parameters.AddWithValue("@Account", str帳號);
                cmd.Parameters.AddWithValue("@Password", str密碼);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {   //登入成功
                    GlobalVar.IsAdminLoggedIn = true;
                    GlobalVar.AdminAccount = str帳號;
                    GlobalVar.使用者權限 = (int)reader["RoleLevel"];
                    GlobalVar.使用者名稱 = reader["AdminName"].ToString();
                    reader.Close();
                    con.Close();
                    this.Close();
                    return;

                }
                else
                {   // 登入失敗
                    lblError.Visible = true;
                    lblError.Text = "帳號或密碼錯誤，請注意大小寫。";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("登入所有欄位必填");

            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // 按 Enter 直接觸發登入，同登入按鈕
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        // 事件：註冊
        private void btnSignIp_Click(object sender, EventArgs e)
        {
            new frmRegister().ShowDialog();
        }   
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            lblError.Visible = false; // 輸入時清除錯誤提示訊息
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false; // 輸入時清除錯誤提示訊息
        }


        private void timerlogin_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("登入逾時，請重新登入"); // 超過一分鐘顯示訊息並關閉登入頁
            this.Close();
        }

        private void rdbMemberLogin_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "會員登入";
            lblUsername.Text = "手機號碼";
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblError.Visible = false;
        }

        private void rdbAdminLogin_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "管理員登入";
            lblUsername.Text = "帳號";
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblError.Visible = false;
            btnSignIp.Visible = false;
        }


    }
}