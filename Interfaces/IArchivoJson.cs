using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IArchivoJson : IArchivo
    {
        public void Deserializar();
        public void Serializar();
    }
}
