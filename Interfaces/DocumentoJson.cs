using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class DocumentoJson : IArchivoJson
    {
        public string NombreArchivo { get; set; }

        public DocumentoJson(string nombreArchivo) 
        {
            NombreArchivo = nombreArchivo;
        }

        public void Deserializar()
        {
            throw new NotImplementedException();
        }

        public void Serializar()
        {
            throw new NotImplementedException();
        }
    }
}
