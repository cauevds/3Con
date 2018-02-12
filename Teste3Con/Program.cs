using System;
using System.Collections.Generic;
using System.Linq;
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

            listaAmigos = iController.BuscarAmigos();
            listaAmigos = iController.CalcularDistanciaDosAmigos(listaAmigos);
            listaAmigos = iController.ObterTresMaisProximos(listaAmigos);

            foreach (var amigo in listaAmigos)
            {
                Console.WriteLine("Amigos mais próximos de "+ amigo.Nome);
                foreach (var amg in amigo.AmigosProximos)
                {
                    Console.WriteLine("-"+amg.Nome);
                }
                Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}

