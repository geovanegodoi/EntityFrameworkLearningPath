using FluentAPI.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FluentAPI.Context.Configurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            ToTable("Genres");

            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
