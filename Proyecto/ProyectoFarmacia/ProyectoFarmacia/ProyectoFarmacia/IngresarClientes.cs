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
    public partial class IngresarClientes : Form
    {
        public IngresarClientes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Conexion a la tabla y agregar datos
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            cliente new_cliente = new cliente();
            new_cliente.direccion = txtdireccion.Text;
            new_cliente.nit = txtnit.Text;
            new_cliente.nombre = txtnombre.Text;
            new_cliente.telefono = txttelefono.Text;
            dataContext.cliente.InsertOnSubmit(new_cliente);
            dataContext.SubmitChanges();
        }

        private void IngresarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter2.Fill(this.proyectoDataSet.cliente);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataGridView1.Refresh();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
