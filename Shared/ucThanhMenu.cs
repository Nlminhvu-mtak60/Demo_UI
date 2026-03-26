using System;
using System.Windows.Forms;

namespace FloriSys.Shared
{
    public partial class ucThanhMenu : UserControl
    {
        public event Action<string> MenuClicked;

        public ucThanhMenu()
        {
            InitializeComponent();
        }

        private void ucThanhMenu_Load(object sender, EventArgs e)
        {
        }

        public void CapNhatNguoiDung(string hoTen, string chucVu, string avatarChar)
        {
        }

        public void PhanQuyen(string chucVu)
        {
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e) { }
        private void lblNhomTongQuan_Click(object sender, EventArgs e) { }
        private void lblNhomDonHang_Click(object sender, EventArgs e) { }
        private void lblNhomKhoHang_Click(object sender, EventArgs e) { }
        private void lblNhomGiaoHang_Click(object sender, EventArgs e) { }
        private void lblNhomQuanLy_Click(object sender, EventArgs e) { }
        private void lblNhomTaiKhoan_Click(object sender, EventArgs e) { }
        private void btnDoiMatKhau_Click(object sender, EventArgs e) { }
    }
}
