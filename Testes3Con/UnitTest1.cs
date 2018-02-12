using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste3Con.Controle;

namespace Testes3Con
{
    [TestClass]
    public class UnitTest1
    {
        IController iController = new Controller();

        [TestMethod]
        public void ObterAmigos()
        {
            var amigos = iController.BuscarAmigos();
            Assert.(223, CalcDistanciaCartesiana, 0);
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


    }
}
