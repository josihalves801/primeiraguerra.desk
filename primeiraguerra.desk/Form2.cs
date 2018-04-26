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
        private int q02tenta;
        private int q3tenta;
        private int q4tenta;
        private int q5tenta;
        public Form2()
        {
            InitializeComponent();
            q01tenta = 0;
            q02tenta = 0;
            q3tenta = 0;
            q4tenta = 0;
            q5tenta = 0;
        }

        private void Fase2_Load(object sender, EventArgs e)
        {

        }

        private void btnveriQ01_Click(object sender, EventArgs e)
        {
            if (q01Opcao1.Checked)
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
            panel2.Visible = true;

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
        

        private void button10_Click(object sender, EventArgs e)
        {
            if (q02r1.Checked)
            {
                q02r1.BackColor = Color.LightCoral;
            }
            else if (q02r2.Checked)
            {
                q02r2.BackColor = Color.LightCoral;
            }
            else if (q02r3.Checked)
            {
                q02r3.BackColor = Color.LightCoral;

            }
            else if (q02r4.Checked)
            {
                q02r4.BackColor = Color.LightGreen;
            }
            else if (q02r5.Checked)
            {
                q02r5.BackColor = Color.LightCoral;
            }
            {
                btntente.Enabled = true;
                button10.Enabled = false;
                q02tenta += 1;
            }
        }

        private void btntente_Click_1(object sender, EventArgs e)
            {
                q02r1.BackColor = Color.Transparent;
                q02r2.BackColor = Color.Transparent;
                q02r3.BackColor = Color.Transparent;
                q02r4.BackColor = Color.Transparent;
                q02r5.BackColor = Color.Transparent;
                if (q02tenta < 2)
                {
                    button10.Enabled = true;
                    btntente.Enabled = false;
                }
            }
            
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (q3r1.Checked)
            {
                q3r1.BackColor = Color.LightCoral;
            }
            else if (q3r2.Checked)
            {
                q3r2.BackColor = Color.LightCoral;
            }
            else if (q3r3.Checked)
            {
                q3r3.BackColor = Color.LightCoral;

            }
            else if (q3r4.Checked)
            {
                q3r4.BackColor = Color.LightCoral;
            }
            else if (q02r5.Checked)
            {
                q3r5.BackColor = Color.LightGreen;
            }
            button3.Enabled = true;
            button4.Enabled = false;
            q3tenta += 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            q3r1.BackColor = Color.Transparent;
            q3r2.BackColor = Color.Transparent;
            q3r3.BackColor = Color.Transparent;
            q3r4.BackColor = Color.Transparent;
            q3r5.BackColor = Color.Transparent;
            if (q3tenta < 2)
            {
                button4.Enabled = true;
                button3.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;

        }





        private void btn_proximo_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (q4r1.Checked)
            {
                q4r1.BackColor = Color.LightGreen;
            }
            else if (q3r2.Checked)
            {
                q4r2.BackColor = Color.LightCoral;
            }
            else if (q4r3.Checked)
            {
                q4r3.BackColor = Color.LightCoral;

            }
            else if (q4r4.Checked)
            {
                q4r4.BackColor = Color.LightCoral;
            }
            else if (q4r5.Checked)
            {
                q4r5.BackColor = Color.LightCoral;
            }
            btnten.Enabled = true;
            button7.Enabled = false;
            q4tenta += 1;
        }

        private void btnten_Click(object sender, EventArgs e)
        {
            q4r1.BackColor = Color.Transparent;
            q4r2.BackColor = Color.Transparent;
            q4r3.BackColor = Color.Transparent;
            q4r4.BackColor = Color.Transparent;
            q4r5.BackColor = Color.Transparent;
            if (q4tenta < 2)
            {
                button7.Enabled = true;
                btnten.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void veri_Click(object sender, EventArgs e)
        {
            if (q5r1.Checked)
            {
                q5r1.BackColor = Color.LightGreen;
            }
            else if (q5r2.Checked)
            {
                q5r2.BackColor = Color.LightCoral;
            }
            else if (q5r3.Checked)
            {
                q5r3.BackColor = Color.LightCoral;

            }
            else if (q5r4.Checked)
            {
                q5r4.BackColor = Color.LightCoral;
            }
            else if (q5r5.Checked)
            {
                q5r5.BackColor = Color.LightCoral;
            }
            btnt.Enabled = true;
            veri.Enabled = false;
            q5tenta += 1;
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            q5r1.BackColor = Color.Transparent;
            q5r2.BackColor = Color.Transparent;
            q5r3.BackColor = Color.Transparent;
            q5r4.BackColor = Color.Transparent;
            q5r5.BackColor = Color.Transparent;
            if (q5tenta < 2)
            {
                veri.Enabled = true;
                btnt.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            p2.Visible = true;
            
        }

        private void p1_Click(object sender, EventArgs e)
        {
           
        }
    }

}
      

