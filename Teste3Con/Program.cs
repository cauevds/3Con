using System;
using System.Collections.Generic;
using System.Linq;
using Teste3Con.Controle;
using Teste3Con.Entidade;
using Teste3Con.Dados;

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
                listaAmigos = iController.CalcularDistanciaDosAmigos(listaAmigos);
                listaAmigos = iController.ObterTresMaisProximos(listaAmigos);

                foreach (var amigo in listaAmigos)
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
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os amigos mais próximos - Detalhes: " + ex);
            }           
        }
    }
}

