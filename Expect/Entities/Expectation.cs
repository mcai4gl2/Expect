using System;
using System.Collections.Generic;

namespace Expect.Entities
{
    public class Expectation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CorrelationId { get; set; }
        public long TypeId { get; set; }
        public IReadOnlyCollection<string> Tags { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? Sla { get; set; }
        public DateTime? Eta { get; set; }
        public bool IsMet { get; set; }
        public string Payload { get; set; }
        public string Remark { get; set; }
        public DateTime? MetUtc { get; set; }
        public long ExpectationSourceId { get; set; }
    }
}
