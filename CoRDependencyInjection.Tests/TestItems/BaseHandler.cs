using System;
using CoRDependencyInjection.Tests.TestItems;

public abstract class BaseHandler : ITestChain
{
    protected ITestChain _next;
    
    public virtual Type Handle()
    {
        return _next.Handle();
    }
}