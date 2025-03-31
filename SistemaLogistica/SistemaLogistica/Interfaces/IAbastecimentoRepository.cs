using SistemaLogistica.Entities;

namespace SistemaLogistica.Interfaces
{
    public interface IAbastecimentoRepository
    {
        Task<IEnumerable<Abastecimento>> GetAll();
        Task<Abastecimento> GetById(int id);
        Task<Abastecimento> Add(Abastecimento abastecimento);
        Task<Abastecimento> Update(Abastecimento abastecimento);
        Task Delete(int id);
    }
}
