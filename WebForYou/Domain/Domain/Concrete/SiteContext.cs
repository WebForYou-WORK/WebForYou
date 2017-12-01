using System.Data.Entity;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection") { }
    }
   public class SiteContext : Context
    {
        public virtual DbSet<SliderOfWork> SliderOfWorks { get; set; }
        public virtual DbSet<OrderSite> OrderSites { get; set; }
        public virtual DbSet<CalcSite> CalcSites { get; set; }
    }
    public class BlogContext : Context
    {
        public virtual DbSet<Blog> Blogs { get; set; }
    }


 
}
