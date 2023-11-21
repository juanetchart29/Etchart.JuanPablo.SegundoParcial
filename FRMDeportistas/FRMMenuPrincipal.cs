using Entidades;
using System.Text;
namespace FRMDeportistas
{
    /// <summary>
    /// Formulario principal de la aplicación para gestionar deportistas y clasificaciones.
    /// </summary>
    public partial class FRMMenuPrincipal : Form
    {




        #region Atributos

        /// <summary>
        /// Formulario hijo activo en el momento.
        /// </summary>
        public Form formActivo;

        /// <summary>
        /// Clasificación de deportistas.
        /// </summary>

        /// <summary>
        /// Ruta del archivo de deportistas.
        /// </summary>
        public string path;
        public AccesoDatos clasificacion;

        public Usuario usuarioActual;


        #endregion

        /// <summary>
        /// Constructor de la clase FRMMenuPrincipal.
        /// </summary>
        public FRMMenuPrincipal()
        {
            InitializeComponent();
            path = "Deportistas.json";
            
            this.clasificacion = new AccesoDatos();
            clasificacion.ErrorOcurrido += AccesoDatos_ErrorOcurrido;
            AbrirFormularioHijo(new AgregarPorDeporte(this.clasificacion), this.btnAgregar.Text);
            

        }

        private void AccesoDatos_ErrorOcurrido(MiExcepcionDB dB)
        {
            
        }




        /// <summary>
        /// Constructor de la clase FRMMenuPrincipal con un nombre de usuario.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario que ha iniciado sesión.</param>
        public FRMMenuPrincipal(Usuario usuario) : this()
        {
            this.usuarioActual = usuario;
            this.lblNombreUsuario.Text = usuario.Nombre;
            this.lblHoraIngreso.Text = DateTime.Now.ToString();
            this.AplicarRestriccion(usuario);
        }

        public void AplicarRestriccion(Usuario usuario)
        {
            if (usuario.Perfil == "vendedor" || usuario.Perfil == "supervisor")
            {
                this.btnVerIngresos.Visible = false;
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Agregar".
        /// Abre el formulario para agregar deportistas por deporte.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AbrirFormularioHijo(new AgregarPorDeporte(this.clasificacion), btn.Text);
        }

        #region Metodos

        /// <summary>
        /// Abre un formulario hijo en el panel y muestra el texto en el encabezado del formulario.
        /// </summary>
        /// <param name="formularioHijo">El formulario hijo a abrir.</param>
        /// <param name="textoBoton">El texto que se mostrará en el encabezado del formulario.</param>
        private void AbrirFormularioHijo(Form formularioHijo, string textoBoton)
        {
            // Me fijo si hay un formulario hijo activo y si lo hay lo cierro.
            if (formActivo != null)
                formActivo.Close();

            // Seteo como nuevo formulario activo el hijo.
            formActivo = formularioHijo;

            // Seteo al hijo para que no tenga la parte superior ni bordes.
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agrego el formulario hijo al panelWinHijo.
            this.panelWinHijo.Controls.Add(formularioHijo);
            this.panelWinHijo.Tag = formularioHijo;

            // Coloco en la parte superior el formulario hijo y lo muestro.
            formularioHijo.BringToFront();
            formularioHijo.Show();

            // Seteo el lbl para que me indique en qué apartado estoy.
            this.lblPanelWinHijo.Text = textoBoton;
        }

        #endregion

        /// <summary>
        /// Manejador de eventos para el panel "SideBar".
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver Clasificación".
        /// Abre el formulario para ver la clasificación de deportistas.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnVerClasificacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AbrirFormularioHijo(new FRMVerClasificacion(this.clasificacion,this.usuarioActual), btn.Text);
        }

        /// <summary>
        /// Manejador de eventos que se ejecuta cuando el formulario se carga.
        /// Carga la clasificación de deportistas.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FRMMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Manejador de eventos para el cierre del formulario.
        /// Muestra un cuadro de diálogo de confirmación antes de cerrar la aplicación.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FRMMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Seleccionar JSON".
        /// Abre un formulario para seleccionar un archivo JSON de deportistas.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnSeleccionarJson_Click(object sender, EventArgs e)
        {
            using (FRMSeleccionarJson frmJson = new FRMSeleccionarJson())
            {
                if (frmJson.ShowDialog() == DialogResult.OK)
                {
                    this.path = frmJson.ObtenerPath(); // Aquí obtienes el valor del formulario emergente
                }
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ver Ingresos".
        /// Abre el formulario para ver los registros de usuarios ingresados.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.AbrirFormularioHijo(new FRMIngresos(), btn.Text);
        }
    }
}
