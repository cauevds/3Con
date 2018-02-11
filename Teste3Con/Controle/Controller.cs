using System;
using System.Collections.Generic;
using Teste3Con.Dados;
using Teste3Con.Entidade;
using System.Linq;
namespace Teste3Con.Controle
{
    public class Controller
    {
        private IObtemAmigos iObtemAmigos;

        public List<Amigos> BuscarAmigos()
        {
            var amigos = new List<Amigos>();
            iObtemAmigos = new ObtemAmigos();

            amigos = CalcularDistanciaDosAmigos(iObtemAmigos.ObterAmigo());
            return OrdernaListaPorDistancia(amigos);
            
        }

        private List<Amigos> CalcularDistanciaDosAmigos(List<Amigos> ListaAmigos)
        {           
            List<Amigos> CopiaListaAmigos = ListaAmigos;

            foreach (var amigo in ListaAmigos)
            {
                amigo.AmigosProximos = new List<Amigos>();
                foreach (var OutroAmg in CopiaListaAmigos)
                {
                    if (amigo.Id != OutroAmg.Id)
                    {
                        OutroAmg.Distancia = CalcularDistanciaCartesiana(amigo.Localizacao.Latitude, amigo.Localizacao.Longitude, OutroAmg.Localizacao.Latitude, OutroAmg.Localizacao.Longitude);

                        amigo.AmigosProximos.Add(new Amigos {Id= OutroAmg.Id,Nome = OutroAmg.Nome, Distancia = OutroAmg.Distancia, Localizacao = OutroAmg.Localizacao });
                    }
                }               

            }
            return ListaAmigos;
        }
        private double CalcularDistanciaCartesiana(double origemLat, double origemLong, double destinoLat, double destinoLong)
        {
            return System.Math.Sqrt(System.Math.Pow((destinoLat - origemLat), 2) + System.Math.Pow((destinoLong - origemLong), 2));
        }

        private List<Amigos> OrdernaListaPorDistancia(List<Amigos> todosAmigos)
        {
            foreach (var amg in todosAmigos)
            {
                amg.AmigosProximos = (from a in amg.AmigosProximos
                               orderby a.Distancia ascending
                               select a).Take(3).ToList();
            }
            return todosAmigos;
        }
       
    }
}
