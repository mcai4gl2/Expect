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
}
