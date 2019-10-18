using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TreinamentoWeb.Database;
using TreinamentoWeb.DTO;

namespace TreinamentoWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class PessoaController : Controller
    {
        [HttpGet]
        public IActionResult BuscarPessoas()
        {
            List<PessoaDTO> pessoas = new List<PessoaDTO>();

            pessoas.Add(new PessoaDTO
            {
                Id = 1,
                Nome = "Gabigol",
                Link = "https://twitter.com/gabigol"
            });

            return Ok(pessoas);
        }

        [HttpGet("banco")]
        public IActionResult BuscarPessoasBanco()
        {
            var context = new Context();
            var dbSet = context.Set<PessoaDTO>();
            List<PessoaDTO> pessoas = dbSet.ToList();

            return Ok(pessoas);
        }
    }
}
