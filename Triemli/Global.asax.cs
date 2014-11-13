using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Triemli.Models.TriemliSpecificModels;
using Triemli.Models.TriemliSPecificModels;
using Triemli.Services;

namespace Triemli
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        public Castle.Windsor.IWindsorContainer Container { get; private set; }

        protected void Application_Start()
        {
            setUpCastle();
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void setUpCastle()
        {
            Container = InitializeContainer();
            WindsorControllerFactory.Kernel = Container.Kernel;

            RegisterComponents();
        }

        private Castle.Windsor.IWindsorContainer InitializeContainer()
        {
            var container = new Castle.Windsor.WindsorContainer();
            ControllerBuilder.Current.SetControllerFactory(typeof(WindsorControllerFactory));

            container.Register(
                                Classes.FromThisAssembly()
                                .InNamespace("Triemli", true)//////.InSameNamespaceAs<Partena.Logic>()
                                .LifestylePerWebRequest()                              
                                //////.LifestyleTransient()
                                .Configure(x => x.Named(x.Implementation.FullName))
                                );

            return container;
        }

        private void RegisterComponents()
        {
            Container.Register(Component.For(typeof(IAuthentication)).ImplementedBy(typeof(Authentication)).Named("authService"));
        }
    }
}