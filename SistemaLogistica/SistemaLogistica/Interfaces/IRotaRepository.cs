using SistemaLogistica.Entities;

namespace SistemaLogistica.Interfaces
{
    public interface IRotaRepository
    {
        Task<IEnumerable<Rota>> GetAll();
        Task<Rota> GetById(int id);
        Task<Rota> Add(Rota rota);
        Task<Rota> Update(Rota rota);
        Task Delete(int id);
    }
}
