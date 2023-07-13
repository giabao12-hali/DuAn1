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

namespace form
{
    public partial class formcondemo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        public formcondemo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon values (/*@IDBan,*/ @maMon, @tenMon, @soBan, @soLuong, @giaThanh, @maHoaDon, /*@tinhTrangHD, @thanhTien*/)", conn);
            cmd.Parameters.AddWithValue("@maMon",1);
            cmd.Parameters.AddWithValue("@tenMon", 2);
            cmd.Parameters.AddWithValue("@soLuong", 3);
            cmd.Parameters.AddWithValue("@giaThanh", 4);
            cmd.Parameters.AddWithValue("@maHoaDon", 5);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void formcondemo_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
