using ApiCorridas.Models;
using ApiCorridas.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorridas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoCorridasController : ControllerBase
    {
        private readonly IHistoricoCorridasService _historicoCorridasService;

        public HistoricoCorridasController(IHistoricoCorridasService historicoCorridasService)
        {
            _historicoCorridasService = historicoCorridasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var res = _historicoCorridasService.SelecionaTodasCorridas();
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
                var res = _historicoCorridasService.SelecionaUmaCorrida(id);
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HistoricoCorrida model)
        {
            try
            {
                var res = await _historicoCorridasService.AdicionarCorrida(model);
                return Ok(model);

                if (res)
                    return Ok(model);
                else
                    return BadRequest(model);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] HistoricoCorrida model)
        {
            {
                try
                {
                    var res = await _historicoCorridasService.AlterarCorrida(id, model);

                    if (res)
                        return Ok(model);
                    else
                        return BadRequest(model);
                }
                catch
                {
                    return BadRequest();
                }
            }
        }

        [Route("ListaCompetidoresTempoMedio"), HttpGet]
        public IActionResult ListaCompetidoresTempoMedio()
        {
            try
            {
                var res = _historicoCorridasService.ListaCompetidoresTempoMedio();
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("ListaTodasPistasUtilizadas"), HttpGet]
        public IActionResult ListaTodasPistasUtilizadas()
        {
            try
            {
                var res = _historicoCorridasService.ListaTodasPistasUtilizadas();
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("ListaCompetidoresSemCorrida"), HttpGet]
        public IActionResult ListaCompetidoresSemCorrida()
        {
            try
            {
                var res = _historicoCorridasService.ListaCompetidoresSemCorrida();
                return Ok(res);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
