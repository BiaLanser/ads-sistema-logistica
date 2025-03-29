using Microsoft.AspNetCore.Mvc;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetAll()
        {
            return Ok(await _veiculoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculo>> GetById(int id)
        {
            var veiculo = await _veiculoRepository.GetById(id);
            if (veiculo == null) return NotFound();
            return Ok(veiculo);
        }

        [HttpPost]
        public async Task<ActionResult<Veiculo>> Add(Veiculo veiculo)
        {
            var createdVeiculo = await _veiculoRepository.Add(veiculo);
            return CreatedAtAction(nameof(GetById), new { id = createdVeiculo.Id }, createdVeiculo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Veiculo veiculo)
        {
            if (id != veiculo.Id) return BadRequest();
            await _veiculoRepository.Update(veiculo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _veiculoRepository.Delete(id);
            return NoContent();
        }
    }
}
