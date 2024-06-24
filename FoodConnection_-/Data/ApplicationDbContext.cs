using FoodConnection__.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodConnection__.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        public DbSet<Puntaje> Puntajes { get; set; }

        public DbSet<Receta> Recetas { get; set; }
    }
}
