using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFarmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarClientes frmCliente = new IngresarClientes();
            frmCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresarProducto frmProducto = new IngresarProducto();
            frmProducto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarProveedor frmProveedor = new AgregarProveedor();
            frmProveedor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frmProveedor = new AgregarEmpleado();
            frmProveedor.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarClientes frmCliente = new IngresarClientes();
            frmCliente.Show();
        }

        private void agregarMercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto frmProducto = new IngresarProducto();
            frmProducto.Show();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProveedor frmProveedor = new AgregarProveedor();
            frmProveedor.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frmProveedor = new AgregarEmpleado();
            frmProveedor.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoClientes().Show();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoProductos().Show();
        }

        
        
    }
}
