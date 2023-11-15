using Etchart.JuanPablo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una clasificación de deportistas.
    /// </summary>
    public class Clasificacion
    {
        /// <summary>
        /// Lista que contiene todos los deportistas.
        /// </summary>
        public List<Deportista> listaTotal;

        /// <summary>
        /// Lista que contiene deportistas de escalada.
        /// </summary>
        public List<Escalada> listaEscalada;

        /// <summary>
        /// Lista que contiene deportistas de atletismo.
        /// </summary>
        public List<Atletismo> listaAtletismo;

        /// <summary>
        /// Lista que contiene deportistas de vóley.
        /// </summary>
        public List<Voley> listaVoley;

        /// <summary>
        /// Constructor por defecto de la clase Clasificacion.
        /// </summary>
        public Clasificacion()
        {
            this.listaTotal = new List<Deportista>();
            this.listaEscalada = new List<Escalada>();
            this.listaAtletismo = new List<Atletismo>();
            this.listaVoley = new List<Voley>();
        }

        /// <summary>
        /// Sobrecarga del operador de adición para agregar un deportista a la clasificación.
        /// </summary>
        /// <param name="contenedor">Clasificación a la que se agrega el deportista.</param>
        /// <param name="deportista">Deportista a agregar.</param>
        /// <returns>La clasificación actualizada con el deportista.</returns>
        public static Clasificacion operator +(Clasificacion contenedor, Deportista deportista)
        {
            contenedor.listaTotal.Add(deportista);
            if (deportista is Escalada escalada)
            {
                contenedor.listaEscalada.Add(escalada);
            }
            else if (deportista is Atletismo atletismo)
            {
                contenedor.listaAtletismo.Add(atletismo);
            }
            else if (deportista is Voley voley)
            {
                contenedor.listaVoley.Add(voley);
            }
            return contenedor;
        }

        /// <summary>
        /// Sobrecarga del operador de sustracción para eliminar un deportista de la clasificación.
        /// </summary>
        /// <param name="contenedor">Clasificación de la que se elimina el deportista.</param>
        /// <param name="deportista">Deportista a eliminar.</param>
        /// <returns>La clasificación actualizada sin el deportista.</returns>
        public static Clasificacion operator -(Clasificacion contenedor, Deportista deportista)
        {
            contenedor.listaTotal.Remove(deportista);
            if (deportista is Escalada escalada)
            {
                contenedor.listaEscalada.Remove(escalada);
            }
            else if (deportista is Atletismo atletismo)
            {
                contenedor.listaAtletismo.Remove(atletismo);
            }
            else if (deportista is Voley voley)
            {
                contenedor.listaVoley.Remove(voley);
            }
            return contenedor;
        }

        /// <summary>
        /// Obtiene la lista de deportistas a partir de un archivo JSON y los asigna a las listas por tipo.
        /// </summary>
        /// <param name="path">La ruta del archivo JSON que contiene los deportistas.</param>
        /// <returns>Una instancia de Clasificacion con los deportistas cargados.</returns>
        public static Clasificacion TraerDeportistas(string path = "Deportistas.json")
        {
            Clasificacion clasificacion = new Clasificacion();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json_str = sr.ReadToEnd();

                    JArray deportistasArray = JArray.Parse(json_str);
                    foreach (JObject item in deportistasArray)
                    {
                        Deportista deportista;

                        string tipoDeporte = item.GetValue("deporte").ToString().ToLower();
                        if (tipoDeporte == "escalada")
                            deportista = item.ToObject<Escalada>();
                        else if (tipoDeporte == "atletismo")
                            deportista = item.ToObject<Atletismo>();
                        else if (tipoDeporte == "voley")
                            deportista = item.ToObject<Voley>();
                        else
                            throw new InvalidOperationException("Tipo de deporte no reconocido");

                        clasificacion += deportista; // Asumiendo que este es el método para agregar el deportista a la clasificación.
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return clasificacion;
        }

        /// <summary>
        /// Guarda la lista de deportistas en un archivo JSON sobrescribiendo el contenido existente.
        /// </summary>
        /// <param name="path">La ruta del archivo JSON donde se guardarán los deportistas.</param>
        public void MandarDeportistas(string path = "Deportistas.json")
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                string jsonDeportistas = JsonConvert.SerializeObject(this.listaTotal, Formatting.Indented);
                sw.Write(jsonDeportistas);
            }
        }

        /// <summary>
        /// Compara dos instancias de Clasificacion para determinar si son iguales.
        /// </summary>
        /// <param name="c1">Primera instancia de Clasificacion a comparar.</param>
        /// <param name="c2">Segunda instancia de Clasificacion a comparar.</param>
        /// <returns>True si son iguales, False en caso contrario.</returns>
        public static bool operator ==(Clasificacion c1, Clasificacion c2)
        {
            return c1.listaTotal == c2.listaTotal;
        }

        /// <summary>
        /// Compara dos instancias de Clasificacion para determinar si son diferentes.
        /// </summary>
        /// <param name="c1">Primera instancia de Clasificacion a comparar.</param>
        /// <param name="c2">Segunda instancia de Clasificacion a comparar.</param>
        /// <returns>True si son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Clasificacion c1, Clasificacion c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Determina si esta instancia de Clasificacion es igual a otro objeto.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>True si son iguales, False en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            return this == obj;
        }
    }
}
