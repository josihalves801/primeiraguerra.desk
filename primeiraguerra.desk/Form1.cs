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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fase1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tela_fase1 = new Form2();
            this.Visible = false;
            tela_fase1.ShowDialog();
            this.Visible = true;
        }

        private void fase2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tela_fase2 = new Form3();
            this.Visible = false;
            tela_fase2.ShowDialog();
            this.Visible = true;
        }

        private void fase3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tela_fase3 = new Form4();
            this.Visible = false;
            tela_fase3.ShowDialog();
            this.Visible = true;
        }
    }
}
