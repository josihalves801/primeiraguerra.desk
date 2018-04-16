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
    public partial class Form2 : Form
    {
        private int q01tenta;

        public Form2()
        {
            InitializeComponent();
            q01tenta = 0;
        }

        private void Fase2_Load(object sender, EventArgs e)
        {

        }

        private void btnveriQ01_Click(object sender, EventArgs e)
        {
            if(q01Opcao1.Checked)
            {
                q01Opcao1.BackColor = Color.LightCoral;
            }
            else if (Q01Opcao2.Checked)
            {
                Q01Opcao2.BackColor = Color.LightGreen;
            }
            else if (Q01Opcao3.Checked)
            {
                Q01Opcao3.BackColor = Color.LightCoral;

            }
            else if (Q01Opcao4.Checked)
            {
                Q01Opcao4.BackColor = Color.LightCoral;
            }
            btntentaragain.Enabled = true;
            btnveriQ01.Enabled = false;
            q01tenta += 1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntentaragain_Click(object sender, EventArgs e)
        {
            q01Opcao1.BackColor = Color.Transparent;
            Q01Opcao2.BackColor = Color.Transparent;
            Q01Opcao3.BackColor = Color.Transparent;
            Q01Opcao4.BackColor = Color.Transparent;
            if (q01tenta < 2) 
            {
                btnveriQ01.Enabled = true;
                btntentaragain.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void q01Opcao1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
