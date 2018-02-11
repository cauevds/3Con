using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.Dados
{
    public class WebServiceObtemLatLongPorId
    {
        public Localizacao ObterLatLongPorId(int id)
        {
            Random random = new Random();
            return (new Localizacao
            {
                Latitude = random.NextDouble(),
                Longitude = random.NextDouble()
            });
        }
    }
}
