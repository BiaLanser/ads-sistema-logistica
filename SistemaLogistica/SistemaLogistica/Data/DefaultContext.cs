using Microsoft.EntityFrameworkCore;

namespace SistemaLogistica.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

        //public DbSet<Veiculo> Veiculos
        //{ get; set; }
    }
}
