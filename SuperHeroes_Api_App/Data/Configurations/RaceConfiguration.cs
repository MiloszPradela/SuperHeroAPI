using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            // Setting up the primary key
            builder.HasKey(r => r.Id);

            // Mapping to the table
            builder.ToTable("race");

            // Mapping properties
            builder.Property(r => r.Id).HasColumnName("id");
            builder.Property(r => r.RaceName).HasColumnName("race");

            builder.HasMany(r => r.Superheroes)
                   .WithOne(s => s.Race)
                   .HasForeignKey(s => s.RaceId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
