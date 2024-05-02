using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT3
{
    public static class UI
    {
        public static void MostrarDatosUsuario(string nombre, string apellidos, string edad)
        {
            int edadNun = 0;

            // Convertir 

            edadNun = Convert.ToInt32(edad);

            // Validar el int

            // Mostrar los datos
            MostrarBloqueTexto($"Nombre: ....{nombre}\nApellidos: ....{apellidos}\nEdad: ....{edadNun}", "Usuario");
            
        }
        public static void MostrarBloqueTexto(string text, string nombreCabecera)
        {
            MessageBox.Show(text, nombreCabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarError(string cadena)
        {
            MessageBox.Show($"Error: {cadena}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
