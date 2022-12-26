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
    public partial class UC_DocGia : UserControl
    {
        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);

        public UC_DocGia()
        {
            InitializeComponent();
        }

        public void doDuLieuVaodtgv()
        {
            con.Open();

            string query = @"select * from DOCGIA";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvDocGia.DataSource = dataTable;            
        }

        private void UC_DocGia_Load(object sender, EventArgs e)
        {
            doDuLieuVaodtgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTenDocGia.Text == "")
            {
                MessageBox.Show("Thông báo", "bạn hãy nhập tên sách cần tìm");
            }
            else
            {
                string query = @"select * from DocGia where TenDocGia='" + tbTenDocGia.Text + "'";

                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dtgvDocGia.DataSource = dataTable;

                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == "" || tbNameReader.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                con.Open();
                string query = "insert into DOCGIA (TENDOCGIA,SODIENTHOAI,DIACHI) values('" 
                                    + tbNameReader.Text + "','" + tbPhone.Text + "','" + tbAddress.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm độc giả thành công");
                con.Close();
                doDuLieuVaodtgv();
                nulltextbox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDReader.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập id độc giả muốn xóa");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = @"delete from docgia where IDDocGia = " + tbIDReader.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa độc giả thành công");
                    con.Close();
                    doDuLieuVaodtgv();
                    nulltextbox();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa độc giả");
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == "" || tbIDReader.Text == "" || tbNameReader.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                con.Open();
                string query = @"update DOCGIA set TENDOCGIA = '"+tbNameReader.Text+"',SODIENTHOAI = '"+tbPhone.Text+"',DIACHI = '"+tbAddress.Text+"' " +
                    "where IDDOCGIA = "+tbIDReader.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa độc giả thành công");
                con.Close();
                doDuLieuVaodtgv();
                nulltextbox();
            }
        }
        public void nulltextbox()
        {
            tbAddress.Text = "";
            tbIDReader.Text = "";
            tbNameReader.Text = "";
            tbPhone.Text = "";           
        }

        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDReader.Text = dtgvDocGia.SelectedRows[0].Cells[0].Value.ToString();
                tbNameReader.Text = dtgvDocGia.SelectedRows[0].Cells[1].Value.ToString();
                tbPhone.Text = dtgvDocGia.SelectedRows[0].Cells[2].Value.ToString();
                tbAddress.Text = dtgvDocGia.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
            
        }
    }

}
