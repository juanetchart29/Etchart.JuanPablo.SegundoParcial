using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;// se encarga de conectarse con el motor de la base de datos
        private static string cadena_conexion;

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = 
        }
    }
}
