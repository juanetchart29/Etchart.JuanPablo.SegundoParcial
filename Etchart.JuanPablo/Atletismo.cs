using Entidades;
using System;
using System.Text;

namespace Etchart.JuanPablo
{
    /// <summary>
    /// Clase que representa un deportista de atletismo.
    /// </summary>
    public class Atletismo : Deportista,ICategorias
    {
        /// <summary>
        /// Campo utilizado para la deserialización.
        /// </summary>
        public string deporte = "atletismo";

        private string categoria;
        private string disciplina;

        /// <summary>
        /// Constructor por defecto de la clase Atletismo.
        /// </summary>
        public Atletismo() { }

        /// <summary>
        /// Constructor de la clase Atletismo con parámetros.
        /// </summary>
        /// <param name="edad">Edad del deportista.</param>
        /// <param name="nombre">Nombre del deportista.</param>
        /// <param name="apellido">Apellido del deportista.</param>
        /// <param name="dni">DNI del deportista.</param>
        /// <param name="genero">Género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene apto médico.</param>
        /// <param name="federado">Indica si el deportista está federado.</param>
        /// <param name="disciplina">Disciplina del atletismo.</param>
        public Atletismo(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico, bool federado, string disciplina)
            : base(edad, nombre, apellido, dni, genero, aptoMedico, federado)
        {
            this.disciplina = disciplina;
        }

        /// <summary>
        /// Constructor de la clase Atletismo con parámetros adicionales.
        /// </summary>
        /// <param name="edad">Edad del deportista.</param>
        /// <param name="nombre">Nombre del deportista.</param>
        /// <param name="apellido">Apellido del deportista.</param>
        /// <param name="dni">DNI del deportista.</param>
        /// <param name="genero">Género del deportista.</param>
        /// <param name="aptoMedico">Indica si el deportista tiene apto médico.</param>
        /// <param name="federado">Indica si el deportista está federado.</param>
        /// <param name="disciplina">Disciplina del atletismo.</param>
        /// <param name="categoria">Categoría del atletismo.</param>
        public Atletismo(int edad, string nombre, string apellido, string dni, string genero, bool aptoMedico, bool federado, string disciplina, string categoria)
            : this(edad, nombre, apellido, dni, genero, aptoMedico, federado, disciplina)
        {
            this.categoria = categoria;
        }

        /// <summary>
        /// Obtiene o establece la categoría del atletismo.
        /// </summary>
        public string Categoria
        {
            get => categoria;
            set => categoria = value;
        }

        /// <summary>
        /// Obtiene o establece la disciplina del atletismo.
        /// </summary>
        public string Disciplina
        {
            get => disciplina;
            set => disciplina = value;
        }

        /// <summary>
        /// Sube la categoría del atletismo.
        /// </summary>
        public void SubirCategoria()
        {
            switch (this.Categoria)
            {
                case "Inicial":
                    this.Categoria = "Juvenil";
                    break;
                case "Juvenil":
                    this.Categoria = "Senior";
                    break;
                case "Senior":
                    break;
            }
        }

        /// <summary>
        /// Baja la categoría del atletismo.
        /// </summary>
        public  void BajarCategoria()
        {
            switch (this.Categoria)
            {
                case "Inicial":
                    break;
                case "Juvenil":
                    this.Categoria = "Inicial";
                    break;
                case "Senior":
                    this.Categoria = "Juvenil";
                    break;
            }
        }

        /// <summary>
        /// Devuelve una representación en formato de cadena del objeto Atletismo.
        /// </summary>
        /// <returns>Cadena que representa el objeto Atletismo.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Disciplina: {this.Disciplina}");
            sb.AppendLine($"Categoría: {this.Categoria}");
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve una representación en formato de cadena del objeto Atletismo.
        /// </summary>
        /// <returns>Cadena que representa el objeto Atletismo.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine(this.Mostrar());
            return stringBuilder.ToString();
        }
    }
}
