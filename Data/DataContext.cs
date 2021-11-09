using Microsoft.EntityFrameworkCore;
namespace PokemonWebApi.Models
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options)
        {
        }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Breed> Breeds { get; set; }



    }
}