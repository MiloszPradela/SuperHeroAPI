using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class AttributeeConfiguration : IEntityTypeConfiguration<Attributee>
    {
        public void Configure(EntityTypeBuilder<Attributee> builder)
        {
            builder.HasKey(a => a.Id);
            builder.ToTable("attribute");
            builder.Property(a => a.Id).HasColumnName("id"); 
            builder.Property(a => a.AttributeName).HasColumnName("attribute_name");  
        }
    }
}
