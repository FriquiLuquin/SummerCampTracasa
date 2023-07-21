using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ErrorBaseDatosException : Exception
    {
        public DateTime FechaHoraExcepcion { get; set; }

        public ErrorBaseDatosException(string mensaje, DateTime fechaHoraExcepcion) : base(mensaje)
        {
            FechaHoraExcepcion = fechaHoraExcepcion;
        }
    }
}
