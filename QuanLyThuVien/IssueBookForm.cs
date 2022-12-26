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
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
            populate();
            cbIDReader.Text = "";
        }

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public void fillcbIDDocGia()
        {
            con.Open();
            String query = "SELECT IDDocGia FROM DOCGIA";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader sqlDataReader;
            sqlDataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("IDDocGia", typeof(int));
            dataTable.Load(sqlDataReader);
            cbIDReader.ValueMember = "IDDocGia";
            cbIDReader.DataSource = dataTable;
            con.Close();
        }

        public void populate() // do du lieu vao database
        {
            con.Open();

            string query = @"select * from PHIEUMUON";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvIssueBook.DataSource = dataTable;
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            fillcbIDDocGia();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinh mainFrom = new FormChinh();
            mainFrom.Show();
        }       

        private void cbIDReader_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            fetchstDataToReader();         
        }

        private void fetchstDataToReader()// tìm nạp dữ liệu
        {
            con.Open();
            string query = "SELECT * FROM DOCGIA WHERE IDDocGia = '" + cbIDReader.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            foreach(DataRow item in dataTable.Rows)
            {
                tbNameReader.Text = item["TENDOCGIA"].ToString();                
            }
            con.Close();
        }

        public string idphieumuon;

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cbIDReader.Text == "" || dtpkNgayMuon.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin cho phiếu mượn");
            }
            if (KiemTraDocGiaDaMuonSachdatra(cbIDReader.Text))
            {
                MessageBox.Show("Đôc giả này có phiếu trả chưa hoàn thành");

            }
            else
            {                
                con.Open();
                string issueDate = dtpkNgayMuon.Value.Year.ToString() + "/" + dtpkNgayMuon.Value.Month.ToString() + "/" + dtpkNgayMuon.Value.Day.ToString();                

                string query = "insert into PHIEUMUON(IDDOCGIA,TENDOCGIA,NGAYMUON,TINHTRANG)" +
                                " output inserted.IDPHIEUMUON "+
                               " values(" + cbIDReader.Text + ",'" + tbNameReader.Text + "','" + issueDate + "','CHUA TRA')";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    idphieumuon = item["IDPHIEUMUON"].ToString();                   
                }                        
                MessageBox.Show("Đã thêm phiếu mượn thành công");
                con.Close();
                populate();
                this.Hide();
                ChiTietPhieuMuon chiTietPhieuMuon = new ChiTietPhieuMuon(idphieumuon);
                chiTietPhieuMuon.Show();
                nulltextbox();
            }
        }

        private Boolean KiemTraDocGiaDaMuonSachdatra(string IDDocGia)
        {            
            string tinhtrang;
            con.Open();
            string query = "select TINHTRANG from PHIEUMUON where IDdocgia = "+IDDocGia;
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                tinhtrang = item["TINHTRANG"].ToString();
                
                if (tinhtrang == "CHUA TRA")
                {
                    con.Close();
                    return true;
                }  
            }
            con.Close();
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDIssueBook.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập ID phiếu muốn xóa");
            }
            else
            {
                con.Open();
                string query = "select count(*) as TONG from PHIEUMUON where IDPhieuMuon =" + tbIDIssueBook.Text + " and TINHTRANG = 'DA TRA'";
                SqlCommand command = new SqlCommand(query, con);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows[0]["TONG"].ToString() == "0")
                {
                    MessageBox.Show("Bạn không thể xóa phiếu mượn vì phiếu mượn này có những cuốn sách chưa được trả");
                }
                else
                {
                    if (MessageBox.Show("Thao tác này sẽ xóa luôn những phiếu có liên quan đến phiếu mượn này.\n Bạn có muốn thực hiện tiếp không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string idphieutra = "";

                        // lấy id phiếu trả
                        string query1 = "select idphieutra from PHIEUTRA where IDPHIEUMUON = " + tbIDIssueBook.Text;
                        command = new SqlCommand(query1, con);
                        DataTable tabel = new DataTable();
                        adapter = new SqlDataAdapter(command);
                        adapter.Fill(tabel);
                        idphieutra = tabel.Rows[0]["IDPHIEUTRA"].ToString();

                        //kiểm tra có phiếu phạt hay không
                        query = "select count(*) as tong from phieuthutienphat where idphieutra = " + idphieutra;
                        command = new SqlCommand(query, con);
                        tabel = new DataTable();
                        adapter = new SqlDataAdapter(command);
                        adapter.Fill(tabel);
                        if (tabel.Rows[0]["tong"].ToString() != "0")
                        {
                            // kiểm tra đã trả đủ tiền chua
                            string query2 = "select SOTIENCONLAI from PHIEUTHUTIENPHAT where IDPHIEUTRA = " + idphieutra;
                            command = new SqlCommand(query2, con);
                            DataTable table3 = new DataTable();
                            adapter = new SqlDataAdapter(command);
                            adapter.Fill(table3);
                            string s = table3.Rows[0]["SOTIENCONLAI"].ToString();
                            if (s != "0")
                            {
                                MessageBox.Show("Phiếu thu tiền phạt của phiếu trả thuộc phiếu mượn này chưa được hoàn thành.", "Thông báo");
                            }
                            else
                            {
                                // xoa phieu thu tien phat
                                query = "delete PHIEUTHUTIENPHAT where IDPHIEUTRA = " + idphieutra;
                                command = new SqlCommand(query, con);
                                command.ExecuteNonQuery();

                                // xoa het nhung phieu liên quan điến phiếu mượn
                            //xoa phieu tra
                            query = "delete PHIEUTRA where IDPHIEUTRA = " + idphieutra + " and IDPHIEUMUON = " + tbIDIssueBook.Text;
                                command = new SqlCommand(query, con);
                                command.ExecuteNonQuery();

                                // xoa phieu muon
                                query = "DELETE PHIEUMUON WHERE IDPHIEUMUON =" + tbIDIssueBook.Text;
                                command = new SqlCommand(query, con);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Bạn đã thực hiện xóa thành công");
                            }                            
                            
                        }else
                        {
                            // xoa het nhung phieu liên quan điến phiếu mượn
                            //xoa phieu tra
                            query = "delete PHIEUTRA where IDPHIEUTRA = " + idphieutra + " and IDPHIEUMUON = " + tbIDIssueBook.Text;
                            command = new SqlCommand(query, con);
                            command.ExecuteNonQuery();

                            // xoa phieu muon
                            query = "DELETE PHIEUMUON WHERE IDPHIEUMUON =" + tbIDIssueBook.Text;
                            command = new SqlCommand(query, con);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã thực hiện xóa thành công");
                        }
                    }                 
                }
                con.Close();
                populate();
                nulltextbox();
            }
        }
     
        public void xoachitietphieumuon()
        {
            string IdPhieumuon = tbIDIssueBook.Text;            
            con.Open();

            string query = "SELECT IDSACH FROM CHITIETPHIEUMUON WHERE IDPHIEUMUON =" + IdPhieumuon;

            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach(DataRow data in dataTable.Rows)
            {
                updateBookAdd(int.Parse(data["IDSACH"].ToString()));
            }

            string query1 = "DELETE FROM CHITIETPHIEUMUON WHERE IDPHIEUMUON =" + IdPhieumuon;
            command = new SqlCommand(query1, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void updateBookAdd(int idSach)
        {
            int soluongsach = 0;
            string query = "SELECT SOLUONG FROM SACH WHERE IDSACH = " + idSach.ToString();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow data in dataTable.Rows)
            {
                soluongsach = int.Parse(data["SOLUONG"].ToString());
            }
            string query1 = "UPDATE SACH SET SOLUONG = " + (soluongsach + 1).ToString() + " WHERE IDSACH = " + idSach.ToString();
            SqlCommand command1 = new SqlCommand(query1, con);
            command1.ExecuteNonQuery();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIDIssueBook.Text == "" || cbIDReader.Text == ""|| dtpkNgayMuon.Text == "")
            {
                MessageBox.Show("Bạn chọn phiếu mượn muốn sửa");
            }
            else
            {
                con.Open();

                string issueDate = dtpkNgayMuon.Value.Year.ToString() + "/" + dtpkNgayMuon.Value.Month.ToString() + "/" + dtpkNgayMuon.Value.Day.ToString();                

                string query = "update PHIEUMUON set IDDOCGIA =" + cbIDReader.Text + ",NGAYMUON='" + issueDate + "' where IDPHIEUMUON =" + tbIDIssueBook.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sữa phiếu mượn thành công");                
                con.Close();
                populate();
                nulltextbox();                
            }
        }

        public void nulltextbox()
        {            
            tbIDIssueBook.Text = "";
            tbNameReader.Text = "";            
            cbIDReader.Text = "";            
        }

        private void dtgvIssueBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDIssueBook.Text = dtgvIssueBook.SelectedRows[0].Cells[0].Value.ToString();
                cbIDReader.Text = dtgvIssueBook.SelectedRows[0].Cells[1].Value.ToString();
                tbNameReader.Text = dtgvIssueBook.SelectedRows[0].Cells[2].Value.ToString();
                dtpkNgayMuon.Text = dtgvIssueBook.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
            
            
        }

        private void ptbCloseIssueBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinh mainFrom = new FormChinh();
            mainFrom.Show();
        }

        private void btnChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            if(tbIDIssueBook.Text == "")
            {
                MessageBox.Show("Thông báo bạn hãy chọn phiếu mượn sách để xem chi tiết phiếu mượn");
            }
            else
            {
                ChiTietPhieuMuon chiTietPhieuMuon = new ChiTietPhieuMuon(tbIDIssueBook.Text);
                chiTietPhieuMuon.Show();
            }            
        }        
    }
}
