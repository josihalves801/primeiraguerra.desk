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


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnovatenta1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void vefiq1_Click(object sender, EventArgs e)
        {
            
        }

        private void verifi_Click(object sender, EventArgs e)
        {

            if (q1r1p2.Checked)
            {
                q1r1p2.BackColor = Color.LightGreen;
            }
            else if (q1r2p2.Checked)
            {
                q1r2p2.BackColor = Color.LightCoral;
            }
            else if (q1r3p2.Checked)
            {
                q1r3p2.BackColor = Color.LightCoral;
            }
            else if (q1r4p2.Checked)
            {
                q1r4p2.BackColor = Color.LightCoral;
            }
            else if (q1r5p2.Checked)
            {
                q1r5p2.BackColor = Color.LightGreen;
            }
            tentr.Enabled = true;
            verifi.Enabled = false;
            tentativa01 += 1;
        }

        private void tentr_Click(object sender, EventArgs e)
        {
            q1r1p2.BackColor = Color.Transparent;
            q1r2p2.BackColor = Color.Transparent;
            q1r3p2.BackColor = Color.Transparent;
            q1r4p2.BackColor = Color.Transparent;
            q1r5p2.BackColor = Color.Transparent;
            if (tentativa01 < 2)

            {
                verifi.Enabled = true;
                tentr.Enabled = false;
            }
        }

        private void prox1_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (q2r1p2.Checked)
            {
                q2r1p2.BackColor = Color.LightCoral;
            }
            else if (q2r2p2.Checked)
            {
                q2r2p2.BackColor = Color.LightCoral;
            }
            else if (q2r3p2.Checked)
            {
                q2r3p2.BackColor = Color.LightCoral;
            }
            else if (q2r4p2.Checked)
            {
                q2r4p2.BackColor = Color.LightGreen;
            }
            else if (q2r5p2.Checked)
            {
                q2r5p2.BackColor = Color.LightCoral;
            }
            mais.Enabled = true;
            btn.Enabled = false;
            tentativa02 += 1;
        }

        private void mais_Click(object sender, EventArgs e)
        {
            q2r1p2.BackColor = Color.Transparent;
            q2r2p2.BackColor = Color.Transparent;
            q2r3p2.BackColor = Color.Transparent;
            q2r4p2.BackColor = Color.Transparent;
            q2r5p2.BackColor = Color.Transparent;
            if (tentativa02 < 2)

            {
                btn.Enabled = true;
                mais.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
        }

        private void v3_Click(object sender, EventArgs e)
        {
            if (q3r1p2.Checked)
            {
                q3r1p2.BackColor = Color.LightCoral;
            }
            else if (q3r2p2.Checked)
            {
                q3r2p2.BackColor = Color.LightGreen;
            }
            else if (q3r3p2.Checked)
            {
                q3r3p2.BackColor = Color.LightCoral;
            }
            else if (q3r4p2.Checked)
            {
                q3r4p2.BackColor = Color.LightCoral;
            }
            else if (q3r5p2.Checked)
            {
                q3r5p2.BackColor = Color.LightCoral;
            }
            t3.Enabled = true;
            v3.Enabled = false;
            tentativa03 += 1;
        }

        private void t3_Click(object sender, EventArgs e)
        {
            q3r1p2.BackColor = Color.Transparent;
            q3r2p2.BackColor = Color.Transparent;
            q3r3p2.BackColor = Color.Transparent;
            q3r4p2.BackColor = Color.Transparent;
            q3r5p2.BackColor = Color.Transparent;
            if (tentativa03 < 2)

            {
                v3.Enabled = true;
                t3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
        }

        private void v4_Click(object sender, EventArgs e)
        {
            if (q4r1p2.Checked)
            {
                q4r1p2.BackColor = Color.LightCoral;
            }
            else if (q4r2p2.Checked)
            {
                q4r2p2.BackColor = Color.LightCoral;
            }
            else if (q4r3p2.Checked)
            {
                q4r3p2.BackColor = Color.LightCoral;
            }
            else if (q4r4p2.Checked)
            {
                q4r4p2.BackColor = Color.LightGreen;
            }
            else if (q4r5p2.Checked)
            {
                q4r5p2.BackColor = Color.LightCoral;
            }
            t4.Enabled = true;
            v4.Enabled = false;
            tentativa04 += 1;
        }

        private void t4_Click(object sender, EventArgs e)
        {
            q4r1p2.BackColor = Color.Transparent;
            q4r2p2.BackColor = Color.Transparent;
            q4r3p2.BackColor = Color.Transparent;
            q4r4p2.BackColor = Color.Transparent;
            q4r5p2.BackColor = Color.Transparent;
            if (tentativa04 < 2)

            {
                v4.Enabled = true;
                t4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
               
        }

        private void v5_Click(object sender, EventArgs e)
        {
            if (q5r1p2.Checked)
            {
                q5r1p2.BackColor = Color.LightCoral;
            }
            else if (q5r2p2.Checked)
            {
                q5r2p2.BackColor = Color.LightCoral;
            }
            else if (q5r3p2.Checked)
            {
                q5r3p2.BackColor = Color.LightCoral;
            }
            else if (q5r4p2.Checked)
            {
                q5r4p2.BackColor = Color.LightGreen;
            }
            else if (q5r5p2.Checked)
            {
                q5r5p2.BackColor = Color.LightCoral;
            }
            t5.Enabled = true;
            v5.Enabled = false;
            tentativa05 += 1;
        }

        private void t5_Click(object sender, EventArgs e)
        {
            q5r1p2.BackColor = Color.Transparent;
            q5r2p2.BackColor = Color.Transparent;
            q5r3p2.BackColor = Color.Transparent;
            q5r4p2.BackColor = Color.Transparent;
            q5r5p2.BackColor = Color.Transparent;
            if (tentativa05 < 2)

            {
                v5.Enabled = true;
                t5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void q5r5p2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
