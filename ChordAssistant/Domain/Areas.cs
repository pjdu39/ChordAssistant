using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public static class Areas
    {
        public static Area Tonica { get; } = new Area(0, "Tónica");
        public static Area Subdominante { get; } = new Area(1, "Subdominante");
        public static Area Dominante { get; } = new Area(2, "Dominante");

        public static List<Area> ListaAreas = new List<Area> { Tonica, Subdominante, Dominante };
    }
}
