using System;
using System.Diagnostics.CodeAnalysis;

namespace CoRDependencyInjection.Tests.TestItems
{
    [ExcludeFromCodeCoverage]
    public class AnotherFirstHandler : BaseHandler, ITestChain
    {
        private readonly TestSingleton _singleton;

        public AnotherFirstHandler(ITestChain next, TestSingleton singleton)
        {
            _next = next;
            _singleton = singleton;
        }

        public override Type Handle()
        {
            return base.Handle();
        }

        public TestSingleton GetSingleton()
        {
            return _singleton;
        }
    }
}