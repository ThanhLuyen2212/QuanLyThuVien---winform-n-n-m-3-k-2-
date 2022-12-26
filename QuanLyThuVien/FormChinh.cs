using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormChinh : Form
    {
        public static String chucnang;
        public FormChinh()
        {
            InitializeComponent();

            if (chucnang == "quantrivien")
            {
                btnNhanVien.Enabled = true;
                btnDocGia.Enabled = false;
                btnMuonSach.Enabled = false;
                btnPhieuphat.Enabled = false;
                btnSach.Enabled = false;
            }
            else
            {
                btnNhanVien.Enabled = false;            
            }
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            uC_TrangChu2.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            uC_TrangChu2.BringToFront();
        }

        private void ptbLibrarianClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();   
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            uC_QuanLySach1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_DocGia1.BringToFront();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            uC_MuonTraSach1.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            uC_BaoCaoThongKe1.BringToFront();
            uC_BaoCaoThongKe1.loaddata();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            uC_ThongTiCaNhan1.BringToFront();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            uC_NhanVien1.BringToFront();
        }

        private void btnPhieuphat_Click(object sender, EventArgs e)
        {
            uC_PhieuThuTienPhat1.BringToFront();
        }
    }
}
