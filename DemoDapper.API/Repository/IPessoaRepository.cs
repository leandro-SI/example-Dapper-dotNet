using DemoDapper.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.API.Repository
{
    public interface IPessoaRepository
    {
        public IEnumerable<Pessoa> ListAll();
        public int Insert(Pessoa pessoa);
    }
}
