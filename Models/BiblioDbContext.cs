using Microsoft.EntityFrameworkCore;

namespace Biblio.Models
{
    public class BiblioDbContext : DbContext
    {
        // Constructor for DbContext
        public BiblioDbContext(DbContextOptions<BiblioDbContext> options) : base(options)
        {
        }


        // Pas de DbSet pour l'instant


    }
}
