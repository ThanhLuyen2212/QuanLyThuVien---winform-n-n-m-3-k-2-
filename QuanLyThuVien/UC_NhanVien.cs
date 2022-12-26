using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UC_NhanVien : UserControl
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public UC_NhanVien()
        {
            InitializeComponent();
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLibName.Text == "" || tbLibPassword.Text == "" || tbLibPhone.Text == "" || tbLibUesName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                con.Open();
                string query = "insert into NHANVIEN (TENNHANVIEN,TENTAIKHOAN,MATKHAU,SODIENTHOAI,CHUCNANG)" +
                               " values('" + tbLibName.Text + "','" + tbLibUesName.Text + "','"
                                + tbLibPassword.Text + "','" + tbLibPhone.Text + "','" + tbChucNang.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm nhân viên thành công");
                con.Close();
                populate();
                nulltextbox();
            }
        }
        public void nulltextbox()
        {
            tbLibID.Text = "";
            tbLibName.Text = "";
            tbLibPassword.Text = "";
            tbLibPhone.Text = "";
            tbLibUesName.Text = "";
            tbChucNang.Text = "";
        }

        public void populate()
        {
            con.Open();

            string query = @"select * from NHANVIEN";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvLibrarian.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbLibID.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập ID nhân viên muốn xóa");
            }
            else
            {
                con.Open();
                string query = "delete from NHANVIEN where IDNHANVIEN ='" + tbLibID.Text + "'";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bạn đã xóa nhân viên thành công");
                populate();
                nulltextbox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbLibID.Text == "" || tbLibName.Text == "" || tbLibPassword.Text == "" || tbLibPhone.Text == "" || tbLibUesName.Text == "" || tbChucNang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                con.Open();
                string query = "update NHANVIEN set TENNHANVIEN ='" + tbLibName.Text + "',TENTAIKHOAN ='" + tbLibUesName.Text + "',MATKHAU ='" + tbLibPassword.Text
                                         + "',SODIENTHOAI='" + tbLibPhone.Text + "',CHUCNANG='" + tbChucNang.Text + "' where IDNHANVIEN = ' " + tbLibID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa nhân viên thành công");
                con.Close();
                populate();
                nulltextbox();
            }
        }

        private void dtgvLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbLibID.Text = dtgvLibrarian.SelectedRows[0].Cells[0].Value.ToString();
                tbLibName.Text = dtgvLibrarian.SelectedRows[0].Cells[1].Value.ToString();
                tbLibUesName.Text = dtgvLibrarian.SelectedRows[0].Cells[2].Value.ToString();
                tbLibPassword.Text = dtgvLibrarian.SelectedRows[0].Cells[3].Value.ToString();
                tbLibPhone.Text = dtgvLibrarian.SelectedRows[0].Cells[4].Value.ToString();
                tbChucNang.Text = dtgvLibrarian.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch { }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTenNhanVien.Text == "")
            {
                MessageBox.Show("Thông báo", "bạn cần nhập tên nhân viên để tìm kiếm");
            }
            else
            {
                con.Open();

                string query = @"select * from NHANVIEN where TENNHANVIEN='" + tbTenNhanVien.Text + "'";

                SqlCommand sqlCommand = new SqlCommand(query, con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                con.Close();

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có nhân viên nào có tên như thế");
                    populate();
                }
                else
                {
                    dtgvLibrarian.DataSource = dataTable;
                    tbTenNhanVien.Text = "";
                }

            }
        }
    }
}
