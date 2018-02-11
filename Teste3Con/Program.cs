using System;
using System.Linq;
using Teste3Con.Controle;

namespace Teste3Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var todosAmigos = new Controller().BuscarAmigos();
            foreach (var amigo in todosAmigos)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Amigos mais próximos de "+ amigo.Nome);
                foreach (var amg in amigo.AmigosProximos)
                {
                    Console.WriteLine("-"+amg.Nome);
                }
                
            }
            Console.ReadKey();

        }
    }
}


//Buscar via paralelismo a localização dos amigos

//Para cada amigo, buscar os três mais pertos
////Fazer o calculo de subtração para ver qual esta mais perto

