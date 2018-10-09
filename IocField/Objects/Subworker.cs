using System;
using System.Threading;

namespace IocField.Ioc
{
    public class Subworker : ISubworker
    {
	    private int _id;

	    public Subworker()
	    {
			_id = new Random().Next();
	    }

	    public void DoJob()
	    {
			Console.WriteLine($"doing something ...{_id}");
			Thread.Sleep(2000);
	    }
    }
}
