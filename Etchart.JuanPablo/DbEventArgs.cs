using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DbEventArgs: EventArgs
    {
        public string mensajeOkey {  get; }
        public string mensajeError {  get; }
        public string mensajeExcepcion {  get; }

        public DbEventArgs()
        {
            this.mensajeError = "No se han podido Realizar los cambios en la base de datos";
            this.mensajeOkey = "Se han Realizado los cambios en la base de datos";
        }
        public DbEventArgs(string mensajeExcepcion):this() 
        {
            this.mensajeExcepcion = mensajeExcepcion;
        }
    }
}
