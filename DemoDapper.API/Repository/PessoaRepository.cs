using Dapper;
using DemoDapper.API.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.API.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Pessoa> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);

            var pessoa = connection.Query<Pessoa>("SELECT * FROM Pessoa");

            return pessoa;
        }

        public int Insert(Pessoa pessoa)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "INSERT INTO Pessoa(Nome, Idade) VALUES (@nome, @idade)";

            var result = connection.Execute(query, new { nome = pessoa.Nome, idade = pessoa.Idade });

            return result;
        }


    }
}
