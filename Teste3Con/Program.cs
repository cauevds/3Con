using System;
using System.Collections.Generic;
using Teste3Con.Controle;
using Teste3Con.Entidade;

namespace Teste3Con
{
    class Program
    {
        static void Main(string[] args)
        {
            IController iController = new Controller();
            List<Amigo> listaAmigos = new List<Amigo>();
            try
            {
                listaAmigos = iController.BuscarAmigos();
                listaAmigos.ForEach(x => x.Localizacao = iController.ObterLatLongPorId(x.Id));
                var listaAmigosComDistancia = iController.CalcularDistanciaDosAmigos(listaAmigos);
                var listaAmigosMaisProximos = iController.ObterTresMaisProximos(listaAmigosComDistancia);
                Apresentar(listaAmigosMaisProximos);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os amigos mais próximos - Detalhes: " + ex);
            }           
        }

        private static void Apresentar(List<Amigo> listaAmigosMaisProximos)
        {
            foreach (var amigo in listaAmigosMaisProximos)
            {
                Console.WriteLine("Amigos mais próximos de " + amigo.Nome);
                foreach (var amg in amigo.AmigosProximos)
                {
                    Console.WriteLine("-" + amg.Nome);
                }
                Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}

