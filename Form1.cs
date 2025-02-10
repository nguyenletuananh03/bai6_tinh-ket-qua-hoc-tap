using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6_tinh_ket_qua_hoc_tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            double hk1 = Convert.ToDouble(txthk1.Text);
            double hk2 = Convert.ToDouble(txthk2.Text);
            double dtb = (hk1 + hk2) / 2;

            txtdiemtb.Text = dtb.ToString();
            if (dtb < 5)
            {
                txtkq.Text = "ở lại lớp";
            }else
            {
                txtkq.Text = "được lên lớp";
            }


            //xếp loại
            if (dtb < 5)
            {
                txtxl.Text = "yếu";
            }
            else if (dtb <= 6) {
                txtxl.Text = "tb";
            }
            else if (dtb < 8)
            {
                txtxl.Text = "khá";
            }
            else
            {
                txtxl.Text = "giỏi";
            }
        }
    }
}
