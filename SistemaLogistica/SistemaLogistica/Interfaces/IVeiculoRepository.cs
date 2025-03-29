using SistemaLogistica.Entities;

namespace SistemaLogistica.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<IEnumerable<Veiculo>> GetAll();
        Task<Veiculo> GetById(int id);
        Task<Veiculo> Add(Veiculo veiculo);
        Task<Veiculo> Update(Veiculo veiculo);
        Task Delete(int id);
    }
}
