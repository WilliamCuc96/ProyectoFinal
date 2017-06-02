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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem cliente = new ListViewItem();
            //var queryClientes = from cliente select cliente;
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter2.Fill(this.proyectoDataSet1.cliente);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.proyectoDataSet.cliente);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet2.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.proyectoDataSet2.cliente);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Elimina datos de la base de datos
            //Se crea una variable para guardar la consulta "c2"
            DataClasses1DataContext context = new DataClasses1DataContext();
            var c2 = (from cliente in context.cliente where (cliente.id == Convert.ToInt32(idTextBox.Text)) select cliente).First();
            if(c2!=null) {
                //Elimina los datos seleccionados
                context.cliente.DeleteOnSubmit(c2);

                context.SubmitChanges();
                bindingNavigator1.Update();
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
