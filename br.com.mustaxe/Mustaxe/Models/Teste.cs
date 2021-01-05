using System;
using System.Collections.Generic;

namespace Mustaxe.Models
{
    public class Teste
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Idade { get; set; }
        public string[] Documentos { get; set; }
    }

    public class TesteList
    {
        public List<Teste> TesteLista { get; set; }
    }
}
