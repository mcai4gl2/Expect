using System;
using System.Diagnostics.Contracts;
using System.Reactive.Subjects;
using Expect.Entities;

namespace Expect
{
    public class ExpectSource : IExpectSource
    {
        private Subject<Expectation> _new = new Subject<Expectation>();
        private Subject<Expectation> _update = new Subject<Expectation>();
        private Subject<ExpectationSource> _clear = new Subject<ExpectationSource>();

        public ExpectationSource ExpectationSource { get; }
        public IObservable<Expectation> New => _new;
        public IObservable<Expectation> Update => _update;
        public IObservable<ExpectationSource> Clear => _clear; 

        public ExpectSource(ExpectationSource source)
        {
            Contract.Requires(source != null);
            ExpectationSource = source;
        }

        public void Creates(params Expectation[] expectations)
        {
            foreach (var expect in expectations)
                _new.OnNext(expect);
        }

        public void Updates(params Expectation[] expectations)
        {
            foreach (var expect in expectations)
                _update.OnNext(expect);
        }

        public void Clears()
        {
            _clear.OnNext(ExpectationSource);
        }
    }
}
