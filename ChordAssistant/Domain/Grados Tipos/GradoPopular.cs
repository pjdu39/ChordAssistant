using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class GradoPopular : IGrado
    {
        public short Id { get; private set; }
        public string Nombre { get; private set; }
        public short PosicionRelativa { get; private set; }
        public Area Area { get; private set; }
        public short Importancia { get; private set; }

        public GradoPopular()
        {
        }

        private GradoPopular(short id, string nombre, short posicionRelativa, Area area, short importancia)
        {
            Id = id;
            Nombre = nombre;
            PosicionRelativa = posicionRelativa;
            Area = area;
            Importancia = importancia;
        }

        public IGrado Create(short id, string nombre, short posicionRelativa)
        {
            Id = (short)(id % 7);
            Nombre = nombre;
            PosicionRelativa = (short)(posicionRelativa % 12);

            switch (id)
            {
                case 0:
                    Area = Areas.Tonica;
                    Importancia = 2;
                    break;
                case 1:
                    Area = Areas.Subdominante;
                    Importancia = 1;
                    break;
                case 2:
                    Area = Areas.Tonica;
                    Importancia = 0;
                    break;
                case 3:
                    Area = Areas.Subdominante;
                    Importancia = 2;
                    break;
                case 4:
                    Area = Areas.Dominante;
                    Importancia = 2;
                    break;
                case 5:
                    Area = Areas.Tonica;
                    Importancia = 1;
                    break;
                case 6:
                    Area = Areas.Dominante;
                    Importancia = 1;
                    break;
            }

            var result = new GradoPopular(Id, Nombre, PosicionRelativa, Area, Importancia);

            return result;
        }
    }
}
