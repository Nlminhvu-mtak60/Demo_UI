using System;
using System.Drawing;
using System.Windows.Forms;

namespace FloriSys._2_QuanLy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void OnMenuClicked(string menuName)
        {
        }

        private void LoadChiTietDon(string maDon)
        {
        }

        private void LoadUC(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void ucThanhMenu1_Load(object sender, EventArgs e) { }
        private void ucThanhMenu1_Load_1(object sender, EventArgs e) { }
    }
}
