using ApiCorridas.Models;
using ApiCorridas.Services;
using ApiCorridas.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http.Routing;

namespace ApiCorridas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetidoresController : ControllerBase
    {
        private readonly ICompetidoresService _competidoresService;

        public CompetidoresController(ICompetidoresService competidoresService)
        {
            _competidoresService = competidoresService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var res = _competidoresService.SelecionaTodosCompetidores();

                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var res = _competidoresService.SelecionaUmCompetidor(id);
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Competidor competidor)
        {
            try
            {
                var res = await _competidoresService.AdicionarCompetidor(competidor);
                return Ok(competidor);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Competidor competidor)
        {
            try
            {
                var res = await _competidoresService.AlterarCompetidor(id, competidor);
                return Ok(competidor);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var res = await _competidoresService.ExcluirCompetidor(id);
                return Ok(id);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
