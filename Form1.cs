using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new Form2();
            registro.MdiParent = this;
            registro.Show();
        }

        private void obraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new Form3();
            registro.MdiParent = this;
            registro.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new Form4();
            registro.MdiParent = this;
            registro.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new Form5();
            registro.MdiParent = this;
            registro.Show();
        }

        private void listadoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new Form6();
            registro.MdiParent = this;
            registro.Show();
        }
    }
}
