using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace form
{

    public partial class FormThongKe : Form
    {
        bool sliderbarExpand;
        //bool homeCollapse;
        //bool drinkCollapse;
        public FormThongKe()
        {
            InitializeComponent();
            HienThi();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        //SqlCommandBuilder sqlCommand = null;
        void HienThi()
        {
            conn.Open();
            string sql = "select maNV,hoTenNV,gioCong,tienThang,tongluong from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            /*ds = new DataSet();*/
            sda.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            
        }
        void Sua1()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien set maNV =@maNV, hoTenNV =@hoTenNV, gioCong = @gioCong, tienThang = @tienThang, tongluong = @tongluong where maNV = @manv", conn);
            cmd.Parameters.AddWithValue("@maNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("@hoTenNV", txthovaten.Text);
            cmd.Parameters.AddWithValue("@gioCong", txtGioCong.Text);
            cmd.Parameters.AddWithValue("@tienThang", txtTienThang.Text);
            cmd.Parameters.AddWithValue("@tongluong", txtTongLuong.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            
        }
        void Sua2()
        {
            SqlCommand cmd = new SqlCommand("SELECT maNV,hoTenNV,gioCong,tienThang,tongluong FROM NhanVien", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void LayDL()
        {
            string sql = "SELECT maNV,hoTenNV,gioCong,tienThang,tongluong FROM NhanVien";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                sliderbar.Width -= 10;
                if (sliderbar.Width == sliderbar.MinimumSize.Width)
                {
                    sliderbarExpand = false;
                    slidebarTimer.Stop();
                }
            }
            else
            {
                sliderbar.Width += 10;
                if (sliderbar.Width == sliderbar.MaximumSize.Width)
                {
                    sliderbarExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MainWindow f1 = new MainWindow();
            f1.Show();
            this.Hide();
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormAdmin f1 = new FormAdmin();
            f1.ShowDialog();
            this.Hide();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_Enter(object sender, EventArgs e)
        {
           
        }

        private void txthovaten_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txthovaten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGioCong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTienThang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTongLuong.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtmanv.Enabled = false;
                txthovaten.Enabled = false;
            }
            LayDL();

            
            
        }

        
            private void btnHangHoa_Click(object sender, EventArgs e)
            {
                FromTKHangHoa fhh = new FromTKHangHoa();
                fhh.ShowDialog();
                this.Hide();
            }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            Sua1();
            LayDL();
            Sua2();
        }

        
    }
}
