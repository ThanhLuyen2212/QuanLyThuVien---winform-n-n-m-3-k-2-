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
    public partial class UC_PhieuThuTienPhat : UserControl
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public UC_PhieuThuTienPhat()
        {
            InitializeComponent();         
        }

        private void dtgvPhieuphat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbIDphieuphat.Text = dtgvPhieuphat.SelectedRows[0].Cells[0].Value.ToString();
                tbIDphieutra.Text = dtgvPhieuphat.SelectedRows[0].Cells[1].Value.ToString();
                tbIDdocgia.Text = dtgvPhieuphat.SelectedRows[0].Cells[2].Value.ToString();
                tbTendocgia.Text = dtgvPhieuphat.SelectedRows[0].Cells[3].Value.ToString();
                tbSotienphat.Text = dtgvPhieuphat.SelectedRows[0].Cells[4].Value.ToString();
                tbDathu.Text = dtgvPhieuphat.SelectedRows[0].Cells[5].Value.ToString();
                tbSotienconlai.Text = dtgvPhieuphat.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDphieuphat.Text != "")
            {
                con.Open();
                string query = "delete PHIEUTHUTIENPHAT WHERE IDPHIEUTHUTIENPHAT = " + tbIDphieuphat.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            UC_PhieuThuTienPhat_Load(sender, e);
            nulltextBox();
        }

        public Boolean checkInt(string number)
        {
            int so = 0;
            return int.TryParse(number, out so);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            if(tbIDphieuphat.Text != "")
            {
                if (tbDathu.Text != "" && checkInt(tbDathu.Text))
                {
                    con.Open();
                    string query = "update PHIEUTHUTIENPHAT set SOTIENDATHU = " + tbDathu.Text + " where IDPHIEUTHUTIENPHAT = " + tbIDphieuphat.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    // tổng số tiền còn lại 
                    query = "select SOTIENPHAT, SOTIENDATHU from PHIEUTHUTIENPHAT where IDPHIEUTHUTIENPHAT = " + tbIDphieuphat.Text;
                    cmd = new SqlCommand(query, con);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    int A = int.Parse(table.Rows[0]["SOTIENPHAT"].ToString());
                    int B = int.Parse(table.Rows[0]["SOTIENDATHU"].ToString());
                    int conlai = A - B;

                    // caapj nhaajt soos tieenf conf laij
                    query = "update PHIEUTHUTIENPHAT set SOTIENCONLAI = " + conlai + " where IDPHIEUTHUTIENPHAT = " + tbIDphieuphat.Text;
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                   
                    con.Close();

                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập số tiền để trả và số tiền phải là số");
                }                
            }            
            else
            {
                MessageBox.Show("Bạn cần chọn phiếu phạt để thực hiện trả");
            }

            UC_PhieuThuTienPhat_Load(sender, e);
            nulltextBox();
        }
        public void nulltextBox()
        {
            tbIDdocgia.Text = "";
            tbIDphieuphat.Text = "";
            tbIDphieutra.Text = "";
            tbSotienconlai.Text = "";
            tbSotienphat.Text = "";
            tbTendocgia.Text = "";
            tbTenDocGia1.Text = "";
            tbDathu.Text = "";
            
        }

        private void UC_PhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            con.Open();

            string query = @"select * from phieuthutienphat";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            con.Close();

            dtgvPhieuphat.DataSource = dataTable;
        }
    }
    
}
