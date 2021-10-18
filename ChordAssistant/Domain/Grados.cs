using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class Grados
    {
        public IGrado I { get; private set; }
        public IGrado II { get; }
        public IGrado III { get; }
        public IGrado IV { get; }
        public IGrado V { get; }
        public IGrado VI { get; }
        public IGrado VII { get; }

        public Grados( short i, short ii, short iii, short iv, short v, short vi, short vii, IGrado grado)
        {
            I = grado.Create(0, "I", i);
            II = grado.Create(1, "II", ii);
            III = grado.Create(2, "III", iii);
            IV = grado.Create(3, "IV", iv);
            V = grado.Create(4, "V", v);
            VI = grado.Create(5, "VI", vi);
            VII = grado.Create(6, "VII", vii);
        }

        public List<IGrado> GetGrados()
        {
            return new List<IGrado> { I, II, III, IV, V, VI, VII };
        }
    }
}
