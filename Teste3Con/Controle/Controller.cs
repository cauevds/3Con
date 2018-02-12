﻿using System;
using System.Collections.Generic;
using Teste3Con.Dados;
using Teste3Con.Entidade;
using System.Linq;
namespace Teste3Con.Controle
{
    public class Controller : IController
    {
        private IObtemAmigos iObtemAmigos;

        public List<Amigo> BuscarAmigos()
        {           
            iObtemAmigos = new ObtemAmigos();
            return iObtemAmigos.ObterAmigo();
        }

        public List<Amigo> CalcularDistanciaDosAmigos(List<Amigo> ListaAmigos)
        {           
            List<Amigo> CopiaListaAmigos = ListaAmigos;

            foreach (var amigo in ListaAmigos)
            {
                amigo.AmigosProximos = new List<Amigo>();
                foreach (var OutroAmg in CopiaListaAmigos)
                {
                    if (amigo.Id != OutroAmg.Id)
                    {
                        OutroAmg.Distancia = CalcularDistanciaCartesiana(amigo.Localizacao.Latitude, amigo.Localizacao.Longitude, OutroAmg.Localizacao.Latitude, OutroAmg.Localizacao.Longitude);

                        amigo.AmigosProximos.Add(new Amigo {Id= OutroAmg.Id,Nome = OutroAmg.Nome, Distancia = OutroAmg.Distancia, Localizacao = OutroAmg.Localizacao });
                    }
                }               

            }
            return ListaAmigos;
        }
        public double CalcularDistanciaCartesiana(double origemLat, double origemLong, double destinoLat, double destinoLong)
        {
            return System.Math.Sqrt(System.Math.Pow((destinoLat - origemLat), 2) + System.Math.Pow((destinoLong - origemLong), 2));
        }

        public List<Amigo> ObterTresMaisProximos(List<Amigo> todosAmigos)
        {
            foreach (var amg in todosAmigos)
            {
                amg.AmigosProximos = (from a in amg.AmigosProximos
                               orderby a.Distancia ascending
                               select a).Take(3).ToList();
            }
            return todosAmigos;
        }

        public Localizacao ObterLatLongPorId(int id)
        {
            ObtemLatLongPorId obter = new ObtemLatLongPorId();
            return obter.ObterLatLongPorId(id);
        }
       
    }
}
