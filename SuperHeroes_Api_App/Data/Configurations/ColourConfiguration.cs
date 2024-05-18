using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class ColourConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasKey(c => c.Id); 
            builder.ToTable("colour");  
            builder.Property(c => c.Id).HasColumnName("id");  
            builder.Property(c => c.ColourName).HasColumnName("colour");

            builder.HasMany(c => c.EyeColours).WithOne(s => s.EyeColour).HasForeignKey(s => s.EyeColourId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(c => c.HairColours).WithOne(s => s.HairColour).HasForeignKey(s => s.HairColourId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(c => c.SkinColours).WithOne(s => s.SkinColour).HasForeignKey(s => s.SkinColourId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
