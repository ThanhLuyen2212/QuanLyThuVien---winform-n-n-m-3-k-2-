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
    public partial class ChiTietPhieuMuon : Form
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);

        public ChiTietPhieuMuon()
        {
            InitializeComponent();
            filldataTODTGVSach();            
        }        

        public ChiTietPhieuMuon(string IDIssueBook) : this()
        {     
            tbIDPhieuMuon.Text = IDIssueBook;
            filldataTODTGV();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show();            
        }

        void filldataTODTGV()
        {
            con.Open();

            string query = "select * from CHITIETPHIEUMUON where IDPHIEUMUON = " + tbIDPhieuMuon.Text;

            SqlCommand command = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            con.Close();

            dtgvChitietSach.DataSource = dataTable;            
        }

        void filldataTODTGVSach()
        {
            con.Open();

            string query = "select * from SACH";

            SqlCommand command = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            con.Close();

            dtgvTimkiemSach.DataSource = dataTable;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (tbSearchBook.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên sách để tìm kiếm");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = @"select * from Sach where TenSach='" + tbSearchBook.Text + "' and SOLUONG > 0";

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    con.Close();

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có cuốn sách nào có tên như thế");
                    }
                    else
                    {
                        dtgvTimkiemSach.DataSource = dataTable;
                        tbSearchBook.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Sách đã được mượn hết");
                }               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbIDSach.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn sách để mượn");
            }
            else
            {
                con.Open();
                try
                {
                    UpdateBookSubtract(int.Parse(tbIDSach.Text));
                    string query = "insert into CHITIETPHIEUMUON values(" + tbIDPhieuMuon.Text + "," + tbIDSach.Text + ",'" + tbTenSach.Text + "','CHUA TRA')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm sách thành công");
                }
                catch
                {
                    MessageBox.Show("Bạn đã mượn cuốn sách này");
                }
                con.Close();
                filldataTODTGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDSach.Text == "" || tbIDPhieuMuon.Text == "")
            {
                MessageBox.Show("Bạn chọn sách trong bảng chi tiết phiếu mượn để xóa sách");
            }
            else
            {
                con.Open();
                updateBookAdd(int.Parse(tbIDSach.Text));
                string query = "delete from CHITIETPHIEUMUON where IDPHIEUMUON =" + tbIDPhieuMuon.Text + " and IDSACH =" + tbIDSach.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();                
                MessageBox.Show("Đã xóa sách thành công");
                con.Close();
                filldataTODTGV();                
            }
        }       

        public void updateBookAdd(int idSach)
        {
            int soluongsach = 0;
            string query = "SELECT SOLUONG FROM SACH WHERE IDSACH = " + idSach.ToString();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);            
            
                soluongsach = int.Parse(dataTable.Rows[0]["SOLUONG"].ToString());
            
            string query1 = "UPDATE SACH SET SOLUONG = " + (soluongsach + 1).ToString() + " WHERE IDSACH = " + idSach.ToString();
            SqlCommand command1 = new SqlCommand(query1, con);
            command1.ExecuteNonQuery();
        }

        private void UpdateBookSubtract(int idSach)
        {
            int soluongsach = 0;
            string query = "SELECT SOLUONG FROM SACH WHERE IDSACH = " + idSach.ToString();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
                soluongsach = int.Parse(dataTable.Rows[0]["SOLUONG"].ToString());
            
            string query1 = "UPDATE SACH SET SOLUONG = " + (soluongsach - 1).ToString() + " WHERE IDSACH = " + idSach.ToString();
            SqlCommand command1 = new SqlCommand(query1, con);
            command1.ExecuteNonQuery();
        }

        private void dtgvChitietSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDPhieuMuon.Text = dtgvChitietSach.SelectedRows[0].Cells[0].Value.ToString();
                tbIDSach.Text = dtgvChitietSach.SelectedRows[0].Cells[1].Value.ToString();
                tbTenSach.Text = dtgvChitietSach.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnLuuChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu chi tiết phiếu mượn");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show();            
        }

        private void dtgvTimkiemSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDSach.Text = dtgvTimkiemSach.SelectedRows[0].Cells[0].Value.ToString();
                tbTenSach.Text = dtgvTimkiemSach.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
