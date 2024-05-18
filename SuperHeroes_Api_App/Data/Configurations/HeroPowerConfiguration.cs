using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class HeroPowerConfiguration : IEntityTypeConfiguration<HeroPower>
    {
        public void Configure(EntityTypeBuilder<HeroPower> builder)
        {
            // Setting up the composite key
            builder.HasKey(hp => new { hp.HeroId, hp.PowerId });

            // Mapping to the table
            builder.ToTable("hero_power");

            // Mapping properties
            builder.Property(hp => hp.HeroId).HasColumnName("hero_id");
            builder.Property(hp => hp.PowerId).HasColumnName("power_id");

            // Configuring the relationships
            builder.HasOne(hp => hp.Superhero)
                   .WithMany(s => s.HeroPowers)
                   .HasForeignKey(hp => hp.HeroId)
                   .OnDelete(DeleteBehavior.Cascade);  

            builder.HasOne(hp => hp.Superpower)
                   .WithMany(p => p.HeroPowers)
                   .HasForeignKey(hp => hp.PowerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
