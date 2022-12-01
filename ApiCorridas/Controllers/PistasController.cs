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
    public class PistasController : ControllerBase
    {
        private readonly IPistasService _pistasService;

        public PistasController(IPistasService pistasService)
        {
            _pistasService = pistasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var res = _pistasService.SelecionaTodasPistas();
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
                var res = _pistasService.SelecionaUmaPista(id);
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pista model)
        {
            try
            {
                var res = await _pistasService.AdicionarPista(model);
                return Ok(model);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Pista model)
        {
            try
            {
                var res = await _pistasService.AlterarPista(id, model);
                return Ok(model);
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
                var res = await _pistasService.ExcluirPista(id);
                return Ok(id);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
