using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyactoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVenta frm = new AgregarVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCliente frm = new AgregarCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frm = new AgregarEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPuesto frm = new AgregarPuesto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMedicamento frm = new AgregarMedicamento();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
