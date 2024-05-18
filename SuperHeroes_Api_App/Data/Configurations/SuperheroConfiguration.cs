using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes_Api_App.Model;

namespace SuperHeroes_Api_App.Data.Configurations
{
    public class SuperheroConfiguration : IEntityTypeConfiguration<Superhero>
    {
        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            // Setting up the primary key
            builder.HasKey(s => s.Id);

            // Mapping to the table
            builder.ToTable("superhero");

            // Mapping properties
            builder.Property(s => s.Id).HasColumnName("id");
            builder.Property(s => s.SuperheroName).HasColumnName("superhero_name");
            builder.Property(s => s.FullName).HasColumnName("full_name");
            builder.Property(s => s.GenderId).HasColumnName("gender_id");
            builder.Property(s => s.EyeColourId).HasColumnName("eye_colour_id");
            builder.Property(s => s.HairColourId).HasColumnName("hair_colour_id");
            builder.Property(s => s.SkinColourId).HasColumnName("skin_colour_id");
            builder.Property(s => s.RaceId).HasColumnName("race_id");
            builder.Property(s => s.PublisherId).HasColumnName("publisher_id");
            builder.Property(s => s.AlignmentId).HasColumnName("alignment_id");
            builder.Property(s => s.HeightCm).HasColumnName("height_cm");
            builder.Property(s => s.WeightKg).HasColumnName("weight_kg");

            builder.HasOne(s => s.Gender)
                   .WithMany(g => g.Superheroes)
                   .HasForeignKey(s => s.GenderId);

            builder.HasOne(s => s.EyeColour)
                   .WithMany(c => c.EyeColours)
                   .HasForeignKey(s => s.EyeColourId);

            builder.HasOne(s => s.HairColour)
                   .WithMany(c => c.HairColours)
                   .HasForeignKey(s => s.HairColourId);

            builder.HasOne(s => s.SkinColour)
                   .WithMany(c => c.SkinColours)
                   .HasForeignKey(s => s.SkinColourId);

            builder.HasOne(s => s.Race)
                   .WithMany(r => r.Superheroes)
                   .HasForeignKey(s => s.RaceId);

            builder.HasOne(s => s.Publisher)
                   .WithMany(p => p.Superheroes)
                   .HasForeignKey(s => s.PublisherId);

            builder.HasOne(s => s.Alignment)
                   .WithMany(a => a.Superheroes)
                   .HasForeignKey(s => s.AlignmentId);

            // Configure indices if necessary (e.g., for performance optimization)
           //builder.HasIndex(s => s.SuperheroName).HasDatabaseName("IDX_SuperheroName");
        }
    }
}
