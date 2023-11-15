using System.Text;

namespace Etchart.JuanPablo
{
    /// <summary>
    /// Clase abstracta que representa a un deportista.
    /// </summary>
    public abstract class Deportista
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string dni;
        private string genero;
        private bool aptoMedico;
        private bool federado;

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Deportista.
        /// </summary>
        public Deportista() { }

        /// <summary>
        /// Constructor de la clase Deportista con información básica.
        /// </summary>
        /// <param name="edad">La edad del deportista.</param>
        /// <param name="nombre">El nombre del deportista.</param>
        /// <param name="apellido">El apellido del deportista.</param>
        /// <param name="dni">El DNI del deportista.</param>
        /// <param name="genero">El género del deportista.</param>
        public Deportista(int edad, string nombre, string apellido, string dni, string genero)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Dni = dni;
            this.Genero = genero;
        }

        /// <summary>
        /// Constructor de la clase Deportista con información básica y estado de aptitud médica.
        /// </summary>
        /// <param name="edad">La edad del deportista.</param>
        /// <param name="nombre">El nombre del deportista.</param>
        /// <param name="apellido">El apellido del deportista.</param>
        /// <param name="dni">El DNI del deportista.</param>
        /// <param name="genero">El género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene un estado de aptitud médica.</param>
        public Deportista(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico)
            : this(edad, nombre, apellido, dni, genero)
        {
            this.AptoMedico = aptoMedico;
        }

        /// <summary>
        /// Constructor de la clase Deportista con información básica, estado de aptitud médica y estado federado.
        /// </summary>
        /// <param name="edad">La edad del deportista.</param>
        /// <param name="nombre">El nombre del deportista.</param>
        /// <param name="apellido">El apellido del deportista.</param>
        /// <param name="dni">El DNI del deportista.</param>
        /// <param name="genero">El género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene un estado de aptitud médica.</param>
        /// <param name="federado">Indica si el deportista es federado.</param>
        public Deportista(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico, bool federado)
            : this(edad, nombre, apellido, dni, genero, aptoMedico)
        {
            this.Federado = federado;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el nombre del deportista.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el apellido del deportista.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        /// <summary>
        /// Obtiene o establece la edad del deportista.
        /// </summary>
        public int Edad { get => edad; set => edad = value; }

        /// <summary>
        /// Obtiene o establece el DNI del deportista.
        /// </summary>
        public string Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Obtiene o establece el género del deportista.
        /// </summary>
        public string Genero { get => genero; set => genero = value; }

        /// <summary>
        /// Obtiene o establece si el deportista tiene un estado de aptitud médica.
        /// </summary>
        public bool AptoMedico { get => aptoMedico; set => aptoMedico = value; }

        /// <summary>
        /// Obtiene o establece si el deportista es federado.
        /// </summary>
        public bool Federado { get => federado; set => federado = value; }

        /// <summary>
        /// Obtiene el nombre y apellido del deportista en formato "Apellido, Nombre".
        /// </summary>
        public string NombreApellido { get { return $"{this.nombre}, {this.apellido}"; } }
        #endregion

        #region Sobrecargas y Polimorfismo
        /// <summary>
        /// Sobrecarga del operador de igualdad para comparar dos deportistas por su DNI.
        /// </summary>
        /// <param name="dep1">Primer deportista a comparar.</param>
        /// <param name="dep2">Segundo deportista a comparar.</param>
        /// <returns>True si los DNI son iguales, False en caso contrario.</returns>
        public static bool operator ==(Deportista dep1, Deportista dep2)
        {
            bool retorno = false;
            if (dep1 != null && dep2 != null)
            {
                if (dep1.dni == dep2.dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comparar dos deportistas por su DNI.
        /// </summary>
        /// <param name="dep1">Primer deportista a comparar.</param>
        /// <param name="dep2">Segundo deportista a comparar.</param>
        /// <returns>True si los DNI son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Deportista dep1, Deportista dep2)
        {
            return !(dep1 == dep2);
        }

        /// <summary>
        /// Determina si esta instancia de Deportista es igual a otro objeto.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>True si son iguales, False en caso contrario.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Deportista otro)
            {
                return this.Dni == otro.Dni;
            }
            return false;
        }

        /// <summary>
        /// Representación en formato de cadena de la información del deportista.
        /// </summary>
        /// <returns>Una cadena que representa al deportista.</returns>
        public override string ToString()
        {
            return $"{this.Nombre}-{this.Apellido}-{this.Dni}";
        }
        #endregion

        #region Métodos Abstractos
        /// <summary>
        /// Sube la categoría del deportista.
        /// </summary>
        public abstract void SubirCategoria();

        /// <summary>
        /// Baja la categoría del deportista.
        /// </summary>
        public abstract void BajarCategoria();

        /// <summary>
        /// Muestra la información del deportista en formato de cadena.
        /// </summary>
        /// <returns>Una cadena que representa la información del deportista.</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Jugador: {this.NombreApellido}");
            sb.AppendLine($"Edad: {this.Edad.ToString()}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Competencia: {this.Genero}");

            return sb.ToString();
        }
        #endregion
    }
}
