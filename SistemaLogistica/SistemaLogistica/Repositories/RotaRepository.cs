using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Data;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Repositories
{
    public class RotaRepository : IRotaRepository
    {
        private readonly DefaultContext _context;

        public RotaRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Rota> Add(Rota rota)
        {
            _context.Rotas.Add(rota);
            await _context.SaveChangesAsync();
            return rota;
        }

        public async Task Delete(int id)
        {
            var rota = await _context.Rotas.FindAsync(id); 
            if(rota != null)
            {
                _context.Rotas.Remove(rota);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Rota>> GetAll()
        {
            return await _context.Rotas.ToListAsync();
        }

        public async Task<Rota> GetById(int id)
        {
            return await _context.Rotas.FindAsync(id);
        }

        public async Task<Rota> Update(Rota rota)
        {
            _context.Rotas.Update(rota);
            await _context.SaveChangesAsync();
            return rota;
        }
    }
}
