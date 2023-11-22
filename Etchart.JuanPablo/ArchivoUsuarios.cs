using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Entidades
{
    /// <summary>
    /// Clase estática para administrar archivos de usuarios y registros.
    /// </summary>
    public static class ArchivoUsuarios
    {
        private static string pathLog = "Registro.log";
        private static string pathUsuarios = "Usuarios.json";

        public static List<Usuario> usuarios;
        static ArchivoUsuarios()
        {
            ArchivoUsuarios.pathLog = "Registro.log";
            ArchivoUsuarios.pathUsuarios = "Usuarios.json";
            ArchivoUsuarios.usuarios = new List<Usuario>();
            ArchivoUsuarios.usuarios = ArchivoUsuarios.TraerUsuarios();
        }

        /// <summary>
        /// Ruta del archivo de registro.
        /// </summary>
        public static string PathLog
        {
            get => pathLog;
            set => pathLog = value;
        }

        /// <summary>
        /// Ruta del archivo de usuarios.
        /// </summary>
        public static string PathUsuarios
        {
            get => pathUsuarios;
            set => pathUsuarios = value;
        }

        /// <summary>
        /// Registra un usuario en el archivo de registro.
        /// </summary>
        /// <param name="miUsuario">El usuario a registrar.</param>
        public static void Registrar(Usuario miUsuario)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ArchivoUsuarios.PathLog, true))
                {
                    writer.WriteLine(miUsuario.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static Usuario LogearUsuario(string mail,string contraseña)
        {
            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(contraseña))
            {
            }


            foreach (Usuario item in ArchivoUsuarios.usuarios)
            {

                if (contraseña == item.Clave && mail == item.Correo)
                {
                    ArchivoUsuarios.Registrar(item);
                    return item;
                }
            }
            return null;
        }
    




        /// <summary>
        /// Obtiene la lista de registros del archivo de registro.
        /// </summary>
        /// <returns>Lista de registros como cadenas.</returns>
        public static List<string> TraerRegistro()
        {
            List<string> listaIngresos = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(ArchivoUsuarios.PathLog, true))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        listaIngresos.Add(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del registro.
                Console.WriteLine("Error al leer el registro: " + ex.Message);
            }
            return listaIngresos;
        }

        /// <summary>
        /// Obtiene la lista de usuarios del archivo de usuarios.
        /// </summary>
        /// <returns>Lista de usuarios o null si hay un error.</returns>
        public static List<Usuario>? TraerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (StreamReader sr = new StreamReader(ArchivoUsuarios.PathUsuarios))
            {
                // Lee el contenido del archivo JSON
                string contenido = sr.ReadToEnd();

                // Deserializa el JSON en una lista de objetos de tipo Usuario
                listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }

            return listaUsuarios;
        }
    }
}
