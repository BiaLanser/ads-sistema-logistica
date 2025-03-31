using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Data;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Repositories
{
    public class AbastecimentoRepository : IAbastecimentoRepository
    {
        private readonly DefaultContext _context;

        public AbastecimentoRepository(DefaultContext context)
        {
            _context = context;
        }
        public async Task<Abastecimento> Add(Abastecimento abastecimento)
        {
            _context.Abastecimentos.Add(abastecimento);
            await _context.SaveChangesAsync();
            return abastecimento;
        }

        public async Task Delete(int id)
        {
            var abastecimento = await _context.Abastecimentos.FindAsync(id);
            if (abastecimento != null)
            {
                _context.Abastecimentos.Remove(abastecimento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Abastecimento>> GetAll()
        {
            return await _context.Abastecimentos.ToListAsync();
        }

        public async Task<Abastecimento> GetById(int id)
        {
            return await _context.Abastecimentos.FindAsync(id);
        }

        public async Task<Abastecimento> Update(Abastecimento abastecimento)
        {
            _context.Abastecimentos.Update(abastecimento);
            await _context.SaveChangesAsync();
            return abastecimento;
        }
    }
}
