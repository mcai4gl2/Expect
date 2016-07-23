using System;
using Expect.Entities;

namespace Expect
{
    public interface IExpectSource
    {
        ExpectationSource ExpectationSource { get; }
        IObservable<Expectation> New { get; }
        IObservable<Expectation> Update { get; }  
        IObservable<ExpectationSource> Clear { get; } 
    }
}
