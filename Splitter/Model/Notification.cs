using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model
{
    using Microsoft.AspNetCore.Mvc;

    public class Notification
    {
        public long Id { get; set; }

        public NotificationReason Reason { get; set; }

        public string Description { get; set; }

        public Cause[] Causes { get; set; }

        public DateTime Created { get; set; }

        public bool HasBeenSeen { get; set; }

        public long? ReferenceId { get; set; }

        public bool HasReference => this.ReferenceId != null;
    }
}
