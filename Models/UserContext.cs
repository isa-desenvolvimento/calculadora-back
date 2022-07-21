using Microsoft.EntityFrameworkCore;

namespace calculadora_api.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<ChequeEmpresarial> ChequeEmpresarial { get; set; }
        public DbSet<ParceladoPre> ParceladoPre { get; set; }
        public DbSet<Indice> Indice { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Pastas> Pastas { get; set; }
    }
}