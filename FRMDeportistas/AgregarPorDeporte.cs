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
    /// Formulario para agregar deportistas por tipo de deporte.
    /// </summary>
    public partial class AgregarPorDeporte : Form
    {
        #region Atributos

        public Form formActivo;
        public AccesoDatos clasificacion;

        #endregion

        /// <summary>
        /// Constructor  sin parametros de la clase AgregarPorDeporte.
        /// </summary>
        public AgregarPorDeporte()
        {
            formActivo = null;
        }

        /// <summary>
        /// Constructor de la clase AgregarPorDeporte.
        /// </summary>
        /// <param name="clasificacion">La instancia de Clasificacion utilizada para gestionar deportistas.</param>
        public AgregarPorDeporte(AccesoDatos clasificacion)
        {
            InitializeComponent();
            this.clasificacion = clasificacion;
        }

        private void btnAgregarAtletismo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRMAgregarAtletismo(clasificacion));
        }

        private void btnAgregarVoley_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRMAgregarVoley(clasificacion));

        }

        private void btnAgregarEscalada_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRMAgregarEscalada(clasificacion));

        }

        /// <summary>
        /// Abre un formulario hijo y lo coloca en el panelCentral.
        /// </summary>
        /// <param name="formularioHijo">El formulario hijo que se abrirá.</param>
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // Me fijo si hay un formulario hijo activo y si lo hay lo cierro
            if (formActivo != null)
                formActivo.Close();

            // Seteo como nuevo formulario activo el hijo
            formActivo = formularioHijo;

            // Seteo al hijo para que no tenga la parte superior ni bordes
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agrego el formulario hijo a mi panelCentral
            this.panelCentral.Controls.Add(formularioHijo);
            this.panelCentral.Tag = formularioHijo;

            // Coloco en la parte superior el formulario hijo y lo muestro
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }


}
