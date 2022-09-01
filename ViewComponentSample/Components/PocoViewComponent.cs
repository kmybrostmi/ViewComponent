using ViewComponentSample.Model.Context;

namespace ViewComponentSample.Components;
public class PocoViewComponent
{
	private readonly VCDbContext _vCDbContext;

	public PocoViewComponent(VCDbContext vCDbContext)
	{
        _vCDbContext = vCDbContext;
	}

	public string Invoke()
	{
		string newsDescription = _vCDbContext.News.Where(c => c.Id == 3).FirstOrDefault().Description;
		return newsDescription;

    }
}
