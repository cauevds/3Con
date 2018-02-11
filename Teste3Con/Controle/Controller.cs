using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Dados;
using Teste3Con.Entidade;

namespace Teste3Con.Controle
{
    public class Controller
    {
        private IObtemAmigos _obtemAmigos;

        public List<Amigos> BuscarAmigos()
        {
            var amigos = new List<Amigos>();
            _obtemAmigos = new ObtemAmigos();

            amigos = _obtemAmigos.ObterAmigo();
            amigos.ForEach(x => x.Localizacao = new WebServiceObtemLatLongPorId().ObterLatLongPorId(x.Id));

            return amigos;
        }

        private List<Amigos> calculaAmigosProximos(List<Amigos> ListaAmigos)
        {

            return new List<Amigos>();
        }
    }
}
