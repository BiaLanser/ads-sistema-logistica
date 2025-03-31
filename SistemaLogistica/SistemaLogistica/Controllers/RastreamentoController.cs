using Microsoft.AspNetCore.Mvc;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RastreamentoController : ControllerBase
    {
        private readonly IRastreamentoRepository _rastreamentoRepository;

        public RastreamentoController(IRastreamentoRepository rastreamentoRepository)
        {
            _rastreamentoRepository = rastreamentoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rastreamento>>> GetAll()
        {
            return Ok(await _rastreamentoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rastreamento>> GetById(int id)
        {
            var rastreamento = await _rastreamentoRepository.GetById(id);
            if (rastreamento == null) return NotFound();
            return Ok(rastreamento);
        }

        [HttpPost]
        public async Task<ActionResult<Rastreamento>> Add(Rastreamento rastreamento)
        {
            var createdRastreamento = await _rastreamentoRepository.Add(rastreamento);
            return CreatedAtAction(nameof(GetById), new { id = createdRastreamento.Id }, createdRastreamento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Rastreamento rastreamento)
        {
            if (id != rastreamento.Id) return BadRequest();
            await _rastreamentoRepository.Update(rastreamento);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _rastreamentoRepository.Delete(id);
            return NoContent();
        }
    }
}
