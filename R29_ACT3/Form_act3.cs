using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT3
{
    public partial class Form_act3 : Form
    {
        public Form_act3()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            bool esValido = true;
            Button boton = (Button)sender;

            try { 
            switch (boton.Text)
            {
                case "ACEPTAR":
                    UI.MostrarDatosUsuario(TextEntradaNombre.Text, TextEntradaApellidos.Text, TextEntradaEdad.Text);
                    break;
            }
            }
            catch (Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(mensajeError);
            }
        }

        private void Validacion_TextBox(object sender, EventArgs e)
        {
             TextBox textBox = (TextBox)sender;

            try { 
            switch (textBox.Name)
            {
                case "TextEntradaNombre":
                    Validacion.ValidarCadena(textBox.Text, 30);
                    break;
                case "TextEntradaApellidos":
                    Validacion.ValidarCadena(textBox.Text, 50);
                    break;
                case "TextEntradaEdad":
                    Validacion.ValidarCadena(textBox.Text, 3);
                    Validacion.ValidarEdad(textBox.Text);
                    break;
            }
            }
            catch(Exception error)
            {
                UI.MostrarError(error.Message);
                textBox.Text = "";
                textBox.Focus();
            }
        }
    }
}
