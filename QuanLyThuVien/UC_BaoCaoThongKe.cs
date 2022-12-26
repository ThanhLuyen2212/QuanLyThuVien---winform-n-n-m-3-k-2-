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
    public partial class UC_BaoCaoThongKe : UserControl
    {        
        
        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public UC_BaoCaoThongKe()
        {
            InitializeComponent();
            filldataDocGia();
            filldatamuonsach();
            filldataSach();
            filldataThuThu();
            filldatatrasach();
        }

       

        void filldatamuonsach()
        {
            String query = "SELECT COUNT(*) FROM PHIEUMUON";
            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            lbIssueBook.Text = dataTable.Rows[0][0].ToString();

            con.Close();
        }
        void filldatatrasach()
        {
            String query = "SELECT COUNT(*) FROM PHIEUTRA";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lbReturnBook.Text = dataTable.Rows[0][0].ToString();
            con.Close();
        }
        void filldataDocGia()
        {
            String query = "SELECT COUNT(*) FROM DOCGIA";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lbReader.Text = dataTable.Rows[0][0].ToString();
            con.Close();
        }
        void filldataThuThu()
        {
            String query = "SELECT COUNT(*) FROM NHANVIEN";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lbLibrarian.Text = dataTable.Rows[0][0].ToString();
            con.Close();
        }
        void filldataSach()
        {
            String query = "SELECT COUNT(*) FROM SACH";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lbBook.Text = dataTable.Rows[0][0].ToString();
            con.Close();
        }        
        public void loaddata()
        {
            filldataDocGia();
            filldatamuonsach();
            filldataSach();
            filldataThuThu();
            filldatatrasach();
        }
    }
}
