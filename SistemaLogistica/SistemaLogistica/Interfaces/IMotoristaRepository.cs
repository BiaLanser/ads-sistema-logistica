using SistemaLogistica.Entities;

namespace SistemaLogistica.Interfaces
{
    public interface IMotoristaRepository
    {
        Task<IEnumerable<Motorista>> GetAll();
        Task<Motorista> GetById(int id);
        Task<Motorista> Add(Motorista motorista);
        Task<Motorista> Update(Motorista motorista);
        Task Delete(int id);
    }
}
