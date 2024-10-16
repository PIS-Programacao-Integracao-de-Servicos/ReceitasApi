using Microsoft.EntityFrameworkCore;
using GestaoReceitas.Domain.Entities;
namespace GestaoReceitas.Infrastructure.Data
{
    internal class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
