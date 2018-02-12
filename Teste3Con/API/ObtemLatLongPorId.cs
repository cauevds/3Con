using System;
using System.Collections.Generic;
using System.Text;
using Teste3Con.Entidade;

namespace Teste3Con.API
{
    public class ObtemLatLongPorId
    {       
        //Mock
        public Localizacao ObterLatLongPorId(int id)
        {
            Random random = new Random();
            return (new Localizacao
            {
                Latitude = random.Next() * id,
                Longitude = random.Next() * id - 10
            });
        }
    }
}
