using Etchart.JuanPablo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario para seleccionar un archivo JSON de deportistas.
    /// </summary>
    public partial class FRMSeleccionarJson : Form
    {
        /// <summary>
        /// Ruta del archivo JSON seleccionado.
        /// </summary>
        public string path;

        /// <summary>
        /// Constructor de la clase FRMSeleccionarJson.
        /// Inicializa la ruta del archivo con un valor predeterminado y muestra el formulario.
        /// </summary>
        public FRMSeleccionarJson()
        {
            path = "Deportistas.json";
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Abrir".
        /// Abre un cuadro de diálogo para seleccionar un archivo JSON de deportistas.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxArchivo.Text = openFileDialog1.FileName;
                if (this.path != openFileDialog1.FileName)
                {
                    MessageBox.Show("Se ha cambiado el archivo con éxito");
                    if (openFileDialog1.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        this.path = openFileDialog1.FileName;
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un archivo .json, no se harán los cambios");
                    }
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado es el mismo que se está usando para traer los datos");
                }
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Utilizar".
        /// Establece el resultado del formulario como OK y cierra el formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnUtilizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Obtiene la ruta del archivo seleccionado.
        /// </summary>
        /// <returns>La ruta del archivo seleccionado.</returns>
        public string ObtenerPath()
        {
            return this.path;
        }
    }
}
