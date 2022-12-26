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
    public partial class UC_ThongTiCaNhan : UserControl
    {

        private SqlConnection con = new SqlConnection(dataConnection.dataconnection);
        public static string idnhanvien;
        public UC_ThongTiCaNhan()
        {
            InitializeComponent();
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (tbMatkhaucu.Text == "" || tbMatkhaumoi.Text == "" || tbNhaplai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                if (tbMatkhaumoi.Text != tbNhaplai.Text)
                {
                    MessageBox.Show("Hai mật khẩu khác nhau");
                }
                else
                {
                    con.Open();
                    string query = "select MATKHAU FROM NHANVIEN WHERE IDNHANVIEN =" + idnhanvien;
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    if (table.Rows[0]["MATKHAU"].ToString() == tbMatkhaucu.Text)
                    {
                        query = "update NHANVIEN SET MATKHAU ='" + tbMatkhaumoi.Text + "' WHERE IDNHANVIEN =" + idnhanvien;
                        cmd = new SqlCommand(query,con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã thay đồi mật khẩu");
                        
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu cũ");
                    }
                    con.Close();
                    UC_ThongTiCaNhan_Load(sender, e);
                }
            }     
        }

        private void UC_ThongTiCaNhan_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from nhanvien WHERE IDNHANVIEN ="+idnhanvien;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            lbIDnhanvien.Text = table.Rows[0]["IDNHANVIEN"].ToString();
            lbTennhanvien.Text = table.Rows[0]["TENNHANVIEN"].ToString();
            lbTentaikhoan.Text = table.Rows[0]["TENTAIKHOAN"].ToString();
            lbSodienthoai.Text = table.Rows[0]["SODIENTHOAI"].ToString();
            lbChucNang.Text = table.Rows[0]["CHUCNANG"].ToString();           
            con.Close();
        }
    }
}
