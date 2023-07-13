using System;
using System.Windows.Forms;

namespace form
{
    public partial class FormDanhMuc : Form
    {
        bool sliderbarExpand;
        //bool homeCollapse;
        //bool drinkCollapse;
        public FormDanhMuc()
        {
            InitializeComponent();
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
    }
}
