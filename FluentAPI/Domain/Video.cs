using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Domain
{
    public class Video
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GenderId { get; set; }

        public int Classification { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
