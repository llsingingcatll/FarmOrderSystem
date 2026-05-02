using System;
using System.Windows.Forms;

namespace FarmOrderSystem
{
    public partial class frmBossMenu : Form
    {
        public frmBossMenu()
        {
            InitializeComponent();
        }

        private void frmBossMenu_Load(object sender, EventArgs e)
        {

            // 顯示目前登入的帳號，把 GlobalVar.AdminAccount 顯示在標題或標籤上
            //lblWelcome.Text = "歡迎，" + GlobalVar.AdminAccount + "！";
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            // 開啟訂單查詢表單
            new frmOrderQuery().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // 開啟報表統計表單
            new frmReport().ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // 開啟會員管理表單
            new frmMember().ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //  開啟產品管理表單
            new frmProduct().ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            // 開啟折扣管理表單
            new frmDiscount().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 登出老闆帳號，關閉此表單

            GlobalVar.LogoutAdmin();
            this.Close();
        }
    }
}