using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ViewComponentSample.Model.Context;

namespace ViewComponentSample.Components;
public class NewsLists : ViewComponent
{
	private readonly VCDbContext _vCDbContext;
	[ViewComponentContext]
	public ViewComponentContext _ViewComponentContext { get; set; }

	public NewsLists(VCDbContext vCDbContext)
	{
		_vCDbContext = vCDbContext;
	}

	public IViewComponentResult Invoke(string viewName)
	{
		//ViewContext.
		//ViewComponentContext.
		var newsList = _vCDbContext.News.ToList();
		return View(viewName,newsList);
	}
}

