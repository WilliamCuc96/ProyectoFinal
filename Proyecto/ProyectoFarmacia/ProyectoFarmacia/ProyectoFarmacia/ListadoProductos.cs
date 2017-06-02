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
    public partial class ListadoProductos : Form
    {
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.proyectoDataSet.producto);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource.EndEdit();
            proyectoDataSet.AcceptChanges();
            bindingNavigator1.Update();

        }
    }
}
