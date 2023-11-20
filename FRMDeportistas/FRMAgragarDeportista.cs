using Entidades;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;
using GroupBox = System.Windows.Forms.GroupBox;
using Etchart.JuanPablo;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario base para agregar deportistas.
    /// </summary>
    public partial class FRMAgragarDeportista : Form
    {
        #region atributos

        protected int edad;
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string genero;
        protected bool aptoMedico;
        protected bool federado;

        protected string path = "Deportistas.json";

        public AccesoDatos clasificacion;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase FRMAgragarDeportista.
        /// </summary>
        public FRMAgragarDeportista()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la clase FRMAgragarDeportista con Clasificacion.
        /// </summary>
        /// <param name="clasificacion">La instancia de Clasificacion utilizada para gestionar deportistas.</param>
        public FRMAgragarDeportista(AccesoDatos clasificacion) : this()
        {
            this.clasificacion = clasificacion;
        }

        /// <summary>
        /// Establece los valores básicos del deportista.
        /// </summary>
        /// <param name="deportista">El deportista del que se tomarán los valores.</param>
        public virtual void setearBasics(Deportista deportista)
        {
            this.nombre = deportista.Nombre;
            this.dni = deportista.Dni;
            this.apellido = deportista.Apellido;
            this.edad = deportista.Edad;
            this.aptoMedico = deportista.AptoMedico;
            this.federado = deportista.Federado;
            this.genero = deportista.Genero;
        }

        #endregion

        /// <summary>
        /// Diseña los valores en los controles del formulario.
        /// </summary>
        public virtual void DesignarValores()
        {
            this.txtBoxEdad.Text = this.edad.ToString();
            this.txbApellido.Text = this.apellido;
            this.txbDni.Text = this.dni;
            this.txbNombre.Text = this.nombre;
            this.sectionCompetencia.Text = this.genero;

            if (this.aptoMedico)
            {
                this.rbEntregado.Checked = true;
                this.rbNoEntregado.Checked = false;
            }
            else
            {
                this.rbEntregado.Checked = false;
                this.rbNoEntregado.Checked = true;
            }

            if (this.federado)
            {
                this.rbFederado.Checked = false;
                this.rbNoFederado.Checked = true;
            }
            else
            {
                this.rbFederado.Checked = true;
                this.rbNoFederado.Checked = false;
            }
        }

        /// <summary>
        /// Asigna los valores de los controles a las propiedades del deportista.
        /// </summary>
        public virtual void AsignarValores()
        {
            this.edad = int.Parse(this.txtBoxEdad.Text);
            this.apellido = this.txbApellido.Text.ToString();
            this.dni = this.txbDni.Text.ToString();
            this.nombre = this.txbNombre.Text.ToString();
            this.genero = this.sectionCompetencia.Text.ToString();

            if (rbEntregado.Checked)
            {
                this.aptoMedico = true;
            }
            else
            {
                this.aptoMedico = false;
            }

            if (this.rbFederado.Checked)
            {
                this.federado = true;
            }
            else
            {
                this.federado = false;
            }
        }

        /// <summary>
        /// Verifica si todos los campos requeridos están completos.
        /// </summary>
        /// <returns>true si todos los campos están completos; de lo contrario, false.</returns>
        public virtual bool ChequearTodosLosCampos()
        {
            bool retorno = true;
            int countRadioButton = 0;
            StringBuilder respuesta = new StringBuilder();

            foreach (Control control in this.Controls)
            {
                // Si es un TextBox o un GroupBox y está vacío, establece retorno en false y sale del bucle.
                if ((control is TextBox || control is GroupBox) && string.IsNullOrEmpty(control.Text))
                {
                    retorno = false;
                    break;
                }
            }

            if (this.rbEntregado.Checked || this.rbNoEntregado.Checked)
            {
                countRadioButton++;
            }

            if (this.rbFederado.Checked || this.rbNoFederado.Checked)
            {
                countRadioButton++;
            }

            if (countRadioButton < 2)
            {
                retorno = false;
                respuesta.AppendLine("-Debe chequear al menos un RadioButton en cada panel.");
            }

            if (!retorno)
            {
                respuesta.AppendLine("-No se han completado todos los campos");
            }

            if (!int.TryParse(this.txtBoxEdad.Text, out int numero))
            {
                retorno = false;
                respuesta.AppendLine("-En el campo 'EDAD' no está ingresando un número válido");
            }

            this.lblError.Text = respuesta.ToString();

            return retorno;
        }
    }
}
