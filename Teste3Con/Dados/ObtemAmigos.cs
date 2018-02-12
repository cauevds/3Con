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
            ListaAmigos.Add(new Amigo { Id = 1, Nome = "Antonio", Localizacao = new Localizacao { Latitude = -0.300, Longitude = 23213} });
            ListaAmigos.Add(new Amigo { Id = 2, Nome = "Bruno", Localizacao = new Localizacao { Latitude = 3300, Longitude = -423213 } });
            ListaAmigos.Add(new Amigo { Id = 3, Nome = "Carlos", Localizacao = new Localizacao { Latitude = -44300, Longitude = 213 } });
            ListaAmigos.Add(new Amigo { Id = 4, Nome = "Dario", Localizacao = new Localizacao { Latitude = 0.3, Longitude = 233 } });
            ListaAmigos.Add(new Amigo { Id = 5, Nome = "Edson", Localizacao = new Localizacao { Latitude = -10322, Longitude = 43453 } });
            ListaAmigos.Add(new Amigo { Id = 6, Nome = "Felipe", Localizacao = new Localizacao { Latitude = 12300, Longitude = 432 } });
            ListaAmigos.Add(new Amigo { Id = 7, Nome = "Geraldo", Localizacao = new Localizacao { Latitude = 44300, Longitude = 555 } });
            ListaAmigos.Add(new Amigo { Id = 8, Nome = "Henrique", Localizacao = new Localizacao { Latitude = 4300, Longitude = 53 } });
            ListaAmigos.Add(new Amigo { Id = 9, Nome = "Italo", Localizacao = new Localizacao { Latitude = -600, Longitude = 998 } });
            ListaAmigos.Add(new Amigo { Id = 10, Nome = "Jose", Localizacao = new Localizacao { Latitude = -5000, Longitude = -4000 } });
            ListaAmigos.Add(new Amigo { Id = 11, Nome = "Lucas", Localizacao = new Localizacao { Latitude = -0.5588, Longitude = 0001 } });
            ListaAmigos.Add(new Amigo { Id = 12, Nome = "Marcos", Localizacao = new Localizacao { Latitude = -900, Longitude = -600 } });
            return ListaAmigos;
        }
        
    }
}
