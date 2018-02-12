using System;
using System.Collections.Generic;
using System.Text;

namespace Teste3Con.Entidade
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Distancia { get; set; }
        public Localizacao Localizacao { get; set; }
        public List<Amigo> AmigosProximos { get; set; }
    }
}
