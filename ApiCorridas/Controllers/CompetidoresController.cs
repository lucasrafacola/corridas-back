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

                Response.StatusCode = StatusCodes.Status200OK;
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var res = _competidoresService.SelecionaUmCompetidor(id);
                Response.StatusCode = StatusCodes.Status200OK;
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public int Adicionar([FromBody] Competidor model)
        {
            _competidoresService.AdicionarCompetidor(model);
            var response = Response.StatusCode = StatusCodes.Status201Created;
            return response;
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
