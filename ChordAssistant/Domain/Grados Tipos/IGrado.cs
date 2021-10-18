using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public interface IGrado
    {
        public short Id { get; }
        public string Nombre { get; }
        public short PosicionRelativa { get; }
        public Area Area { get; }
        public short Importancia { get; }

        public IGrado Create(short id, string nombre, short posicionRelativa) { return this; }
    }
}
