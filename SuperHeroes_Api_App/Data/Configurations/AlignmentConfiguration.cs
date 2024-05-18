using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class AlignmentConfiguration : IEntityTypeConfiguration<Alignment>
    {
        public void Configure(EntityTypeBuilder<Alignment> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.ToTable("alignment");
            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.AlignmentName).HasColumnName("alignment");
       
        }
    }
}
