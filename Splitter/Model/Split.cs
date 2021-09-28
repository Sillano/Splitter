using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model
{
    using System.Text.RegularExpressions;

    using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

    public class Split
    {
        public long Id { get; set; }

        public string Content { get; set; }

        public long AuthorId { get; set; }

        public SplitType Type { get; set; }

        public long? ReferenceId { get; set; }

        public bool HasBeenEdited { get; set; }

        public DateTime Timestamp { get; set; }

        public bool IsValid()
        {
            var hasReferenceId = this.ReferenceId != null;

            return this.Type == SplitType.Normal ? !hasReferenceId : hasReferenceId;
        }

        public IEnumerable<string> GetTags()
        {
            const string pattern = @"#([\S]*)";

            var match = Regex.Match(this.Content, pattern);

            return match.Groups[0].Captures.Select(x => x.Value);
        }
    }
}
