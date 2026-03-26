using System;
using System.Windows.Forms;

namespace FloriSys._3_BanHang
{
    public partial class ucDanhSachDon : UserControl
    {
        public event Action<string> XemChiTiet;
        public event Action TaoDonMoi;

        public ucDanhSachDon()
        {
            InitializeComponent();
        }

        private void ucDanhSachDon_Load(object sender, EventArgs e)
        {
        }

        public void LoadData()
        {
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        }
    }
}
