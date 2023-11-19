using Etchart.JuanPablo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class AccesoDatos
    {
        public SqlCommand comando;//con este objeto realizo las querys
        private SqlConnection conexion;// se encarga de conectarse con el motor de la base de datos
        private static string cadena_conexion;
        private SqlDataReader lector;//contiende lo que me devuelve la consulta sql
        static AccesoDatos()
        {
            //seteo mi cadena de conexion
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }


        public bool pruebaConexion()
        {
            bool retorno = false;
            try
            {
                this.conexion.Open();
                retorno = true;
            }
            catch(Exception ex)
            {
                // Handle exceptions if needed
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
        public void AsignarParametrosDeportista(Deportista deportista)
        {
            this.comando.Parameters.AddWithValue("@nombre", deportista.Nombre);
            this.comando.Parameters.AddWithValue("@apellido", deportista.Apellido);
            this.comando.Parameters.AddWithValue("@edad", deportista.Edad);
            this.comando.Parameters.AddWithValue("@dni", deportista.Dni);
            this.comando.Parameters.AddWithValue("@aptoMedico", deportista.AptoMedico);
            this.comando.Parameters.AddWithValue("@federado", deportista.Federado);
            this.comando.Parameters.AddWithValue("@genero", deportista.Genero);
        }

        public void AsignarParametrosVoley(Voley deportista)
        {
            this.comando.Parameters.AddWithValue("@posicion", deportista.Posicion);
            this.comando.Parameters.AddWithValue("@altura", deportista.Altura);
            this.comando.Parameters.AddWithValue("@partidosJugados", deportista.PartidosJugados);
            this.comando.Parameters.AddWithValue("@categoria", deportista.Categoria);
        }
        public void AsignarParametrosEscalada(Escalada deportista )
        {
            this.comando.Parameters.AddWithValue("@grado", deportista.Grado);
            this.comando.Parameters.AddWithValue("@categoria", deportista.Categoria);
            this.comando.Parameters.AddWithValue("@modalidad", deportista.Modalidad);
        }
        public void AsignarParametrosAtletismo(Atletismo deportista)
        {
            this.comando.Parameters.AddWithValue("@categoria", deportista.Categoria);
            this.comando.Parameters.AddWithValue("@disciplina", deportista.Disciplina);
        }
        public List<T> TraerDatos<T>() where T : Deportista, new()
        {
            List<T> lista = new List<T>();

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text; // enum indica que va a ejecutar si es text --> una consulta, table ->taba

            string tipoDeDato = typeof(T).Name;
            switch(tipoDeDato)
            {
                case "Escalada":

                    Escalada escalada = new Escalada();
                    this.AsignarParametrosDeportista(escalada);
                    this.AsignarParametrosEscalada(escalada);
                    this.comando.CommandText = "select id "
                    break;
                case "Voley":
                    Voley voley= new Voley();
                    this.AsignarParametrosDeportista(voley);
                    this.AsignarParametrosVoley(voley);
                    break;
                case "Atletismo":
                    Atletismo atletismo = new Atletismo();
                    this.AsignarParametrosDeportista(atletismo);
                    this.AsignarParametrosAtletismo(atletismo); 
                    break;
            }
            try
            {
                this.comando.CommandText = "select id,cadena, from dato";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                //this.comando.ExecuteNonQuery(); estas para agregar datos a sql, no retorno
                this.lector = this.comando.ExecuteReader();//consultas de tipo select

                while (lector.Read()) //siempre que tengascosas para leer
                {
                    Deportista deportista = new Deportista();
                    deportista.Nombre = (string)this.lector["nombre"];
                    deportista.Nombre = this.lector[1].ToString();

                    deportista.Dni = this.lector.GetFloat(3);

                }
                this.lector.Close();
            }
            catch (Exception ex) 
            {
            
            }






            return lista;
        }
        public bool AgregarDato(Deportista deportista)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "insert into deportista(cadena,entero,flotante) values('" + deportista.Nombre + "')" ;//las casdenas van entre comillas simples si o si

                this.comando.Connection = this.conexion;
                
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if(filasAfectadas == 1 ) 
                {
                    retorno = true;
                }
            }
            catch
            {
                // Handle exceptions if needed
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }

        public bool ModificarDato(Deportista deportista)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@cadena", deportista.Nombre);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "update dato set cadena = @cadena , entero = @entero where id = @id" 
                this.comando.Connection = this.conexion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch
            {
                // Handle exceptions if needed
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
    }
}
