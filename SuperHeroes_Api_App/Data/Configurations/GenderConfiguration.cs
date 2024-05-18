using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.Id);
            builder.ToTable("gender"); 
            builder.Property(g => g.Id).HasColumnName("id");
            builder.Property(g => g.GenderName).HasColumnName("gender");  

            builder.HasMany(g => g.Superheroes).WithOne(s => s.Gender).HasForeignKey(s => s.GenderId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
