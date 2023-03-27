using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.API.Domain
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataRegistro { get; set; }

    }
}
