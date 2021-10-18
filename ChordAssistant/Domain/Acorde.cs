using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    // TODO: Esta clase se va a encargar de devolver las notas contenidas en un acorde.
    public class Acorde
    {
        private readonly Nota _fundamental;
        private readonly TiposAcordesEnum _tipo;

        public Acorde(Nota fundamental, TiposAcordesEnum tipo)
        {
            _fundamental = fundamental;
            _tipo = tipo;
        }

        public List<Nota> CalculaNotas()
        {
            var tipo = TiposAcordes.ListaTipoAcordes.Where(x => x.Id == (short)_tipo).FirstOrDefault();

            var idFundamental = _fundamental.IdNota;
            var idTercera = idFundamental + tipo.Tercera;
            var idQuinta = idFundamental + tipo.Quinta;

            var result = new List<Nota>
            {
                GetNotaById(idFundamental),
                GetNotaById(idTercera),
                GetNotaById(idQuinta)
            };


            return result;
        }

        private Nota GetNotaById(int id)
        {
            id %= 12;
            return Notas.ListaNotas.Where(x => x.IdNota == id).FirstOrDefault();
        }
    }
}
