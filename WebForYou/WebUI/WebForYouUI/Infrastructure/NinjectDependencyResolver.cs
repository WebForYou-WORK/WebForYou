using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Abstrac;
using Domain.Abstrac.Modules;
using Domain.Concrete;
using Domain.Concrete.Modules;
using WebForYouUI.Infrastructure.Abstract;
using WebForYouUI.Infrastructure.Concrete;
using Ninject;

namespace WebForYouUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IAuthProvider>().To<FormAuthProvider>();
            _kernel.Bind<IBlogPhotoRepossitory>().To<EfBlogPhotoRepossitory>();
            _kernel.Bind<IBlogRepository>().To<EfBlogRepository>();
            _kernel.Bind<IOrderSite>().To<EfOrderSite>();
            _kernel.Bind<ISliderOfWoks>().To<EfSliderOfWoks>();
            _kernel.Bind<ICorporateWebsiteCalc>().To<EfCorporateWebsiteCalc>();
            _kernel.Bind<ILandingCalc>().To<EfLandingCalc>();
            _kernel.Bind<INewsPortalCalc>().To<EfNewsPortalCalc>();
            _kernel.Bind<IShopCalc>().To<EfShopCalc>();
            _kernel.Bind<ISiteCatalogCalc>().To<EfSiteCatalogCalc>();
            _kernel.Bind<IWebsiteCardCalc>().To<EfWebsiteCardCalc>();
            _kernel.Bind<IShares>().To<EfShares>();
        }
    }
}