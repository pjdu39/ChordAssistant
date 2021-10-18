using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    // La propiedad Grado contiene la información de los intervalos entre notas.
    public class Escala
    {
        public short Id { get; }
        public string Nombre { get; }
        public Grados Grados { get; }

        public Escala(short idEscala, string nombre, Grados grados)
        {
            Id = idEscala;
            Nombre = nombre;
            Grados = grados;
        }
    }
}
