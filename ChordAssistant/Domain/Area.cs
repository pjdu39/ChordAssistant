using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class Area
    {
        public short Id { get; }
        public string Nombre { get; }

        public Area(short id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
