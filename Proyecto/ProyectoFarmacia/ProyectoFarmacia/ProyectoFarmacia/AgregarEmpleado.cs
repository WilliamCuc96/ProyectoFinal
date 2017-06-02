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
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            idEmpleado new_empleado = new idEmpleado();
            new_empleado.nombre = nombreEmpleado.Text;
            new_empleado.apellido = apellidoEmpleado.Text;
            new_empleado.dpi = dpiEmpleado.Text;
            new_empleado.mail = emailEmpleado.Text;
            dataContext.idEmpleado.InsertOnSubmit(new_empleado);
            dataContext.SubmitChanges();
        }
    }
}
