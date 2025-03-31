using SistemaLogistica.Entities;

namespace SistemaLogistica.Interfaces
{
    public interface IRastreamentoRepository
    {
        Task<IEnumerable<Rastreamento>> GetAll();
        Task<Rastreamento> GetById(int id);
        Task<Rastreamento> Add(Rastreamento rastreamento);
        Task<Rastreamento> Update(Rastreamento rastreamento);
        Task Delete(int id);
    }
}
