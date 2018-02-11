using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.Dados
{
    public class ObtemAmigos : IObtemAmigos
    {
        public List<Amigos> ObterAmigo()
        {
            var ListaAmigos = new List<Amigos>();
            ListaAmigos.Add(new Amigos { Id = 1, Nome = "Antonio", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 2, Nome = "Bruno", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 3, Nome = "Carlos", Localizacao =null});
            ListaAmigos.Add(new Amigos { Id = 4, Nome = "Dario", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 5, Nome = "Edson", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 6, Nome = "Felipe", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 7, Nome = "Geraldo", Localizacao = null});
            ListaAmigos.Add(new Amigos { Id = 8, Nome = "Henrique", Localizacao= null});

            return ListaAmigos;
        }
        
    }
}
