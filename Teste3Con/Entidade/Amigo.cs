using System;
using System.Collections.Generic;
using System.Text;

namespace Teste3Con.Entidade
{
    public class Amigos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Localizacao Localizacao { get; set; }
        public List<Amigos> AmigosProximos { get; set; }
    }
}
