using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.Dados
{
    public class ObtemLatLongPorId
    {       
        //Mock
        public Localizacao ObterLatLongPorId(int id)
        {
            Random random = new Random();
            return (new Localizacao
            {
                Latitude = random.NextDouble() * id,
                Longitude = random.NextDouble() * id - 10
            });
        }
    }
}
