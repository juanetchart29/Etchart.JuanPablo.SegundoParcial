using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario que muestra los registros de usuarios.
    /// </summary>
    public partial class FRMIngresos : Form
    {
        /// <summary>
        /// Constructor de la clase FRMIngresos.
        /// </summary>
        public FRMIngresos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de eventos que se ejecuta cuando el formulario se carga.
        /// Carga y muestra los registros de usuarios en una lista.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FRMIngresos_Load(object sender, EventArgs e)
        {
            List<string> miRegistro = ArchivoUsuarios.TraerRegistro();
            foreach (string registro in miRegistro)
            {
                this.listBox1.Items.Add(registro);
            }
        }
    }
}
