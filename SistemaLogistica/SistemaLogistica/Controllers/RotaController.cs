using Microsoft.AspNetCore.Mvc;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotaController : ControllerBase
    {
        private readonly IRotaRepository _rotaRepository;

        public RotaController(IRotaRepository rotaRepository)
        {
            _rotaRepository = rotaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rota>>> GetAll()
        {
            return Ok(await _rotaRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rota>> GetById(int id)
        {
            var rota = await _rotaRepository.GetById(id);
            if (rota == null) return NotFound();
            return Ok(rota);
        }

        [HttpPost]
        public async Task<ActionResult<Rota>> Add(Rota rota)
        {
            var createdRota = await _rotaRepository.Add(rota);
            return CreatedAtAction(nameof(GetById), new { id = createdRota.Id }, createdRota);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Rota rota)
        {
            if (id != rota.Id) return BadRequest();
            await _rotaRepository.Update(rota);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _rotaRepository.Delete(id);
            return NoContent();
        }
    }
}
