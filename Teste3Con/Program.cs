using System;
using Teste3Con.Controle;

namespace Teste3Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var todosAmigos = new Controller().BuscarAmigos();
            foreach (var item in todosAmigos)
            {
                Console.WriteLine(item);

            }
            
            
        }
    }
}


//Buscar via paralelismo a localização dos amigos

//Para cada amigo, buscar os três mais pertos
////Fazer o calculo de subtração para ver qual esta mais perto

