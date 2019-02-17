using FluentAPI.Context.Configurations;
using FluentAPI.Domain;
using System.Data.Entity;

namespace FluentAPI.Context
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() : base("name=PlutoConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new VideoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
