using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class HeroAttributeConfiguration : IEntityTypeConfiguration<HeroAttribute>
    {
        public void Configure(EntityTypeBuilder<HeroAttribute> builder)
        {
            // Setting up the composite key
            builder.HasKey(ha => new { ha.HeroId, ha.AttributeId });

            // Mapping to the table
            builder.ToTable("hero_attribute");

            // Mapping properties
            builder.Property(ha => ha.HeroId).HasColumnName("hero_id");
            builder.Property(ha => ha.AttributeId).HasColumnName("attribute_id");
            builder.Property(ha => ha.AttributeValue).HasColumnName("attribute_value");

            // Configuring the relationships
            builder.HasOne(ha => ha.Superhero)
                   .WithMany(s => s.HeroAttributes)
                   .HasForeignKey(ha => ha.HeroId)
                   .OnDelete(DeleteBehavior.Cascade);  // Assuming Cascade is appropriate, adjust if needed

            builder.HasOne(ha => ha.Attribute)
                   .WithMany(a => a.HeroAttributes)
                   .HasForeignKey(ha => ha.AttributeId)
                   .OnDelete(DeleteBehavior.Cascade);  // Assuming Cascade is appropriate, adjust if needed
        }
    }
}
