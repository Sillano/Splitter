using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model
{
    public class WallPost
    {
        public int Id { get; set; }

        public DateTimeOffset Created { get; set; } = DateTime.Now;

        public DateTimeOffset? LastUpdated { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public virtual int User { get; set; }

        public virtual string Content { get; set; }
    }
}