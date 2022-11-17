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
    public partial class Form6 : Form
    {
        string connectionString = @"Server =.\SQLExpress;Database=CKE;Trusted_Connection=Yes;";
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cKEDataSet3.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.cKEDataSet3.Ciudad);
            // TODO: esta línea de código carga datos en la tabla 'cKEDataSet2.Obra' Puede moverla o quitarla según sea necesario.
            this.obraTableAdapter.Fill(this.cKEDataSet2.Obra);
            // TODO: esta línea de código carga datos en la tabla 'cKEDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.cKEDataSet1.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'cKEDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.cKEDataSet.Empleado);

        }
    }
}
