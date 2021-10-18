using ChordAssistant.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    public class Tonalidad
    {
        private readonly Nota _tono;
        private readonly Escala _escala;
        private readonly List<IGrado> _grados;

        public Tonalidad(NotasEnum notaTono, EscalasEnum escala, EstilosEnum estilo)
        {
            var idNotaTono = (short)notaTono;
            _tono = Notas.ListaNotas.Where(x => x.IdNota == idNotaTono).FirstOrDefault();
            IGrado tipoDeGrado;

            switch(estilo)
            {
                case EstilosEnum.Popular:
                    tipoDeGrado = new GradoPopular();
                    break;
                case EstilosEnum.Clasico:
                    tipoDeGrado = new GradoClasico();
                    break;
                default:
                    tipoDeGrado = new GradoPopular();
                    break;
            }

            _escala = new Escalas(tipoDeGrado).GetEscala(escala);
            _grados = _escala.Grados.GetGrados();
        }

        // Devuelve la nota base de un acorde en función del grado que pasas y la tonalidad de la clase
        public AcordeResponse GetAcorde(GradosEnum grado)
        {
            var miGrado = _grados
                .Where(x => x.Id == (short)grado)
                .FirstOrDefault();

            var intervalo = miGrado.PosicionRelativa;
            var areaTonal = miGrado.Area.Nombre;
            var importancia = miGrado.Importancia;

            // Calcula la fundamental dentro de una sola octava
            var idFundamental = (_tono.IdNota + intervalo) % 12;

            var fundamental = Notas.ListaNotas
                .Where(x => x.IdNota == idFundamental)
                .FirstOrDefault();

            var tipo = GetTipo(grado);

            // Calcula las notas que hay en el acorde
            var notasDelAcorde = new Acorde(fundamental, tipo).CalculaNotas();

            var result = new AcordeResponse
            {
                Id = fundamental.IdNota,
                Name = GetNombre(fundamental, grado),
                Tipo = tipo,
                AreaTonal = areaTonal,
                Importancia = importancia,
                Notas = notasDelAcorde
            };

            return result;
        }

        private TiposAcordesEnum GetTipo(GradosEnum grado)
        {
            var secuenciaJonica = new TiposAcordesEnum[]
            { 
                TiposAcordesEnum.M,
                TiposAcordesEnum.m,
                TiposAcordesEnum.m,
                TiposAcordesEnum.M,
                TiposAcordesEnum.M,
                TiposAcordesEnum.m,
                TiposAcordesEnum.Disminuido
            };

            var posicionDelArray = ((int)grado + _escala.Id) % 7;

            var result = secuenciaJonica[posicionDelArray];

            return result;
        }

        // Hay muchos casos que corregir. Por el momento se va a quedar así puesto que no es responsabilidad de la API elegir el nombre
        // adecuado para cada nota. La responsabilidad de la API es seleccionar el ID de nota correcto.
        private string GetNombre(Nota nota, GradosEnum grado)
        {
            // Caso especial donde no se debe priorizar la nota natural: Fa # Mayor VII grado 
            // Esto ocurre porque su armadura natural tiene 6 sostenidos. 
            if (_tono.IdNota == 6 && nota.IdNota == 5)
            {
                return nota.NombreSostenido;
            }
            else if (!string.IsNullOrEmpty(nota.Nombre))
            {
                return nota.Nombre;
            }
            else if (grado == GradosEnum.VII)
            {
                return nota.NombreSostenido;
            }
            else
            {
                var idTonoDeLaEscalaJonica = (_escala.Id + 7 - (int)grado) % 7;

                var sostenidosPorCirculoDeQuintas = new List<int> { 0, 7, 2, 9, 4, 11, 6 };

                // Si el tono transpotado a jónico forma parte de la primera mitad del círculo
                // de quintas, devuelve los sostenidos, y si no los bemoles
                return sostenidosPorCirculoDeQuintas.Contains(idTonoDeLaEscalaJonica) ? nota.NombreSostenido : nota.NombreBemol;
            }
        }
    }
}
