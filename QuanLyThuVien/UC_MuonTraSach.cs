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
    public partial class UC_MuonTraSach : UserControl
    {
        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public UC_MuonTraSach()
        {
            InitializeComponent();
            dodulieuvaoDTGV();
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show();        
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show();
            
        }

        public void dodulieuvaoDTGV()
        {
            con.Open();

            string query1 = @"select * from PHIEUMUON";
            string query2 = @"select * from PHIEUTRA";

            SqlCommand sqlCommand = new SqlCommand(query1, con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dtgvPhieuMuon.DataSource = dataTable;

            sqlCommand = new SqlCommand(query2, con);

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable1 = new DataTable();

            sqlDataAdapter.Fill(dataTable1);

            dtgvPhieuTra.DataSource = dataTable1;

            con.Close();            
        }
    }
}
