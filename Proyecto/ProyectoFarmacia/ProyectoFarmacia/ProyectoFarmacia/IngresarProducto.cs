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
    public partial class IngresarProducto : Form
    {
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            producto new_producto = new producto();
            new_producto.codigo = codigoProducto.Text;
            new_producto.nombre = nombreProducto.Text;
            new_producto.descripcion = descripcionProducto.Text;
            new_producto.tipo = tipoProducto.Text;
            new_producto.precio = Convert.ToDecimal(precioProducto.Text);
            new_producto.cantidad = Convert.ToInt16(cantidadProducto.Text);
            dataContext.producto.InsertOnSubmit(new_producto);
            dataContext.SubmitChanges();
        }
    }
}
