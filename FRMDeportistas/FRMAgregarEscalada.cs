using Entidades;
using Etchart.JuanPablo;
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
    /// Formulario para agregar o modificar un deportista de la disciplina de escalada.
    /// </summary>
    public partial class FRMAgregarEscalada : FRMAgragarDeportista
    {
        public string grado;
        public string modalidad;
        public string categoria;

        private Escalada objetoModificar = null;

        /// <summary>
        /// Constructor de la clase FRMAgregarEscalada.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        public FRMAgregarEscalada(AccesoDatos clasificacion) : base(clasificacion)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la clase FRMAgregarEscalada utilizado para modificar un deportista de escalada.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        /// <param name="escalada">Deportista de escalada a modificar.</param>
        public FRMAgregarEscalada(Clasificacion clasificacion, Escalada escalada) : this(clasificacion)
        {
            objetoModificar = escalada;
            base.setearBasics(escalada);
            this.grado = escalada.Grado;
            this.modalidad = escalada.Modalidad;
            this.categoria = escalada.Categoria;
            this.DesignarValores();
        }

        /// <summary>
        /// Asigna valores a los controles del formulario.
        /// </summary>
        public override void DesignarValores()
        {
            base.DesignarValores();
            this.textBoxGrado.Text = this.grado.ToString();
            this.sectionModalidad.Text = this.modalidad.ToString();
            this.sectionCategoria.Text = this.categoria.ToString();
        }

        /// <summary>
        /// Obtiene los valores de los controles del formulario.
        /// </summary>
        public override void AsignarValores()
        {
            base.AsignarValores();
            this.grado = this.textBoxGrado.Text;
            this.modalidad = this.sectionModalidad.Text;
            this.categoria = this.sectionCategoria.Text;
        }

        /// <summary>
        /// Manejador de eventos del botón "Siguiente". Agrega o modifica un deportista de escalada en la clasificación.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            bool ok = base.ChequearTodosLosCampos();
            if (ok)
            {
                this.AsignarValores();
                Escalada escalada = new Escalada(this.edad, this.nombre, this.apellido, this.dni, this.genero, this.aptoMedico, this.federado, this.categoria, this.grado, this.modalidad);
                //if (objetoModificar is not null)
                //{
                //    clasificacion -= objetoModificar;
                //    clasificacion.MandarDeportistas();
                //}
                clasificacion.AgregarDato(escalada);
                this.Close();
            }
        }
    }
}
