using Microsoft.EntityFrameworkCore;

namespace Cadastro_Contatos.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ContatosModel> Contatos { get; set; }
    }
}
