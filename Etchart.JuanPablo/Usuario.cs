using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un usuario del sistema.
    /// </summary>
    public class Usuario
    {
        #region Atributos

        private string nombre;
        private string apellido;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public string rutaArchivo;
        public List<Usuario> usuarios;

        public static DateTime horaCreacion;

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el legajo del usuario.
        /// </summary>
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Obtiene o establece el apellido del usuario.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        /// <summary>
        /// Obtiene o establece el correo del usuario.
        /// </summary>
        public string Correo { get => correo; set => correo = value; }

        /// <summary>
        /// Obtiene o establece la clave del usuario.
        /// </summary>
        public string Clave { get => clave; set => clave = value; }

        /// <summary>
        /// Obtiene o establece el perfil del usuario.
        /// </summary>
        public string Perfil { get => perfil; set => perfil = value; }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor estático que inicializa la hora de creación de la clase.
        /// </summary>
        static Usuario()
        {
            Usuario.horaCreacion = DateTime.Now;
        }

        /// <summary>
        /// Constructor por defecto de la clase Usuario.
        /// </summary>
        public Usuario()
        {
            this.rutaArchivo = "Usuarios.json";
        }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Usuario.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="apellido">Apellido del usuario.</param>
        /// <param name="legajo">Legajo del usuario.</param>
        /// <param name="correo">Correo del usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        public Usuario(string nombre, string apellido, int legajo, string correo, string clave)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.correo = correo;
            this.Clave = clave;
        }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Usuario.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="apellido">Apellido del usuario.</param>
        /// <param name="legajo">Legajo del usuario.</param>
        /// <param name="correo">Correo del usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        /// <param name="perfil">Perfil del usuario.</param>
        public Usuario(string nombre, string apellido, int legajo, string correo, string clave, string perfil)
            : this(nombre, apellido, legajo, correo, clave)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Obtiene una representación en formato de cadena de la información del usuario.
        /// </summary>
        /// <returns>Una cadena que representa la información del usuario.</returns>
        public override string ToString()
        {
            DateTime ahora = DateTime.Now;
            return $"{this.Nombre}-{this.Apellido}-{this.Legajo}-{this.Correo}-{this.Clave}-{this.Perfil}-{ahora}";
        }

        #endregion
    }
}
