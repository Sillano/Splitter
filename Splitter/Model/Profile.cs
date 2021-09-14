using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model
{
    public class Profile
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string VisibleName { get; set; }

        public string CallSign { get; set; }

        public DateTime Created { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public ProfileStatus Status { get; set; }
    }
}
