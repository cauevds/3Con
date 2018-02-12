using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Teste3Con.Controle;
using Teste3Con.Entidade;

namespace TestesUnidade3Con
{
    [TestClass]
    public class UnitTest1
    {
        IController iController = new Controller();

        [TestMethod]
        public void ObterAmigos()
        {
            var amigos = iController.BuscarAmigos();
            Assert.IsNotNull(amigos, "Não foi possível obter lista de Amigos da API");
        }

        [TestMethod]
        public void CalcularDistanciaCartesiana()
        {
            double MinhaLatitude = 300;
            double MinhaLongitudo = 100;
            double AmigoLatitude = 500;
            double AmigoLongitude = 200;

            var calcDistanciaCartesiana = iController.CalcularDistanciaCartesiana(MinhaLatitude, MinhaLongitudo, AmigoLatitude, AmigoLongitude);
            Assert.AreEqual(223, calcDistanciaCartesiana, 1);
        }
        
        [TestMethod]
        public void ObtemLatLongPorId()
        {
            var latLong = iController.ObterLatLongPorId(1);
            Assert.IsNotNull(latLong, "Não foi possível obter Latitude e Longitudo da API");
        }

        [TestMethod]
        public void ObterTresAmigosMaisProximos()
        {
           
            var ListaTeste = new List<Amigo>();
            var Teste = (new Amigo { Id = 8, Nome = "Joao", Localizacao = new Localizacao { Latitude = 400, Longitude = 400 } });
            Teste.AmigosProximos = new List<Amigo>();
            Teste.AmigosProximos.Add(new Amigo { Id = 11, Nome = "Lucas", Localizacao = new Localizacao { Latitude = 100, Longitude = 100 }, Distancia = 424.26406871192853 });
            Teste.AmigosProximos.Add(new Amigo { Id = 9, Nome = "Italo", Localizacao = new Localizacao { Latitude = 200, Longitude = 200 }, Distancia = 282.842712474619 });
            Teste.AmigosProximos.Add(new Amigo { Id = 10, Nome = "Jose", Localizacao = new Localizacao { Latitude = 300, Longitude = 300 }, Distancia = 141.42135623730951 });
            Teste.AmigosProximos.Add(new Amigo { Id = 12, Nome = "Marcos", Localizacao = new Localizacao { Latitude = 510, Longitude = 510 }, Distancia = 155.56349186104046 });
         

            ListaTeste.Add(Teste);
            var resultado = iController.ObterTresMaisProximos(ListaTeste);
            Assert.AreEqual(3, resultado[0].AmigosProximos.Count, 0);
            Assert.AreEqual(resultado[0].AmigosProximos[0].Nome, "Jose");
            Assert.AreEqual(resultado[0].AmigosProximos[1].Nome, "Marcos");
            Assert.AreEqual(resultado[0].AmigosProximos[2].Nome, "Italo");
        }        
    }
}
