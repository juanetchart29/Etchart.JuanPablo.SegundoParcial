using Etchart.JuanPablo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatos
    {
        public SqlCommand comando;//con este objeto realizo las querys
        private SqlConnection conexion;// se encarga de conectarse con el motor de la base de datos
        private static string cadena_conexion;
        private SqlDataReader lector;//contiende lo que me devuelve la consulta sql
        public List<Escalada> listaEscalada;
        public List<Voley> listaVoley;
        public List<Atletismo> listaAtletismo;
        
        static AccesoDatos()
        {
            //seteo mi cadena de conexion
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection(AccesoDatos.cadena_conexion);

            this.listaEscalada = new List<Escalada>();
            this.listaAtletismo = new List<Atletismo>();
            this.listaVoley = new List<Voley>();

            this.ActualizarListas();

        }
        public void ActualizarListas()
        {
            this.listaEscalada = this.TraerDatos<Escalada>();
            this.listaVoley = this.TraerDatos<Voley>();
            this.listaAtletismo = this.TraerDatos<Atletismo>();
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

            //designo lo que le voy a pedir generico para un deportista
            // como aca tengo que traer los datos voy a traer todo entonces no hace falta en este caso hacerlo asi, ahora tengo que tener en eucneta que en mi anteriori programa estaba eliminando los datos y volviendo a crearlos en vez de actualizarlos ahora tengo que actualizarlos usando las propiedades
            string tipoDeDato = typeof(T).Name;
            switch(tipoDeDato)
            {
                case "Escalada":

                    this.comando.CommandText = "SELECT * from Escalada";
                    break;
                case "Voley":
                    Voley voley= new Voley();
                    this.comando.CommandText = "SELECT * from Voley";
                    break;
                case "Atletismo":
                    Atletismo atletismo = new Atletismo();
                    this.comando.CommandText = "SELECT * from Atletismo";
                    break;
            }
            try
            {
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                //this.comando.ExecuteNonQuery(); estas para agregar datos a sql, no retorno
                this.lector = this.comando.ExecuteReader();//consultas de tipo select

                while (lector.Read()) //siempre que tengascosas para leer
                {
                    T deportista = new T();
                    this.AsignarAtributosDeportista(deportista as Deportista);

                    if (tipoDeDato == "Escalada")
                    {
                        this.AsignarAtributosEscalada(deportista as Escalada);
                    }
                    else if (tipoDeDato == "Voley")
                    {
                        this.AsignarAtributosVoley(deportista as Voley);
                    }
                    else if (tipoDeDato == "Atletismo")
                    {
                        this.AsignarAtributosAtletismo(deportista as Atletismo);
                    }
                    lista.Add(deportista);
                }
                this.lector.Close();
            }
            catch (Exception ex) 
            {
            
            }
            finally 
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
        public void AsignarAtributosEscalada(Escalada deportista)
        {
            deportista.Grado = (string)this.lector["grado"];
            deportista.Modalidad = (string)this.lector["modalidad"];
            deportista.Categoria = (string)this.lector["categoria"];
        }
        public void AsignarAtributosAtletismo(Atletismo deportista) 
        {
            deportista.Categoria = (string)this.lector["categoria"];
            deportista.Disciplina = (string)this.lector["disciplina"];

        }
        public void AsignarAtributosVoley(Voley deportista)
        {
            deportista.Posicion = (string)this.lector["posicion"];
     
            deportista.Altura = (float)this.lector.GetDouble(9);

            deportista.PartidosJugados = (int)this.lector.GetInt32(10);
            deportista.Categoria = (string)this.lector["categoria"];
        }
        public void AsignarAtributosDeportista(Deportista deportista)
        {
            deportista.id = this.lector.GetInt32(0);

            deportista.Nombre = (string)this.lector["nombre"];
            deportista.Apellido = (string)this.lector["apellido"];
            deportista.Edad = this.lector.GetInt32(3);
            deportista.Dni = (string)this.lector["dni"];
            deportista.Genero = (string)this.lector["genero"];
            deportista.AptoMedico = (bool)this.lector.GetBoolean(6);
            deportista.Federado = (bool)this.lector.GetBoolean(7);
        }
        public bool AgregarDato(Deportista deportista)
        {
            bool retorno = false;
            try
            {

                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                AsignarParametrosDeportista(deportista);
                if (deportista is Escalada)
                {
                    AsignarParametrosEscalada((Escalada)deportista);
                    this.listaEscalada.Add((Escalada)deportista);
                    this.comando.CommandText = "INSERT into Escalada (nombre,apellido,edad,dni,aptoMedico,federado,genero,grado,categoria,modalidad) " +
                    "VALUES (@nombre, @apellido, @edad, @dni, @aptoMedico, @federado, @genero,@grado,@categoria,@modalidad)";
                }
                else if (deportista is Voley) 
                {
                    AsignarParametrosVoley((Voley)deportista);
                    this.listaVoley.Add((Voley)deportista);
                    this.comando.CommandText = "INSERT into Voley (nombre,apellido,edad,dni,aptoMedico,federado,genero,posicion,altura,partidosJugados,categoria) " +
                    "VALUES (@nombre, @apellido, @edad, @dni, @aptoMedico, @federado, @genero,@posicion,@altura,@partidosJugados,@categoria)";
                }
                else if (deportista is Atletismo)
                {
                    AsignarParametrosAtletismo((Atletismo)deportista);
                    this.listaAtletismo.Add((Atletismo)deportista);
                    this.comando.CommandText = "INSERT into Atletismo (nombre,apellido,edad,dni,aptoMedico,federado,genero,categoria,disciplina) " +
                    "VALUES (@nombre, @apellido, @edad, @dni, @aptoMedico, @federado, @genero,@categoria,@disciplina)";
                }

                this.comando.Connection = this.conexion;
                
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if(filasAfectadas == 1 ) 
                {
                    retorno = true;
                }
            }
            catch   ( Exception e )
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
                this.comando.CommandText = "update dato set cadena = @cadena , entero = @entero where id = @id";
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
