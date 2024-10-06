using Npgsql.EntityFrameworkCore;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class DungeonResourceContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceDescriptionFeature> RaceDescriptions { get; set; }
        public DbSet<RaceMechanicFeature> RaceMechanics { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassDescriptionFeature> ClassDescriptions { get; set; }
        public DbSet<ClassMechanicFeature> ClassMechanics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Database=CharacterResources;Username=postgres;Password=1234");

} 
}
