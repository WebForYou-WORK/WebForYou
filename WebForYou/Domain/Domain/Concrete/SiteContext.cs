using System.Data.Entity;
using Domain.Entityes;
using Domain.Entityes.Modules;

namespace Domain.Concrete
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection") { }
    }

   public class SliderContext : Context
    {
        public virtual DbSet<SliderOfWork> SliderOfWorks { get; set; }
    }

    public class OrderContext : Context
    {
        public virtual DbSet<OrderSite> OrderSites { get; set; }
    }

    public class SharesContext : Context
    {
        public virtual DbSet<Shares> Shareses { get; set; }
    }

    public class CalcCorporateWebsiteContext : Context
    {
       public virtual DbSet<CorporateWebsiteCalc> CorporateWebsiteCalcs { get; set; }
    }

    public class CalcLendingContext : Context
    {
        public virtual DbSet<LandingCalc> LandingCalcs { get; set; }
    }

    public class CalcNewsPortalContext : Context
    {
        public virtual DbSet<NewsPortalCalc> NewsPortalCalcs { get; set; }
    }

    public class CalcShopContext : Context
    {
        public virtual DbSet<ShopCalc> ShopCalcs { get; set; }
    }

    public class CalcSiteCatalogContext : Context
    {
        public virtual DbSet<SiteCatalogCalc> CatalogCalcs { get; set; }
    }

    public class CalcWebsiteCardContext : Context
    {
        public virtual DbSet<WebsiteCardCalc> WebsiteCardCalcs { get; set; }
    }

    public class BlogContext : Context
    {
        public virtual DbSet<Blog> Blogs { get; set; }
    }

    public class BlogPhotoContext : Context
    {
        public virtual DbSet<BlogPhoto> BlogPhotos { get; set; }
    }

 
}
