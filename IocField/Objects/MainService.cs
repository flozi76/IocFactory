namespace IocField.Ioc
{
    public class MainService : IMainService
    {
	    private readonly ISubworkerComponentFactory _componentFactory;

	    public MainService(ISubworkerComponentFactory componentFactory)
	    {
		    _componentFactory = componentFactory;
	    }

	    public void DoOneJob()
	    {
		    var subworker = _componentFactory.Create();
			subworker.DoJob();
			_componentFactory.Release(subworker);
	    }
    }
}