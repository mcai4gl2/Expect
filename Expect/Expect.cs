using System;
using Expect.Entities;

namespace Expect
{
    public static class Expect
    {
        private static IExpectCollector _collector = null;

        public static void SetUp(IExpectCollector collector)
        {
            _collector = collector;
        }

        public static ExpectationSource New(long id, string name, string environment = "", string system = "",
            string component = "", params string[] tags)
        {
            return new ExpectationSource
            {
                Id = id,
                Name = name,
                CreatedUtc = DateTime.UtcNow,
                Environment = environment,
                System = system,
                Component = component,
                Tags = tags
            };
        }

        public static ExpectSource New(ExpectationSource source)
        {
            var expectSource = new ExpectSource(source);
            _collector?.CollectExpectSource(expectSource);
            return expectSource;
        }
    }

    public static class ExpectSourceExtensions
    {
        public static Expectation Creates(this ExpectSource expectSource, long id, string name, long correlationId = 0, long typeId = 0, string[] tags = null, DateTime? sla = null, DateTime? eta = null, string payload = null, string remark = null)
        {
            var expectation = new Expectation
            {
                Id = id,
                Name = name,
                CorrelationId = correlationId,
                TypeId = typeId,
                Tags = tags,
                CreatedUtc = DateTime.Now,
                Sla = sla,
                Eta = eta,
                IsMet = false,
                Payload = payload,
                Remark = remark,
                ExpectationSourceId = expectSource.ExpectationSource.Id
            };
            expectSource.Creates(expectation);
            return expectation;
        }
    }
}
