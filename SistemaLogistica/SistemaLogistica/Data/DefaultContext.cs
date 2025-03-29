using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Entities;

namespace SistemaLogistica.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<Rastreamento> Rastreamentos { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
    }
}

