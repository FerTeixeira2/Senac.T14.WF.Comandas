

using Microsoft.EntityFrameworkCore;
using static Exercício_C_.Classe_Usuario;

namespace Exercício_C_
{
    internal class AppDbContext
    {
        public class Usuario : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder
           optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Exercicio.db");
            }
        }

    }
}
