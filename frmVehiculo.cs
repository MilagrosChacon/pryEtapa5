using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa5
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            // Crear un objeto clsVehiculo aleatorio
            clsVehiculo vehiculo = clsVehiculo.crearVehiculoAleatorio();

            // Establecer la imagen del vehículo en el pictureBox
            pctVehiculo.Image = vehiculo.Imagen;

            // Mostrar el nombre y tipo del vehículo en los labels
            lblNombreVehiculo.Text = vehiculo.Nombre;
            lblTipoVehiculo.Text = vehiculo.Tipo;
        }
    }
}
