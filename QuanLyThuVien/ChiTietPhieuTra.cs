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
    public partial class ChiTietPhieuTra : Form
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public string idphieutra;
        public string idphieuMuon;
        public string iddocgia;
        public string tendocgia;

        private int songayduocmuon;
        private int sotienphat;
        Boolean luuphieu = false;

        public ChiTietPhieuTra()
        {
            InitializeComponent();            
        }
        private void ChiTietPhieuTra_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from THAMSO";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            songayduocmuon = int.Parse(table.Rows[0]["SONGAYDUOCMUON"].ToString());
            sotienphat = int.Parse(table.Rows[0]["SOTIENPHAT"].ToString());
            con.Close();
        }

        public ChiTietPhieuTra(string idphieutra, string idphieuMuon,string iddocgia, string tendocgia)
        {
            InitializeComponent();
            this.idphieutra = idphieutra;
            this.idphieuMuon = idphieuMuon;
            this.iddocgia = iddocgia;
            this.tendocgia = tendocgia;
            tbIDPhieuMuon.Text = idphieuMuon;
            tbIDPhieuTra.Text = idphieutra;
       
            filldataTOdtgvSachdamuon();
            filldataTOdtgvSachdaDuocTra();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (luuphieu)
            {
                this.Hide();
                ReturnBookForm returnBookForm = new ReturnBookForm();
                kiemtradatradu();
                returnBookForm.Show();
            }else
            {
                MessageBox.Show("Bạn chưa lưu phiếu");
            }
            
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (luuphieu)
            {
                this.Hide();
                ReturnBookForm returnBookForm = new ReturnBookForm();
                returnBookForm.Show();
                kiemtradatradu();
            }else
            {
                MessageBox.Show("Bạn chưa lưu phiếu");
            }            
        }

        private void btnLuuChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            luuphieu = true;
            // cập nhật số tiền bị phạt vào phiếu trả và lập phiếu thu tiền phạt tự động 
            con.Open();
            int tongtienphat = 0;
            string query = "select SUM(tienphat) as tong from CHITIETPHIEUTRA where IDPHIEUTRA = " + idphieutra;
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            tongtienphat = int.Parse(table.Rows[0]["tong"].ToString());
            query = "update PHIEUTRA set TIENPHAT = "+tongtienphat.ToString()+" where IDPHIEUTRA = " + idphieutra;
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            if (tongtienphat > 0)
            {

                // lập phiếu phạt tự động
                // kiểm tra phiếu phạt đã được tạo hay chưa

                query = "select count(*) as tong from phieuthutienphat where idphieutra = " + idphieutra;
                cmd = new SqlCommand(query, con);
                table = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                if (table.Rows[0]["tong"].ToString() == "0")
                {
                    query = "insert into PHIEUTHUTIENPHAT(IDPHIEUTRA,IDDOCGIA,TENDOCGIA,SOTIENPHAT,SOTIENDATHU,SOTIENCONLAI)" +
                                            "values (" + idphieutra + "," + iddocgia + ",'" + tendocgia + "'," + tongtienphat + ",0,"+tongtienphat+" )";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    query = "update PHIEUTHUTIENPHAT set SOTIENPHAT = " + tongtienphat + " where IDPHIEUTRA = " + idphieutra;
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Đã lưu chi tiết phiếu trả");
            con.Close();
        }

        void filldataTOdtgvSachdamuon()
        {
            con.Open();

            string query = "select * from CHITIETPHIEUMUON where IDPHIEUMUON = " + tbIDPhieuMuon.Text;

            SqlCommand command = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            con.Close();

            dtgvSachDaDuocMuon.DataSource = dataTable;
        }

        void filldataTOdtgvSachdaDuocTra()
        {
            con.Open();

            string query = "select * from CHITIETPHIEUTRA where IDPHIEUTRA = " + tbIDPhieuTra.Text;

            SqlCommand command = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            con.Close();

            dtgvChitietPhieuTra.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            luuphieu = false;

            if (tbIDPhieuMuon.Text == "" || tbIDSach.Text == "" || tbTenSach.Text == "" || dtpkNgayTra.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn sách muốn trả vào");
            }
            else
            {
                con.Open();
                try
                {
                    string ngaytra = dtpkNgayTra.Value.Year.ToString() + "/" + dtpkNgayTra.Value.Month.ToString() + "/" + dtpkNgayTra.Value.Day.ToString();
                    string query1 = "insert into CHITIETPHIEUTRA (IDPHIEUTRA,IDSACH,TENSACH,NGAYTRA)" +
                        " values(" + tbIDPhieuTra.Text + "," + tbIDSach.Text + ",'" + tbTenSach.Text + "','" + ngaytra + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();

                    // kiểm tra mượn quá hạn hay không
                    DateTime ngaytra1 = new DateTime(int.Parse(dtpkNgayTra.Value.Year.ToString()),
                                                     int.Parse(dtpkNgayTra.Value.Month.ToString()),
                                                     int.Parse(dtpkNgayTra.Value.Day.ToString()));

                    string query = "select NGAYMUON from PHIEUMUON where IDPHIEUMUON =  " + tbIDPhieuMuon.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    string s = table.Rows[0]["NGAYMUON"].ToString();
                    string[] ss = s.Split('/'); // cat lay nam , thang
                    string[] sss = ss[2].Split(' '); // cat lay ngay

                    DateTime ngaymuon = new DateTime(int.Parse(sss[0]), int.Parse(ss[0]), int.Parse(ss[1]));
                    TimeSpan timeSpan = ngaytra1.Subtract(ngaymuon);
                   
                    string[] tmp = timeSpan.ToString().Split('.');
                    int songaymuon = 0;
                    try
                    {
                        songaymuon = int.Parse(tmp[0]);
                    }
                    catch { }
                    int tienphat = 0;
                    if (songaymuon > songayduocmuon)
                    {
                        tienphat = (songaymuon - songayduocmuon) * sotienphat;
                    }
                    /// -------------------------------------------///
                    /// 
                    query = "update CHITIETPHIEUTRA set TIENPHAT = " + tienphat + " where IDPHIEUTRA = " + tbIDPhieuTra.Text + " AND IDSACH = " + tbIDSach.Text;
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    query = "update CHITIETPHIEUMUON set TINHTRANG = 'DA TRA' WHERE IDPHIEUMUON = " + tbIDPhieuMuon.Text + " AND IDSACH = " + tbIDSach.Text;
                    cmd1 = new SqlCommand(query, con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Đã trả sách thành công");
                    updateBookAdd(int.Parse(tbIDSach.Text.ToString()));
                }
                catch
                {
                    MessageBox.Show("Bạn đã trả cuốn sách này");
                }
                con.Close();
                filldataTOdtgvSachdaDuocTra();
                filldataTOdtgvSachdamuon();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            luuphieu = false;
            if (tbIDPhieuMuon.Text == "" || tbIDSach.Text == "" || tbTenSach.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn sách muốn xóa");
            }
            else
            {
                con.Open();              
                string query = "delete from CHITIETPHIEUTRA where IDPHIEUTRA =" + tbIDPhieuTra.Text + "and IDSACH = "
                    + tbIDSach.Text + " and TENSACH ='" + tbTenSach.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);                 
                MessageBox.Show("Đã xóa sách mà bạn muốn xóa");
                query = "update CHITIETPHIEUMUON set TINHTRANG = 'CHUA TRA' WHERE IDPHIEUMUON = " + tbIDPhieuMuon.Text + " AND IDSACH = " + tbIDSach.Text;
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                UpdateBookSubtract(int.Parse(tbIDSach.Text.ToString()));
                con.Close();
                filldataTOdtgvSachdaDuocTra();
                filldataTOdtgvSachdamuon();
            }
        }        

        void kiemtradatradu()//kiểm tra số lượng sách đã trả đủ hay chưa
        {
            con.Open();
            string query1 = "select count(*) as TONG from CHITIETPHIEUTRA where IDPHIEUTRA = " + idphieutra;
            string query2 = "select count(*) as TONG from CHITIETPHIEUMUON where IDPHIEUMUON = " + idphieuMuon;

            int tong1, tong2;
            SqlCommand cmd = new SqlCommand(query1, con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            tong1 = int.Parse(table.Rows[0]["TONG"].ToString());
             cmd = new SqlCommand(query2, con);
             table = new DataTable();
             adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            tong2 = int.Parse(table.Rows[0]["TONG"].ToString());
            
            if(tong1 == tong2)
            {
                string query = "update PHIEUMUON set TINHTRANG = 'DA TRA' where IDPHIEUMUON =" + idphieuMuon;
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query = "update PHIEUMUON set TINHTRANG = 'CHUA TRA' where IDPHIEUMUON =" + idphieuMuon;
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
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

        private void UpdateBookSubtract(int idSach)
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
            string query1 = "UPDATE SACH SET SOLUONG = " + (soluongsach - 1).ToString() + " WHERE IDSACH = " + idSach.ToString();
            SqlCommand command1 = new SqlCommand(query1, con);
            command1.ExecuteNonQuery();
        }

        private void dtgvSachDaDuocMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDSach.Text = dtgvSachDaDuocMuon.SelectedRows[0].Cells[1].Value.ToString();
                tbTenSach.Text = dtgvSachDaDuocMuon.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void dtgvChitietPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDSach.Text = dtgvChitietPhieuTra.SelectedRows[0].Cells[1].Value.ToString();
                tbTenSach.Text = dtgvChitietPhieuTra.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }
    }
}
