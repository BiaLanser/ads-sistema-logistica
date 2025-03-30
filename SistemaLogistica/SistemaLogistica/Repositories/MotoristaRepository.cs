using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Data;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        private readonly DefaultContext _context;

        public MotoristaRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Motorista>> GetAll()
        {
            return await _context.Motoristas.ToListAsync();
        }

        public async Task<Motorista> GetById(int id)
        {
            return await _context.Motoristas.FindAsync(id);
        }

        public async Task<Motorista> Add(Motorista motorista)
        {
            _context.Motoristas.Add(motorista);
            await _context.SaveChangesAsync();
            return motorista;
        }

        public async Task<Motorista> Update(Motorista motorista)
        {
            _context.Motoristas.Update(motorista);
            await _context.SaveChangesAsync();
            return motorista;
        }

        public async Task Delete(int id)
        {
            var motorista = await _context.Motoristas.FindAsync(id);
            if (motorista != null)
            {
                _context.Motoristas.Remove(motorista);
                await _context.SaveChangesAsync();
            }
        }
    }
}
