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
    public partial class ReturnBookForm : Form
    {
        public string IDPhieuTra;
        public string IDPhieuMuon;
        public string IDDocgia;

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F7V5ELK\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");

        public ReturnBookForm()
        {
            InitializeComponent();     
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinh mainFrom = new FormChinh();
            mainFrom.Show();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            capnhatdulieubangmuonsach();
            capnhatdulieubangtrasach();
        }

        private void capnhatdulieubangmuonsach()
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

        private void capnhatdulieubangtrasach()
        {
            con.Open();

            string query = @"select * from PHIEUTRA";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvReturnbook.DataSource = dataTable;
        }  
        
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (tbIDPhieuMuon.Text == "" || dtpkReturnDate.Text == "" || tbIDReader.Text == "" || tbNameReader.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phiếu mượn để lập phiếu trả");
            }
            else
            {
                if (KiemTraPhieuMuonDaDuocTra(tbIDPhieuMuon.Text) == false)
                {
                    MessageBox.Show("Phiếu mượn này đã được trả");
                }
                else
                {
                    IDPhieuMuon = tbIDPhieuMuon.Text;
                    IDDocgia = tbIDReader.Text;
                    con.Open();
                    string returnDate = dtpkReturnDate.Value.Year.ToString() + "/" + dtpkReturnDate.Value.Month.ToString() + "/" + dtpkReturnDate.Value.Day.ToString();
                    string query = "insert into PHIEUTRA (IDPHIEUMUON,IDDOCGIA,NGAYTRA) "+
                        "values(" + tbIDPhieuMuon.Text + ","+tbIDReader.Text+",'" + returnDate + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    query = "SELECT * FROM PHIEUTRA where IDPHIEUMUON =" + IDPhieuMuon + " AND IDDOCGIA =" + IDDocgia;
                    cmd = new SqlCommand(query, con);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        IDPhieuTra = item["IDPHIEUTRA"].ToString();     
                    }
                    MessageBox.Show("Đã thêm phiếu tra thành công");
                    con.Close();
                   
                    this.Hide();
                    ChiTietPhieuTra chiTietPhieuTra = new ChiTietPhieuTra(IDPhieuTra, IDPhieuMuon, tbIDReader.Text, tbNameReader.Text);
                    chiTietPhieuTra.Show();
                    ReturnBookForm_Load(sender, e);
                }
            }    
        }

        private Boolean KiemTraPhieuMuonDaDuocTra( string idphieumuon)
        {
            string phieumuon;
            con.Open();
            string query = "select IDPHIEUMUON from PHIEUTRA";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                phieumuon = item["IDPHIEUMUON"].ToString();
                if (phieumuon == idphieumuon)
                {
                    con.Close();
                    return false;
                }                        
            }
            con.Close();
            return true;
        }

        public Boolean XoaPhieuTra(string IdPhieumuon)
        {            
            con.Open();

            string query = "SELECT TINHTRANG FROM CHITIETPHIEUMUON WHERE IDPHIEUMUON =" + IdPhieumuon;

            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow data in dataTable.Rows)
            {
                if(data["TINHTRANG"].ToString() == "CHUA TRA")
                {
                    con.Close();
                    return false;
                }
            }
            con.Close();
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (tbIDPhieuTra.Text == "" || tbIDPhieuMuon.Text == "" || tbIDPhieuTra.Text == "" || dtpkReturnDate.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn phiếu trả muốn xóa");
            }
            else
            {
                if (!XoaPhieuTra(tbIDPhieuMuon.Text))
                {
                    MessageBox.Show("Trong phiết trả có những cuốn sách chưa được trả.\nCần thực hiện trả sách hết");
                }else
                {

                    if (MessageBox.Show("Thao tác này sẽ xóa luôn những phiếu có liên quan đến phiếu trả này.\n Bạn có muốn thực hiện tiếp không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        con.Open();

                        //kiểm tra có phiếu phạt hay không
                        string query = "select count(*) as tong from phieuthutienphat where idphieutra = " + tbIDPhieuTra.Text;
                        SqlCommand cmd = new SqlCommand(query, con);
                        DataTable table  = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                        if (table.Rows[0]["tong"].ToString() != "0")
                        {
                            // kiểm tra đã trả đủ tiền chua
                            string query2 = "select SOTIENCONLAI from PHIEUTHUTIENPHAT where IDPHIEUTRA = " + tbIDPhieuTra.Text;
                            cmd = new SqlCommand(query2, con);
                            DataTable table3 = new DataTable();
                            adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(table3);
                            string s = table3.Rows[0]["SOTIENCONLAI"].ToString();
                            if (s != "0")
                            {
                                MessageBox.Show("Phiếu thu tiền phạt thuộc phiếu trả này chưa được hoàn thành.", "Thông báo");
                            }
                            else
                            {
                                // xoa het nhung phieu lien quan

                                // xoa phieu thu tien phat
                                query = "delete PHIEUTHUTIENPHAT where IDPHIEUTRA = " + tbIDPhieuTra.Text;
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                      
                                //xoa phieu tra 
                                query = "delete phieutra where IDPHIEUTRA = " + tbIDPhieuTra.Text;
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();

                                //xoa phieu phieu muon
                                query = "delete PHIEUMUON where IDPHIEUMUON = " + tbIDPhieuMuon.Text;
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Bạn đã xóa phiếu trả thành công");

                            }
                        }
                        con.Close();
                    }
                }                               
                nullTextBox();
                ReturnBookForm_Load(sender, e);
            }
        }

        private void dtgvReturnbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDPhieuTra.Text = dtgvReturnbook.SelectedRows[0].Cells[0].Value.ToString();
                tbIDReader.Text = dtgvReturnbook.SelectedRows[0].Cells[1].Value.ToString();
                tbIDPhieuMuon.Text = dtgvReturnbook.SelectedRows[0].Cells[2].Value.ToString();
                dtpkReturnDate.Text = dtgvReturnbook.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }           
            
        }

        void doDuLieuVaoCacTB(string idPhieuMuon)
        {
            con.Open();
            string query = "SELECT * FROM PHIEUMUON WHERE IDPHIEUMUON =" + idPhieuMuon;
            SqlCommand command = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                tbIDReader.Text = item["IDDOCGIA"].ToString();
                tbNameReader.Text = item["TENDOCGIA"].ToString();
            }
            con.Close();
        }

        private void ptbReturnBookClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinh mainFrom = new FormChinh();
            mainFrom.Show();
        }

        public void nullTextBox()
        {
            tbIDPhieuMuon.Text = "";
            tbIDPhieuTra.Text = "";
            tbIDReader.Text = "";
            tbNameReader.Text = "";
            dtpkReturnDate.Text = "";
        }

        private void btnChiTietPhieuTra_Click(object sender, EventArgs e)
        {
            if(tbIDPhieuMuon.Text == "" || tbIDPhieuTra.Text == ""|| tbIDReader.Text=="" || tbNameReader.Text =="")
            {
                MessageBox.Show("Bạn hãy chọn một phiếu trả để xem chi tiết phiếu trả");
            }
            else
            {
                this.Hide();
                ChiTietPhieuTra chiTietPhieuTra = new ChiTietPhieuTra(tbIDPhieuTra.Text, tbIDPhieuMuon.Text, tbIDReader.Text, tbNameReader.Text);
                chiTietPhieuTra.Show();
            }            
        }

        private void dtgvIssueBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDPhieuMuon.Text = dtgvIssueBook.SelectedRows[0].Cells[0].Value.ToString();
                tbIDReader.Text = dtgvIssueBook.SelectedRows[0].Cells[1].Value.ToString();
                tbNameReader.Text = dtgvIssueBook.SelectedRows[0].Cells[2].Value.ToString();
                tbIDPhieuTra.Text = "";
            }
            catch { }
        }
    }
}