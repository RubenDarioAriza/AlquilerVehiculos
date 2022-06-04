using System;
using System.Collections.Generic;

namespace Enty
{
    public class Vehiculo
    {
        public List<string> VehiPlaca { get; set; }
        public List<string> DescripVehi { get; set; }
        public List<int> KiloInicial { get; set; }

        public Vehiculo(List<string> Placa, List<string> Descripcion, List<int> KilometroInicial)
        {
            VehiPlaca = Placa;
            DescripVehi = Descripcion;
            KiloInicial = KilometroInicial;

        }

    }
}
