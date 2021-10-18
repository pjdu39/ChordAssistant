using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class Nota
    {
        public short IdNota { get; }
        public string NombreSostenido { get; }
        public string Nombre { get; }
        public string NombreBemol { get; }

        public Nota(short idNota, string nombreSostenido, string nombre, string nombreBemol)
        {
            IdNota = idNota;
            NombreSostenido = nombreSostenido;
            Nombre = nombre;
            NombreBemol = nombreBemol;
        }
    }
}
