using GestaoReceitas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }


        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Users> Users { get; set; }
    }

    
}
