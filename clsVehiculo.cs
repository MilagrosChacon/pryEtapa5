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
    internal class clsVehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        public static clsVehiculo crearVehiculoAleatorio()
        {
            // Crear un array con los nombres y los tipos de los vehículos
            string[] nombres = { "Auto", "Avion", "Barco" };
            string[] tipos = { "Terrestre", "Aéreo", "Marítimo" };

            // Obtener un índice aleatorio
            int indiceAleatorio = new Random().Next(nombres.Length);

            // Crear un nuevo objeto clsVehiculo con el nombre aleatorio
            clsVehiculo vehiculo = new clsVehiculo()
            {
                Nombre = nombres[indiceAleatorio],
                Tipo = tipos[indiceAleatorio]
            };

            // Establecer la imagen del vehículo según el nombre
            switch (vehiculo.Nombre)
            {
                case "Auto":
                    vehiculo.Imagen = Properties.Resources.auto;
                    break;
                case "Avion":
                    vehiculo.Imagen = Properties.Resources.avion;
                    break;
                case "Barco":
                    vehiculo.Imagen = Properties.Resources.barco;
                    break;
            }

            return vehiculo;
        }
    }
}
