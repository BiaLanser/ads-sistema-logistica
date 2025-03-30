using Microsoft.AspNetCore.Mvc;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristaController : ControllerBase
    {
        private readonly IMotoristaRepository _motoristaRepository;

        public MotoristaController(IMotoristaRepository motoristaRepository)
        {
            _motoristaRepository = motoristaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motorista>>> GetAll()
        {
            return Ok(await _motoristaRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Motorista>> GetById(int id)
        {
            var motorista = await _motoristaRepository.GetById(id);
            if (motorista == null) return NotFound();
            return Ok(motorista);
        }

        [HttpPost]
        public async Task<ActionResult<Motorista>> Add(Motorista motorista)
        {
            var createdMotorista = await _motoristaRepository.Add(motorista);
            return CreatedAtAction(nameof(GetById), new { id = createdMotorista.Id }, createdMotorista);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Motorista motorista)
        {
            if (id != motorista.Id) return BadRequest();
            await _motoristaRepository.Update(motorista);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _motoristaRepository.Delete(id);
            return NoContent();
        }
    }
}
