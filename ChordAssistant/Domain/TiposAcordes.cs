using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public static class TiposAcordes
    {
        public static TipoAcorde Mayor { get; } = new TipoAcorde(0, 4, 7);
        public static TipoAcorde Menor { get; } = new TipoAcorde(1, 3, 7);
        public static TipoAcorde Disminuido { get; } = new TipoAcorde(2, 3, 6);

        // Añadir acordes con séptimas

        public static List<TipoAcorde> ListaTipoAcordes = new List<TipoAcorde> { Mayor, Menor, Disminuido };
    }
}
