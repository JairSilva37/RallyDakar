using Microsoft.AspNetCore.Mvc;
using RallyDakar.Dominio.Entidades;
using RallyDakar.Dominio.Interfaces;
using System.Collections.Generic;

namespace RallyDakar.API.Controllers
{
    [ApiController]
    [Route("api/pilotos")]
    public class PilotoController : Controller
    {
        IPilotoRepositorio _pilotoRepositorio;
        public PilotoController(IPilotoRepositorio pilotoRepositorio)
        {
            _pilotoRepositorio = pilotoRepositorio;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(_pilotoRepositorio.ObterTodos());
        }

        [HttpPost]
        public IActionResult AdicionarPiloto([FromBody] Piloto piloto)
        {
            _pilotoRepositorio.Adicionar(piloto);
            return Ok();
        }


        [HttpPut]
        public IActionResult AtualizarPiloto([FromBody] Piloto piloto)
        {
            return Ok();
        }

        [HttpPatch]
        public IActionResult AtualizarParcialmentePiloto([FromBody] Piloto piloto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPiloto(int id)
        {
            return Ok();
        }
    }
}
