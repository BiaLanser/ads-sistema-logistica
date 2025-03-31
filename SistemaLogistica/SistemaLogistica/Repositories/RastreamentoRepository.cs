using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Data;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Repositories
{
    public class RastreamentoRepository : IRastreamentoRepository
    {
        private readonly DefaultContext _context;

        public RastreamentoRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Rastreamento> Add(Rastreamento rastreamento)
        {
            _context.Rastreamentos.Add(rastreamento);
            await _context.SaveChangesAsync();
            return rastreamento;
        }

        public async Task Delete(int id)
        {
            var rastreamento = await _context.Rastreamentos.FindAsync(id);
            if (rastreamento != null)
            {
                _context.Rastreamentos.Remove(rastreamento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Rastreamento>> GetAll()
        {
            return await _context.Rastreamentos.ToListAsync();
        }

        public async Task<Rastreamento> GetById(int id)
        {
            return await _context.Rastreamentos.FindAsync(id);
        }

        public async Task<Rastreamento> Update(Rastreamento rastreamento)
        {
            _context.Rastreamentos.Update(rastreamento);
            await _context.SaveChangesAsync();
            return rastreamento;
        }
    }
}
