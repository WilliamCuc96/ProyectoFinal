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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            idProveedor new_proveedor = new idProveedor();
            new_proveedor.codigo = Convert.ToInt16(codigoProveedor.Text);
            new_proveedor.nombre = nombreProveedor.Text;
            new_proveedor.apellido = apellidoProveedor.Text;
            new_proveedor.nit = nitProveedor.Text;
            new_proveedor.mail = emailProveedor.Text;
            new_proveedor.telefono = telefonoProveedor.Text;
            new_proveedor.direccion = direccionProveedor.Text;
            dataContext.idProveedor.InsertOnSubmit(new_proveedor);
            dataContext.SubmitChanges();
        }
    }
}
