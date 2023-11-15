using Entidades;
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
    /// Formulario para agregar o modificar un deportista de la disciplina de vóley.
    /// </summary>
    public partial class FRMAgregarVoley : FRMAgragarDeportista
    {
        #region atributos

        private int partidosJugados;
        private float altura;
        private string posicion;
        private string categoria;

        private Voley objetoModificar = null;

        #endregion

        /// <summary>
        /// Constructor de la clase FRMAgregarVoley.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        public FRMAgregarVoley(Clasificacion clasificacion) : base(clasificacion)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la clase FRMAgregarVoley utilizado para modificar un deportista de vóley.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        /// <param name="voley">Deportista de vóley a modificar.</param>
        public FRMAgregarVoley(Clasificacion clasificacion, Voley voley) : this(clasificacion)
        {
            objetoModificar = voley;
            base.setearBasics(voley);
            this.partidosJugados = voley.PartidosJugados;
            this.altura = voley.Altura;
            this.posicion = voley.Posicion;
            this.categoria = voley.Categoria;
            this.DesignarValores();
        }

        /// <summary>
        /// Asigna valores a los controles del formulario.
        /// </summary>
        public override void DesignarValores()
        {
            base.DesignarValores();
            this.txtBoxPosicion.Text = this.posicion.ToString();
            this.txtBoxAltura.Text = this.altura.ToString();
            this.txtBoxPartidosJugados.Text = this.partidosJugados.ToString();
            this.sectionCategoria.Text = this.categoria;
        }

        /// <summary>
        /// Obtiene los valores de los controles del formulario.
        /// </summary>
        public override void AsignarValores()
        {
            base.AsignarValores();
            this.posicion = this.txtBoxPosicion.Text;
            this.altura = float.Parse(this.txtBoxAltura.Text);
            this.partidosJugados = int.Parse(this.txtBoxPartidosJugados.Text);
            this.categoria = this.sectionCategoria.Text;
        }

        /// <summary>
        /// Manejador de eventos del botón "Siguiente". Agrega o modifica un deportista de vóley en la clasificación.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            bool ok = this.ChequearTodosLosCampos();
            if (ok)
            {
                this.AsignarValores();
                Voley voley = new Voley(this.edad, this.nombre, this.apellido, this.dni, this.genero, this.aptoMedico, this.federado, this.partidosJugados, this.altura, this.posicion, this.categoria);
                if (objetoModificar is not null)
                {
                    clasificacion -= objetoModificar;
                    clasificacion.MandarDeportistas();
                }
                clasificacion += voley;
                clasificacion.MandarDeportistas();
                this.Close();
            }
        }

        /// <summary>
        /// Verifica que todos los campos estén completos y que los campos de altura y partidos jugados contengan números válidos.
        /// </summary>
        /// <returns><c>true</c> si todos los campos están completos y contienen números válidos, <c>false</c> en caso contrario.</returns>
        public override bool ChequearTodosLosCampos()
        {
            bool retorno = base.ChequearTodosLosCampos();
            if (retorno)
            {
                if (!(float.TryParse(this.txtBoxAltura.Text, out float numero1) && int.TryParse(this.txtBoxPartidosJugados.Text, out int numero2)))
                {
                    retorno = false;
                    this.lblError.Text = "Ingrese un número válido en el campo de altura y partidos jugados.";
                }
            }
            return retorno;
        }
    }
}
