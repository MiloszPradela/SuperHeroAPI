using Microsoft.EntityFrameworkCore;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<Attributee> Attributes { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<HeroAttribute> HeroAttributes { get; set; }
        public DbSet<HeroPower> HeroPowers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<Superpower> SuperPowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
