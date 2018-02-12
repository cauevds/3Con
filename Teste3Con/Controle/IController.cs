using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.Controle
{
    public interface IController
    {
        List<Amigo> BuscarAmigos();
        List<Amigo> CalcularDistanciaDosAmigos(List<Amigo> ListaAmigos);
        double CalcularDistanciaCartesiana(double origemLat, double origemLong, double destinoLat, double destinoLong);
        List<Amigo> ObterTresMaisProximos(List<Amigo> todosAmigos);
    }
}
