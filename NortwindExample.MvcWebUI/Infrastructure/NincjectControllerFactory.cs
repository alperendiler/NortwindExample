using Ninject;
using Ninject.Extensions.Interception.Infrastructure.Language;
using NortwindExample.Bll.Concrete;
using NortwindExample.CrossCuttingConcerns.Logging;
using NortwindExample.Dal.Concrete.EntitiyFrameWork;
using NortwindExample.Interfaces;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace NortwindExample.MvcWebUI.Infrastructure
{
    public class NincjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NincjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            //AddBllBindings();

            AddServiceBindings();
        }



        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal", new EfProductDal());

            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());

            _ninjectKernel.Bind<IAuthenticationService>().To<AuthenticationManager>().WithConstructorArgument("authenticationDal", new EfAuthenticationDal());

            _ninjectKernel.Intercept(p => (true)).With(new LoggingInterceptor());
        }

        private void AddServiceBindings()
        {
            _ninjectKernel.Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());

            _ninjectKernel.Bind<ICategoryService>().ToConstant(WcfProxy<ICategoryService>.CreateChannel());

            _ninjectKernel.Bind<IAuthenticationService>().ToConstant(WcfProxy<IAuthenticationService>.CreateChannel());

        }


        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)
                _ninjectKernel.Get(controllerType);
        }
    }
}