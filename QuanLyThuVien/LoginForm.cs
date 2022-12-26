using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class LoginForm : Form
    {
        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public LoginForm()
        {
            InitializeComponent(); 
        }        

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT COUNT(*) FROM NHANVIEN WHERE TENTAIKHOAN ='" + tbUseName.Text + "'and MATKHAU='" + tbPassword.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (int.Parse(dataTable.Rows[0][0].ToString()) >= 1)
            {
                laychucnangnhanvien();
                this.Hide();
                FormChinh mainform = new FormChinh();
                mainform.Show();                
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void laychucnangnhanvien()
        {
            
            string query = "SELECT CHUCNANG, IDNHANVIEN FROM NHANVIEN WHERE TENTAIKHOAN ='" + tbUseName.Text + "' AND MATKHAU ='" + tbPassword.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            FormChinh.chucnang = table.Rows[0]["CHUCNANG"].ToString();
            UC_ThongTiCaNhan.idnhanvien = table.Rows[0]["IDNHANVIEN"].ToString();
        }
    }
}
