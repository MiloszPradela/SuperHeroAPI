using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            // Setting up the primary key
            builder.HasKey(p => p.Id);

            // Mapping to the table
            builder.ToTable("publisher");

            // Mapping properties
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.PublisherName).HasColumnName("publisher_name");

            builder.HasMany(p => p.Superheroes)
                   .WithOne(s => s.Publisher)
                   .HasForeignKey(s => s.PublisherId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
