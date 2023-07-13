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
    public partial class FromTKHangHoa : Form
    {
        bool sliderbarExpand;
        public FromTKHangHoa()
        {
            InitializeComponent();
            HienThi();
        }

        

        private void FromTKHangHoa_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;

        void HienThi()
        {
            conn.Open();
            string sql = "select tenSP, tinhTrangMon from ThucDon where tinhTrangMon = 'Còn Món'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            /*ds = new DataSet();*/
            sda.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThi();
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
            //slidebarTimer.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuButton_Click_1(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormThongKe ftk = new FormThongKe();
            ftk.ShowDialog();
            this.Hide();
        }
    }
}
