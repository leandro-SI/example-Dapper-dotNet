using DemoDapper.API.Domain;
using DemoDapper.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(ILogger<PessoaController> logger, IPessoaRepository pessoaRepository)
        {
            _logger = logger;
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IActionResult GetAllPessoa()
        {
            try
            {
                var data = _pessoaRepository.ListAll();

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter os dados");
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public IActionResult SetPessoa([FromBody] Pessoa pessoa)
        {
            try
            {
                var result = _pessoaRepository.Insert(pessoa);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar inserir os dados");
                return new StatusCodeResult(500);
            }
        }

    }
}
