using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiraguerra.desk
{
    public partial class Form3 : Form
    {
        private int tentativa01;
        private int tentativa02;
        private int tentativa03;
        private int tentativa04;
        private int tentativa05;

        public Form3()
        {
            InitializeComponent();
            tentativa01 = 0;
            tentativa02 = 0;
            tentativa03 = 0;
            tentativa04 = 0;
            tentativa05 = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnovatenta1_Click_1(object sender, EventArgs e)
        {
            q1r1.BackColor = Color.Transparent;
            q1r2.BackColor = Color.Transparent;
            q1r3.BackColor = Color.Transparent;
            q1r4.BackColor = Color.Transparent;
            if (tentativa01 < 2)
            {
                vefiq1.Enabled = true;
                btnnovatenta1.Enabled = false;
            }
        }

        private void vefiq1_Click(object sender, EventArgs e)
        {
            if (q1r1.Checked)
            {
                q1r1.BackColor = Color.LightCoral;
            }
            else if (q1r2.Checked)
            {
                q1r2.BackColor = Color.LightCoral;
            }
            else if (q1r3.Checked)
            {
                q1r3.BackColor = Color.LightCoral;

            }
            else if (q1r4.Checked)
            {
                q1r4.BackColor = Color.LightGreen;
            }
            btnnovatenta1.Enabled = true;
            vefiq1.Enabled = false;
            tentativa01 += 1;
        }
    }
}
