using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class SuperpowerConfiguration : IEntityTypeConfiguration<Superpower>
    {
        public void Configure(EntityTypeBuilder<Superpower> builder)
        {
            // Setting up the primary key
            builder.HasKey(sp => sp.Id);

            // Mapping to the table
            builder.ToTable("superpower");

            // Mapping properties
            builder.Property(sp => sp.Id).HasColumnName("id");
            builder.Property(sp => sp.PowerName).HasColumnName("power_name");

            // Configuring the one-to-many relationship with HeroPowers
            builder.HasMany(sp => sp.HeroPowers)
                   .WithOne(hp => hp.Superpower)
                   .HasForeignKey(hp => hp.PowerId)
                   .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as necessary
        }
    }
}
