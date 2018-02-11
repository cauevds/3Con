using System;
using System.Linq;
using Teste3Con.Controle;

namespace Teste3Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new Controller().BuscarAmigos();
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

