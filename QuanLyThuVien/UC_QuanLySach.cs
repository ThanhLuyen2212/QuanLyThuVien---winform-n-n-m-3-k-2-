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
    public partial class UC_QuanLySach : UserControl
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);

        public UC_QuanLySach()
        {
            InitializeComponent();
            dodulieuvaoDTGV();
        }

        public Boolean checkInt(string number)
        {
            int so = 0;
            return int.TryParse(number,out so);
        }

        public void dodulieuvaoDTGV()
        {
            con.Open();

            string query = @"select * from SACH";

            SqlCommand sqlCommand = new SqlCommand(query, con);            

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvBook.DataSource = dataTable;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(tbTenSach1.Text == "")
            {
                MessageBox.Show("Thông báo", "Bạn cần nhập tên sách để tìm kiếm");
            }
            else
            {
                con.Open();

                string query = @"select * from Sach where TenSach='" + tbTenSach1.Text + "'";

                SqlCommand sqlCommand = new SqlCommand(query, con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);               

                con.Close();
                
                if(dataTable.Rows.Count == 0)
                {
                    MessageBox.Show( "Không có cuốn sách nào có tên như thế", "Thông báo");
                    dodulieuvaoDTGV();
                }else
                {
                    dtgvBook.DataSource = dataTable;
                    tbTenSach1.Text = "";
                }
                    
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTenSach.Text == "" || tbSoLuong.Text == "" || tbTacGia.Text == "" || tbNhaXuatBan.Text == "" || TbGia.Text == ""|| tbTheloai.Text == "") 
            {
                MessageBox.Show("Thông báo", "bạn cần nhập đầy đủ thông tin để có thể thêm sách");
            }
            else
            {
                
                if (checkInt(tbSoLuong.Text) && checkInt(TbGia.Text))
                {
                    con.Open();

                    string query = @"Insert into SACH (TENSACH,TENTACGIA,NHAXUATBAN,THELOAI,SOLUONG,GIA)
                                    values('" + tbTenSach.Text + "','" + tbTacGia.Text + "','"
                                    + tbNhaXuatBan.Text + "','"+tbTheloai.Text+"'," + tbSoLuong.Text + "," + TbGia.Text + ")";

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    sqlCommand.ExecuteNonQuery();

                    con.Close();

                    dodulieuvaoDTGV();

                    nullText();

                    MessageBox.Show("Bạn đã thêm sách thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Bạn đã nhập sai kiểu dữ liệu cho số lượng và giá", "Thông báo");                
            }
        }       

        public void nullText()
        {
            tbIDSach.Text = "";
            tbNhaXuatBan.Text = "";
            tbSoLuong.Text = "";
            tbTacGia.Text = "";
            tbTenSach.Text = "";
            TbGia.Text = "";
            tbTheloai.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (tbTenSach.Text == "" || tbIDSach.Text == "" || tbSoLuong.Text == "" || tbTacGia.Text == "" || tbNhaXuatBan.Text == "" || TbGia.Text == "")
            {
                MessageBox.Show("Thông báo", "bạn cần nhập đầy đủ thông tin để có thể sửa sách");
            }
            else
            {
                con.Open();

                string query = @"update SACH set TenSach ='" + tbTenSach.Text + "',TenTacGia ='" + tbTacGia.Text + "',NhaXuatBan ='"
                    + tbNhaXuatBan.Text + "',Gia='" + TbGia.Text + "',Soluong = '" + tbSoLuong.Text + "' where IDSach =" + tbIDSach.Text;

                SqlCommand sqlCommand = new SqlCommand(query, con);

                sqlCommand.ExecuteNonQuery();

                con.Close();

                dodulieuvaoDTGV();

                nullText();
            }            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (tbIDSach.Text == "")
            {
                MessageBox.Show("Bạn cần chọn cuốn sách để xóa");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = @"delete from SACH where IDSACH =" + tbIDSach.Text;

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    sqlCommand.ExecuteNonQuery();

                    con.Close();

                    dodulieuvaoDTGV();

                    nullText();

                    MessageBox.Show("Bạn đã xóa thành công sách", "Thông báo");

                }
                catch
                {
                    MessageBox.Show("Không thể xóa sách");
                }
            }
        }

        private void dtgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDSach.Text = dtgvBook.SelectedRows[0].Cells[0].Value.ToString();
                tbTenSach.Text = dtgvBook.SelectedRows[0].Cells[1].Value.ToString();
                tbTheloai.Text = dtgvBook.SelectedRows[0].Cells[2].Value.ToString();
                tbTacGia.Text = dtgvBook.SelectedRows[0].Cells[3].Value.ToString();
                tbNhaXuatBan.Text = dtgvBook.SelectedRows[0].Cells[4].Value.ToString();
                tbSoLuong.Text = dtgvBook.SelectedRows[0].Cells[5].Value.ToString();
                TbGia.Text = dtgvBook.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch { }
        }


    }
}
