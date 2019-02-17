using FluentAPI.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Context.Configurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            ToTable("Videos");

            HasKey(k => k.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(p => p.Genre)
                .WithMany(p => p.Videos)
                .HasForeignKey(p => p.GenderId);

            HasMany(p => p.Tags)
                .WithMany(p => p.Videos)
                .Map(m => 
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });
        }
    }
}
