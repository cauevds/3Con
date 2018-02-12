using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.Dados
{
    public class ObtemAmigos : IObtemAmigos
    {
        public List<Amigo> ObterAmigo()
        {
            var ListaAmigos = new List<Amigo>();
            ListaAmigos.Add(new Amigo { Id = 1, Nome = "Antonio"});
            ListaAmigos.Add(new Amigo { Id = 2, Nome = "Bruno"});
            ListaAmigos.Add(new Amigo { Id = 3, Nome = "Carlos"});
            ListaAmigos.Add(new Amigo { Id = 4, Nome = "Dario"});
            ListaAmigos.Add(new Amigo { Id = 5, Nome = "Edson"});
            ListaAmigos.Add(new Amigo { Id = 6, Nome = "Felipe"});
            ListaAmigos.Add(new Amigo { Id = 7, Nome = "Geraldo"});
            ListaAmigos.Add(new Amigo { Id = 8, Nome = "Henrique"});
            ListaAmigos.Add(new Amigo { Id = 9, Nome = "Italo"});
            ListaAmigos.Add(new Amigo { Id = 10, Nome = "Jose"});
            ListaAmigos.Add(new Amigo { Id = 11, Nome = "Lucas"});
            ListaAmigos.Add(new Amigo { Id = 12, Nome = "Marcos"});
            
            return ListaAmigos;
        }
        
    }
}
