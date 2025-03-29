using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Data;
using SistemaLogistica.Entities;
using SistemaLogistica.Interfaces;

namespace SistemaLogistica.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly DefaultContext _context;

        public VeiculoRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Veiculo> Add(Veiculo veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
            await _context.SaveChangesAsync();
            return veiculo;
        }

        public async Task Delete(int id)
        {
            var veiculo = await GetById(id);
            if (veiculo != null)
            {
                _context.Veiculos.Remove(veiculo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Veiculo>> GetAll()
        {
            return await _context.Veiculos.ToListAsync();
        }

        public async Task<Veiculo> GetById(int id)
        {
            return await _context.Veiculos.FindAsync(id);
        }

        public async Task<Veiculo> Update(Veiculo veiculo)
        { 
            _context.Veiculos.Update(veiculo);
            await _context.SaveChangesAsync();
            return veiculo;
        }
    }
}
