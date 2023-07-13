using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class formThanhToanThe : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        public formThanhToanThe()
        {
            InitializeComponent();
        }

        private void formthanhtoan_Load(object sender, EventArgs e)
        {
            conn.Open();
        }    
        private void btnBoQua_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnMomo_Click(object sender, EventArgs e)
        {
            formMomo f1 = new formMomo();
            f1.ShowDialog();
        }
    }
}
