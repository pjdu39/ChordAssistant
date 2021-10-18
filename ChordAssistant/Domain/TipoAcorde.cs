using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class TipoAcorde
    {
        public short Id { get; }
        public short Tercera { get; }
        public short Quinta { get; }
        public short? Septima { get; }

        public TipoAcorde(short id, short tercera, short quinta)
        {
            Id = id;
            Tercera = tercera;
            Quinta = quinta;
        }

        public TipoAcorde(short id, short tercera, short quinta, short septima)
        {
            Id = id;
            Tercera = tercera;
            Quinta = quinta;
            Septima = septima;
        }
    }
}
