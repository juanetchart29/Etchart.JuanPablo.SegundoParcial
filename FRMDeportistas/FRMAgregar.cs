using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario base para agregar deportistas.
    /// </summary>
    public partial class FRMAgregar : Form
    {
        /// <summary>
        /// Constructor de la clase FRMAgregar.
        /// </summary>
        public FRMAgregar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de eventos del botón "Siguiente".
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        public virtual void btnSiguiente_Click(object sender, EventArgs e)
        {
            ChequearTodosLosCampos();
        }

        /// <summary>
        /// Verifica si todos los campos requeridos están completos.
        /// </summary>
        private void ChequearTodosLosCampos()
        {
            string respuesta = "";

            foreach (Control control in this.Controls)
            {
                // Si es un TextBox o un GroupBox y está vacío, establece respuesta en "No se han completado todos los campos".
                if ((control is TextBox || control is GroupBox) && control.Text == string.Empty)
                {
                    respuesta = "No se han completado todos los campos";
                }
            }

            this.lblError.Text = respuesta;
        }
    }
}
