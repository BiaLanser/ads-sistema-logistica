using Microsoft.AspNetCore.Mvc;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbastecimentoController : ControllerBase
    {
        private readonly IAbastecimentoRepository _abastecimentoRepository;

        public AbastecimentoController(IAbastecimentoRepository abastecimentoRepository)
        {
            _abastecimentoRepository = abastecimentoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abastecimento>>> GetAll()
        {
            return Ok(await _abastecimentoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Abastecimento>> GetById(int id)
        {
            var abastecimento = await _abastecimentoRepository.GetById(id);
            if (abastecimento == null) return NotFound();
            return Ok(abastecimento);
        }

        [HttpPost]
        public async Task<ActionResult<Abastecimento>> Add(Abastecimento abastecimento)
        {
            var createdAbastecimento = await _abastecimentoRepository.Add(abastecimento);
            return CreatedAtAction(nameof(GetById), new { id = createdAbastecimento.Id }, createdAbastecimento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Abastecimento abastecimento)
        {
            if (id != abastecimento.Id) return BadRequest();
            await _abastecimentoRepository.Update(abastecimento);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _abastecimentoRepository.Delete(id);
            return NoContent();
        }
    }
}
