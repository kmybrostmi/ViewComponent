using Microsoft.EntityFrameworkCore;

namespace ViewComponentSample.Model.Context;
public class VCDbContext : DbContext
{
    public DbSet<News> News { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Persist Security Info=False;User ID=sa;Initial Catalog=ViewComponentDb ;Data Source=.; Password=12; MultipleActiveResultSets=true; Encrypt=False");
    }
}
