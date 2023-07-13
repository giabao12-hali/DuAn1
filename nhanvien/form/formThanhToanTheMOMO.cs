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
    public partial class formthanhtoan : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;
        public formthanhtoan()
        {
            InitializeComponent();
        }

        private void formthanhtoan_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT tenSP as 'Tên Sản Phẩm', giaThanh as 'Giá Thành' FROM ThucDon", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "ThucDon");
            dgvThanhToan.DataSource = ds.Tables["ThucDon"].DefaultView;
            this.dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //this.dgvThanhToan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.dgvThanhToan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ThucDon", conn);
            ////SqlDataAdapter sda = new SqlDataAdapter("SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon", conn);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "HoaDon");
            //dgvThanhToan.DataSource = ds.Tables["HoaDon"].DefaultView;



            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ThucDon", conn);

            ////SqlCommand cmd = new SqlCommand("SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon", conn);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM ThucDon", conn);
            //sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //int tien = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    tien = tien + Convert.ToInt32(dt.Rows[i]["soluong"].ToString()) * Convert.ToInt32(dt.Rows[i]["giathanh"].ToString());
            //}
            //lblTongTien.Text = "Tổng tiền thanh toán là: " + tien;
        }

        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvThanhToan.DataSource = dt;
        }

        void LayDL()
        {
            string sql = "SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        private void btnBoQua_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnTienMat_MouseClick(object sender, MouseEventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon", conn);
            //sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //int tien = 0;
            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    tien = tien + Convert.ToInt32(dt.Rows[i]["soluong"].GetType()) * Convert.ToInt32(dt.Rows[i]["giathanh"].GetType());
            //}
            //lblTongTien.Text = "Tổng tiền thanh toán là: " + tien;
            MessageBox.Show("Đã thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dgvThanhToan.Rows .Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMassage = false;
                if(save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMassage = true;
                            MessageBox.Show("Đã có file" + ex.Message);
                        }
                    }
                    if (!ErrorMassage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvThanhToan.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in dgvThanhToan.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach(DataGridViewRow viewRow in dgvThanhToan.Rows)
                            {
                                foreach(DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4,8f,16f,16f,8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Xuất thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xuất");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dgvThanhToan.SelectAll();
            DataObject copydata = dgvThanhToan.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
