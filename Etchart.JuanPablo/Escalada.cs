using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etchart.JuanPablo
{
    /// <summary>
    /// Clase que representa a un deportista de escalada.
    /// </summary>
    public class Escalada : Deportista
    {
        #region Atributos

        public string deporte = "escalada"; // Esto es necesario para mi deserialización

        private string grado;
        private string modalidad;
        private string categoria;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de la clase Escalada.
        /// </summary>
        public Escalada()
        {

        }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Escalada.
        /// </summary>
        /// <param name="edad">Edad del deportista.</param>
        /// <param name="nombre">Nombre del deportista.</param>
        /// <param name="apellido">Apellido del deportista.</param>
        /// <param name="dni">DNI del deportista.</param>
        /// <param name="genero">Género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene apto médico.</param>
        /// <param name="federado">Indica si el deportista está federado.</param>
        /// <param name="categoria">Categoría del deportista.</param>
        /// <param name="grado">Grado máximo del deportista.</param>
        public Escalada(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico, bool federado, string categoria, string grado)
            : base(edad, nombre, apellido, dni, genero, aptoMedico, federado)
        {
            this.categoria = categoria;
            this.grado = grado;
        }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Escalada.
        /// </summary>
        /// <param name="edad">Edad del deportista.</param>
        /// <param name="nombre">Nombre del deportista.</param>
        /// <param name="apellido">Apellido del deportista.</param>
        /// <param name="dni">DNI del deportista.</param>
        /// <param name="genero">Género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene apto médico.</param>
        /// <param name="federado">Indica si el deportista está federado.</param>
        /// <param name="categoria">Categoría del deportista.</param>
        /// <param name="grado">Grado máximo del deportista.</param>
        /// <param name="modalidad">Modalidad de escalada del deportista.</param>
        public Escalada(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico, bool federado, string categoria, string grado, string modalidad)
            : this(edad, nombre, apellido, dni, genero, aptoMedico, federado, categoria, grado)
        {
            this.Categoria = categoria;
            this.Grado = grado;
            this.Modalidad = modalidad;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el grado máximo del deportista de escalada.
        /// </summary>
        public string Grado { get => this.grado; set => this.grado = value; }

        /// <summary>
        /// Obtiene o establece la modalidad de escalada del deportista.
        /// </summary>
        public string Modalidad { get => this.modalidad; set => this.modalidad = value; }

        /// <summary>
        /// Obtiene o establece la categoría del deportista de escalada.
        /// </summary>
        public string Categoria { get => this.categoria; set => this.categoria = value; }

        #endregion

        #region Metodos

        /// <summary>
        /// Incrementa la categoría del deportista de escalada.
        /// </summary>
        public override void SubirCategoria()
        {
            switch (this.Categoria)
            {
                case "PromoB":
                    this.Categoria = "PromoA";
                    break;
                case "PromoA":
                    this.Categoria = "Mayores";
                    break;
                case "Mayores":
                    break;
            }
        }

        /// <summary>
        /// Reduce la categoría del deportista de escalada.
        /// </summary>
        public override void BajarCategoria()
        {
            switch (this.Categoria)
            {
                case "PromoB":
                    break;
                case "PromoA":
                    this.Categoria = "PromoB";
                    break;
                case "Mayores":
                    this.Categoria = "PromoA";
                    break;
            }
        }

        /// <summary>
        /// Obtiene una representación en formato de cadena de la información del deportista de escalada.
        /// </summary>
        /// <returns>Una cadena que representa la información del deportista de escalada.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Grado Máximo: {this.Grado}");
            sb.AppendLine($"Categoría: {this.Categoria.ToString()}");
            sb.AppendLine($"Modalidad: {this.Modalidad}");
            return sb.ToString();
        }

        /// <summary>
        /// Obtiene una representación en formato de cadena de la información del deportista de escalada.
        /// </summary>
        /// <returns>Una cadena que representa la información del deportista de escalada.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine(this.Mostrar());
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Determina si esta instancia de Escalada es igual a otro objeto.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>True si son iguales, False en caso contrario.</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #endregion
    }
}
