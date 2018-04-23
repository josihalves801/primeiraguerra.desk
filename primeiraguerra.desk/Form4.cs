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
        public Form4()
        {
            InitializeComponent();
            q1tente = 0;
            q2tente = 0;
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
    }
}
