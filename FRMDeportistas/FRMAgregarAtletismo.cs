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
using Entidades;
using Etchart.JuanPablo;
using Microsoft.VisualBasic;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario para agregar o modificar un deportista de la disciplina de atletismo.
    /// </summary>
    public partial class FRMAgregarAtletismo : FRMAgragarDeportista
    {
        #region atributos
        private string disciplina;
        private string Categoria;
        private Atletismo objetoModificar = null;
        #endregion

        /// <summary>
        /// Constructor de la clase FRMAgregarAtletismo.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        public FRMAgregarAtletismo(AccesoDatos clasificacion) : base(clasificacion)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la clase FRMAgregarAtletismo utilizado para modificar un deportista de atletismo.
        /// </summary>
        /// <param name="clasificacion">Clasificación de deportistas.</param>
        /// <param name="atletismo">Deportista de atletismo a modificar.</param>
        public FRMAgregarAtletismo(AccesoDatos clasificacion, Atletismo atletismo) : this(clasificacion)
        {
            objetoModificar = atletismo;
            base.setearBasics(atletismo);
            this.disciplina = atletismo.Disciplina;
            this.Categoria = atletismo.Categoria;
            this.DesignarValores();
        }

        /// <summary>
        /// Asigna valores a los controles del formulario.
        /// </summary>
        public override void DesignarValores()
        {
            base.DesignarValores();
            this.txtBoxDisciplina.Text = this.disciplina.ToString();
            this.sectionCategoria.Text = this.Categoria.ToString();
        }

        /// <summary>
        /// Obtiene los valores de los controles del formulario.
        /// </summary>
        public override void AsignarValores()
        {
            base.AsignarValores();
            this.disciplina = this.txtBoxDisciplina.Text;
            this.Categoria = this.sectionCategoria.Text;
        }

        /// <summary>
        /// Manejador de eventos del botón "Siguiente". Agrega o modifica un deportista de atletismo en la clasificación.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            bool ok = base.ChequearTodosLosCampos();
            if (ok)
            {
                this.AsignarValores();
                Atletismo atletismo = new Atletismo(this.edad, this.nombre, this.apellido, this.dni, this.genero, this.aptoMedico, this.federado, this.disciplina, this.Categoria);
                //if (objetoModificar is not null)
                //{
                //    clasificacion -= objetoModificar;
                //    clasificacion.MandarDeportistas();
                //}
                ok = clasificacion.AgregarDato(atletismo);
                MessageBox.Show(ok.ToString());
                this.Close();
            }
        }
    }
}
