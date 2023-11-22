using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etchart.JuanPablo
{
    /// <summary>
    /// Clase que representa un jugador de voleibol.
    /// </summary>
    public class Voley : Deportista, ICategorias
    {
        public string deporte = "voley"; // Esto es necesario para la deserialización

        private string posicion;
        private float altura;
        private int partidosJugados;
        private string categoria;

        /// <summary>
        /// Obtiene o establece la posición del jugador de voleibol.
        /// </summary>
        public string Posicion { get => posicion; set => posicion = value; }

        /// <summary>
        /// Obtiene o establece la altura del jugador de voleibol.
        /// </summary>
        public float Altura { get => altura; set => altura = value; }

        /// <summary>
        /// Obtiene o establece la cantidad de partidos jugados por el jugador de voleibol.
        /// </summary>
        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }

        /// <summary>
        /// Obtiene o establece la categoría del jugador de voleibol.
        /// </summary>
        public string Categoria { get => categoria; set => categoria = value; }

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Voley.
        /// </summary>
        public Voley() { }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Voley.
        /// </summary>
        /// <param name="edad">Edad del jugador de voleibol.</param>
        /// <param name="nombre">Nombre del jugador de voleibol.</param>
        /// <param name="apellido">Apellido del jugador de voleibol.</param>
        /// <param name="dni">DNI del jugador de voleibol.</param>
        /// <param name="genero">Género del jugador de voleibol.</param>
        /// <param name="certificadoMedico">Indica si el jugador de voleibol tiene certificado médico.</param>
        /// <param name="federado">Indica si el jugador de voleibol es federado.</param>
        /// <param name="partidosJugados">Cantidad de partidos jugados por el jugador de voleibol.</param>
        /// <param name="altura">Altura del jugador de voleibol.</param>
        /// <param name="posicion">Posición del jugador de voleibol.</param>
        public Voley(int edad, string nombre, string apellido, string dni, string genero, bool certificadoMedico, bool federado, int partidosJugados, float altura, string posicion)
            : base(edad, nombre, apellido, dni, genero, certificadoMedico, federado)
        {
            this.posicion = posicion;
            this.altura = altura;
            this.partidosJugados = partidosJugados;
        }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Voley.
        /// </summary>
        /// <param name="edad">Edad del jugador de voleibol.</param>
        /// <param name="nombre">Nombre del jugador de voleibol.</param>
        /// <param name="apellido">Apellido del jugador de voleibol.</param>
        /// <param name="dni">DNI del jugador de voleibol.</param>
        /// <param name="genero">Género del jugador de voleibol.</param>
        /// <param name="certificadoMedico">Indica si el jugador de voleibol tiene certificado médico.</param>
        /// <param name="federado">Indica si el jugador de voleibol es federado.</param>
        /// <param name="partidosJugados">Cantidad de partidos jugados por el jugador de voleibol.</param>
        /// <param name="altura">Altura del jugador de voleibol.</param>
        /// <param name="posicion">Posición del jugador de voleibol.</param>
        /// <param name="categoria">Categoría del jugador de voleibol.</param>
        public Voley(int edad, string nombre, string apellido, string dni, string genero, bool certificadoMedico, bool federado, int partidosJugados, float altura, string posicion, string categoria)
            : this(edad, nombre, apellido, dni, genero, certificadoMedico, federado, partidosJugados, altura, posicion)
        {
            this.categoria = categoria;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Incrementa la categoría del jugador de voleibol.
        /// </summary>
        public void SubirCategoria()
        {
            switch (this.Categoria)
            {
                case "Cadete":
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
        /// Decrementa la categoría del jugador de voleibol.
        /// </summary>
        public void BajarCategoria()
        {
            switch (this.Categoria)
            {
                case "Cadete":
                    break;
                case "Juvenil":
                    this.Categoria = "Cadete";
                    break;
                case "Senior":
                    this.Categoria = "Juvenil";
                    break;
            }
        }

        /// <summary>
        /// Obtiene una representación en formato de cadena de la información del jugador de voleibol.
        /// </summary>
        /// <returns>Una cadena que representa la información del jugador de voleibol.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura: {this.Altura.ToString()}");
            sb.AppendLine($"Categoría: {this.Categoria.ToString()}");
            return sb.ToString();
        }

        /// <summary>
        /// Obtiene una representación en formato de cadena de la información del jugador de voleibol.
        /// </summary>
        /// <returns>Una cadena que representa la información del jugador de voleibol.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine(this.Mostrar());
            return stringBuilder.ToString();
        }
        #endregion

    }
}
