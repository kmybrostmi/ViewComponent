using Microsoft.AspNetCore.Mvc;
using ViewComponentSample.Model.Context;

namespace ViewComponentSample.Components;

public class FirstBaseClassView:ViewComponent
{
    private readonly VCDbContext _vCDbContext;

    public FirstBaseClassView(VCDbContext vCDbContext)
    {
        _vCDbContext = vCDbContext;
    }

    public string Invoke()
    {
        string newsDescription = _vCDbContext.News.Where(c => c.Id == 2).FirstOrDefault().Description;
        return newsDescription;
    }
}

