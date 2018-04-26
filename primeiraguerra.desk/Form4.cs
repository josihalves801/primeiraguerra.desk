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
    public partial class Form4 : Form
    {
        private int q1tente;
        private int q2tente;
        private int q3tente;
        private int q4tente;
        private int q5tente;
        public Form4()
        {
            InitializeComponent();
            q1tente = 0;
            q2tente = 0;
            q3tente = 0;
            q4tente = 0;
            q5tente = 0;
        }

        private void ver_Click(object sender, EventArgs e)
        {
            if (q1r1p3.Checked)
            {
                q1r1p3.BackColor = Color.LightCoral;
            }
            else if (q1r2p3.Checked)
            {
                q1r2p3.BackColor = Color.LightGreen;
            }
            else if (q1r3p3.Checked)
            {
                q1r3p3.BackColor = Color.LightCoral;
            }
            else if (q1r4p3.Checked)
            {
                q1r4p3.BackColor = Color.LightCoral;
            }
            else if (q1r5p3.Checked)
            {
                q1r5p3.BackColor = Color.LightCoral;
            }
            btntry.Enabled = true;
            ver.Enabled = false;
            q1tente+= 1;

        }

        private void btntry_Click(object sender, EventArgs e)
        {
            q1r1p3.BackColor = Color.Transparent;
            q1r2p3.BackColor = Color.Transparent;
            q1r3p3.BackColor = Color.Transparent;
            q1r4p3.BackColor = Color.Transparent;
            q1r5p3.BackColor = Color.Transparent;
            if (q1tente<2)
                
            {
                ver.Enabled = true;
                btntry.Enabled = false;
            }
        }

        private void proxi_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel11.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(q2r1p3.Checked)
            {
                q2r1p3.BackColor = Color.LightCoral;
            }
            else if (q2r2p3.Checked)
            {
                q2r2p3.BackColor = Color.LightCoral;
            }
            else if (q2r3p3.Checked)
            {
                q2r3p3.BackColor = Color.LightCoral;
            }
            else if (q2r4p3.Checked)
            {
                q2r4p3.BackColor = Color.LightCoral;
            }
            else if (q2r5p3.Checked)
            {
                q2r5p3.BackColor = Color.LightGreen;
            }
            btnt.Enabled = true;
            button3.Enabled = false;
            q2tente += 1;
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            q2r1p3.BackColor = Color.Transparent;
            q2r2p3.BackColor = Color.Transparent;
            q2r3p3.BackColor = Color.Transparent;
            q2r4p3.BackColor = Color.Transparent;
            q2r5p3.BackColor = Color.Transparent;
            if (q2tente < 2)

            {
                button3.Enabled = true;
                btnt.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel12.Visible = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if(q3r1p3.Checked)
            {
                q3r1p3.BackColor = Color.LightCoral;
            }
            else if (q3r2p3.Checked)
            {
                q3r2p3.BackColor = Color.LightGreen;
            }
            else if (q3r3p3.Checked)
            {
                q3r3p3.BackColor = Color.LightCoral;
            }
            else if (q3r4p3.Checked)
            {
                q3r4p3.BackColor = Color.LightCoral;
            }
            else if (q3r5p3.Checked)
            {
                q3r5p3.BackColor = Color.LightGreen;
            }
            btnagain.Enabled = true;
            btnver.Enabled = false;
            q3tente += 1;
        }

        private void btnagain_Click(object sender, EventArgs e)
        {
            q3r1p3.BackColor = Color.Transparent;
            q3r2p3.BackColor = Color.Transparent;
            q3r3p3.BackColor = Color.Transparent;
            q3r4p3.BackColor = Color.Transparent;
            q3r5p3.BackColor = Color.Transparent;
            if (q2tente < 2)

            {
                btnver.Enabled = true;
                btnagain.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
            panel13.Visible = true;
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (q4r1p3.Checked)
            {
                q4r1p3.BackColor = Color.LightCoral;
            }
            else if (q4r2p3.Checked)
            {
                q4r2p3.BackColor = Color.LightGreen;
            }
            else if (q4r3p3.Checked)
            {
                q4r3p3.BackColor = Color.LightCoral;
            }
            else if (q4r4p3.Checked)
            {
                q4r4p3.BackColor = Color.LightGreen;
            }
            else if (q4r5p3.Checked)
            {
                q4r5p3.BackColor = Color.LightCoral;
            }
            tentar.Enabled = true;
            verificar.Enabled = false;
            q4tente += 1;
        }

        private void tentar_Click(object sender, EventArgs e)
        {
            q4r1p3.BackColor = Color.Transparent;
            q4r2p3.BackColor = Color.Transparent;
            q4r3p3.BackColor = Color.Transparent;
            q4r4p3.BackColor = Color.Transparent;
            q4r5p3.BackColor = Color.Transparent;
            if (q4tente < 2)

            {
                verificar.Enabled = true;
                tentar.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
            panel14.Visible = true;
        }

        private void verif_Click(object sender, EventArgs e)
        {

            if (q5r1p3.Checked)
            {
                q5r1p3.BackColor = Color.LightGreen;
            }
            else if (q5r2p3.Checked)
            {
                q5r2p3.BackColor = Color.LightCoral;
            }
            else if (q5r3p3.Checked)
            {
                q5r3p3.BackColor = Color.LightCoral;
            }
            else if (q5r4p3.Checked)
            {
                q5r4p3.BackColor = Color.LightGreen;
            }
            else if (q5r5p3.Checked)
            {
                q5r5p3.BackColor = Color.LightCoral;
            }
            tent.Enabled = true;
            verif.Enabled = false;
            q5tente += 1;
        }

        private void tent_Click(object sender, EventArgs e)
        {
            q5r1p3.BackColor = Color.Transparent;
            q5r2p3.BackColor = Color.Transparent;
            q5r3p3.BackColor = Color.Transparent;
            q5r4p3.BackColor = Color.Transparent;
            q5r5p3.BackColor = Color.Transparent;
            if (q5tente < 2)

            {
                verif.Enabled = true;
                tent.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
            p3.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
