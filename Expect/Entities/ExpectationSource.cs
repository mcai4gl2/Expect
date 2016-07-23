using System;
using System.Collections.Generic;

namespace Expect.Entities
{
    public class ExpectationSource
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedUtc { get; set; }
        public string Environment { get; set; }
        public string System { get; set; }
        public string Component { get; set; }
        public IReadOnlyCollection<string> Tags { get; set; }
    }
}
