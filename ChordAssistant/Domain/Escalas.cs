using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class Escalas
    {
        public static Escala Mayor { get; private set; }
        public static Escala Dorica { get; private set; }
        public static Escala Frigia { get; private set; }
        public static Escala Lidia { get; private set; }
        public static Escala Mixolidia { get; private set; }
        public static Escala Menor { get; private set; }
        public static Escala Locria { get; private set; }

        public List<Escala> ListaEscalas { get; private set; }

        public Escalas(IGrado grado)
        {
            Mayor = new Escala(0, "Mayor", new Grados(0, 2, 4, 5, 7, 9, 11, grado));        
            Dorica = new Escala(1, "Dórica", new Grados(0, 2, 3, 5, 7, 9, 10, grado));
            Frigia = new Escala(2, "Frigia", new Grados(0, 1, 3, 5, 7, 8, 10, grado));
            Lidia = new Escala(3, "Lidia", new Grados(0, 2, 4, 6, 7, 9, 11, grado));
            Mixolidia = new Escala(4, "Mixolidia", new Grados(0, 2, 4, 5, 7, 9, 10, grado));
            Menor = new Escala(5, "Menor", new Grados(0, 2, 3, 5, 7, 8, 10, grado));
            Locria = new Escala(6, "Locria", new Grados(0, 1, 3, 5, 6, 8, 10, grado));

            FillListaEscalas();
        }

        public Escala GetEscala(EscalasEnum e)
        {
            return ListaEscalas.Where(x => x.Id == (short)e).FirstOrDefault();
        }

        private void FillListaEscalas()
        {
            ListaEscalas = new List<Escala> { Mayor, Dorica, Frigia, Lidia, Mixolidia, Menor, Locria };
        }
    }
}
