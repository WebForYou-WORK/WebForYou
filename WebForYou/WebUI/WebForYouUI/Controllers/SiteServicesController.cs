using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstrac.Modules;

namespace WebForYouUI.Controllers
{
    public class SiteServicesController : Controller
    {
        private readonly IWebsiteCardCalc _websiteCardCalc;
        private readonly ILandingCalc _landingCalc;
        private readonly ISiteCatalogCalc _siteCatalogCalc;
        private readonly IShopCalc _shopCalc;
        private readonly ICorporateWebsiteCalc _corporateWebsiteCalc;
        private readonly INewsPortalCalc _newsPortalCalc;

        public SiteServicesController(IWebsiteCardCalc websiteCardCalc, ILandingCalc landingCalc, ISiteCatalogCalc catalogCalc, 
            IShopCalc shopCalc, ICorporateWebsiteCalc corporateWebsiteCalc, INewsPortalCalc newsPortalCalc)
        {
            _websiteCardCalc = websiteCardCalc;
            _landingCalc = landingCalc;
            _siteCatalogCalc = catalogCalc;
            _shopCalc = shopCalc;
            _corporateWebsiteCalc = corporateWebsiteCalc;
            _newsPortalCalc = newsPortalCalc;
        }
        public ViewResult WebsiteCard()
        {
            return View(_websiteCardCalc.CalcWebsiteCardSites);
        }
        public ViewResult LandingPage()
        {
            return View(_landingCalc.CalcLendingSites);
        }
        public ViewResult SiteCatalog()
        {
            return View(_siteCatalogCalc.CalcCatalogSites);
        }
        public ViewResult OnlineStore()
        {
            return View(_shopCalc.CalcShopSites);
        }
        public ViewResult CorporateWebsite()
        {
            return View(_corporateWebsiteCalc.CalcCorporateSites);
        }
        public ViewResult NewsPortal()
        {
            return View(_newsPortalCalc);
        }
    }
}