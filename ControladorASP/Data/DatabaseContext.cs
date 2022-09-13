using ControladorASP.Models;
using Microsoft.EntityFrameworkCore;

namespace ControladorASP.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
