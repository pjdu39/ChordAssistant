using ChordAssistant.Domain;
using ChordAssistant.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseChordController : ControllerBase
    {
        private readonly ILogger<BaseChordController> _logger;
        public BaseChordController(ILogger<BaseChordController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Encuentra el acorde de una tonalidad y un grado dados
        /// </summary>
        /// <param name="tono"></param>
        /// <param name="escala"></param>
        /// <param name="grado"></param>
        /// <returns>Devuelve un acorde y sus notas</returns>
        [HttpGet]
        [Route("/SingleChord")]
        public AcordeResponse GetSingleChord([FromQuery] NotasEnum tono, EscalasEnum escala, GradosEnum grado, EstilosEnum estilo)
        {
            var tonalidad = new Tonalidad(tono, escala, estilo);
            var response = tonalidad.GetAcorde(grado);
            return response;
        }

        /// <summary>
        /// Encuentra 4 acordes aleatorios dentro de la tonalidad indicada
        /// </summary>
        /// <param name="tono"></param>
        /// <param name="escala"></param>
        /// <param name="numAcordes"></param>
        /// <returns>Devuelve 4 acordes</returns>
        [HttpGet]
        [Route("/GetRandomChords")]
        public IEnumerable<AcordeResponse> GetRandomChords([FromQuery] NotasEnum tono, EscalasEnum escala, EstilosEnum estilo, int numAcordes)
        {
            var tonalidad = new Tonalidad(tono, escala, estilo);

            var r = new Random();

            var response = new List<AcordeResponse>();

            for(int i=0; i<numAcordes; i++)
            {
                response.Add(tonalidad.GetAcorde((GradosEnum)r.Next(0, 7)));
            }

            return response;
        }
    }
}
