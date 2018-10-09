using System;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IocField.Ioc;

namespace IocField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			var container = new WindsorContainer();

	        container.AddFacility<TypedFactoryFacility>();
	        container.Register(Component.For<ISubworkerComponentFactory>().AsFactory());
	        container.Register(Component.For<IMainService>().ImplementedBy<MainService>());
	        container.Register(Component.For<ISubworker>().ImplementedBy<Subworker>().LifestyleTransient());

	        var service = container.Resolve<IMainService>();

			for (int i = 0; i < 10; i++)
	        {
		        service.DoOneJob();
	        }

	        Console.ReadLine();
        }
    }
}
