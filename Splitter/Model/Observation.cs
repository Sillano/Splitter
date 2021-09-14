using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model
{
    public class Observation
    {
        public long Id { get; set; }

        public long ObservatorId { get; set; }

        public long ObservatedId { get; set; }

        public DateTime Created { get; set; }
    }
}
