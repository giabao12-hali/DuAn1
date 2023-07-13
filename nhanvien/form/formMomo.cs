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
    public partial class formMomo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        public formMomo()
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
    }
}
