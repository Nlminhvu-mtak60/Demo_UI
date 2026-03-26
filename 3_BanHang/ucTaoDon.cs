using System;
using System.Windows.Forms;

namespace FloriSys._3_BanHang
{
    public partial class ucTaoDon : UserControl
    {
        public event Action DonDaTao;

        public ucTaoDon()
        {
            InitializeComponent();
        }

        private void ucTaoDon_Load(object sender, EventArgs e)
        {
        }

        private void btnTimSP_Click(object sender, EventArgs e) { }
        private void btnThemSP_Click(object sender, EventArgs e) { }
        private void btnXoaSP_Click(object sender, EventArgs e) { }
        private void btnXacNhan_Click(object sender, EventArgs e) { }
        private void btnHuy_Click(object sender, EventArgs e) { }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
