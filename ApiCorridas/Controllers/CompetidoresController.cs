using ApiCorridas.Models;
using ApiCorridas.Services;
using ApiCorridas.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
        public IResult Get()
        {
            var res = _competidoresService.SelecionaTodosCompetidores();
            return Results.Ok(res);
        }

        [HttpGet("{id}")]
        public IResult Get(int id)
        {
            var res = _competidoresService.SelecionaUmCompetidor(id);
            return Results.Ok(res);
        }

        [HttpPost]
        public IResult Adicionar([FromBody] Competidor model)
        {
            var res = _competidoresService.AdicionarCompetidor(model);
            return Results.Ok(res);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
