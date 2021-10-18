using ChordAssistant.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Responses
{
    public class AcordeResponse
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public TiposAcordesEnum Tipo { get; set; }
        public string AreaTonal { get; set; }
        public short Importancia { get; set; }
        public List<Nota> Notas { get; set; }
    }
}
