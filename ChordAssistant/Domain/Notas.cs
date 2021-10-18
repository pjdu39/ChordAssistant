using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public static class Notas
    {
        public static Nota Do { get; } = new Nota(0, "Si #", "Do", "");
        public static Nota DoS { get; } = new Nota(1, "Do #", "", "Re b");
        public static Nota Re { get; } = new Nota(2, "", "Re", "");
        public static Nota ReS { get; } = new Nota(3, "Re #", "", "Mi b");
        public static Nota Mi { get; } = new Nota(4, "", "Mi", "Fa b");
        public static Nota Fa { get; } = new Nota(5, "Mi #", "Fa", "");
        public static Nota FaS { get; } = new Nota(6, "Fa #", "", "Sol b");
        public static Nota Sol { get; } = new Nota(7, "", "Sol", "");
        public static Nota SolS { get; } = new Nota(8, "Sol #", "", "La b");
        public static Nota La { get; } = new Nota(9, "", "La", "");
        public static Nota LaS { get; } = new Nota(10, "La #", "", "Si b");
        public static Nota Si { get; } = new Nota(11, "", "Si", "Do b");

        public static List<Nota> ListaNotas { get; } = new List<Nota> { Do, DoS, Re, ReS, Mi, Fa, FaS, Sol, SolS, La, LaS, Si };
    }
}
