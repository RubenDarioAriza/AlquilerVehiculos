using System;
using System.Collections.Generic;
using System.Text;

namespace Enty
{
    internal class Persona
    {
        public List<string> Nombre { get; set; }
        public List<string> TipoPersona { get; set; }
        public List<int> ID { get; set; }

        public Persona(List<string> NombreCliente, List<string> TipoCliente, List<int> Id)
        {
            Nombre = NombreCliente;
            TipoPersona = TipoCliente;
            ID = Id;

        }
        

        }
}
