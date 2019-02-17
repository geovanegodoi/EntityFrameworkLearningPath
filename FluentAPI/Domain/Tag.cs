using System.Collections.Generic;

namespace FluentAPI.Domain
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public virtual ICollection<Video> Videos { get; set; } = new HashSet<Video>();
    }
}