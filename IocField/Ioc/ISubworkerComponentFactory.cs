using System;

namespace IocField.Ioc
{
    public interface ISubworkerComponentFactory : IDisposable
    {
	    ISubworker Create();
	    void Release(ISubworker dummyComponent);
	}
}
