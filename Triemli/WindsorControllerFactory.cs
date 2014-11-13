using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Triemli
{
    public class WindsorControllerFactory : System.Web.Mvc.DefaultControllerFactory, IControllerFactory
    {
        private static Castle.MicroKernel.IKernel _kernel;

        public static Castle.MicroKernel.IKernel Kernel
        {
            get
            {
                if (_kernel == null)
                {
                    throw new ArgumentNullException("Set Kernel in WindsorControllerFactory.");
                }
                return _kernel;
            }
            set { _kernel = value; }
        }

        public virtual bool CanHandle(RequestContext request)
        {
            try
            {
                var controllerName = request.RouteData.Values["controller"] as String;
                var controllerType = GetControllerType(request, controllerName);
                return Kernel.HasComponent(controllerType);
            }
            catch
            {
                return false;
            }
        }

        public override System.Web.Mvc.IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType = GetControllerType(requestContext, controllerName);
            return (System.Web.Mvc.IController)Kernel.Resolve(controllerType);
        }


        public override void ReleaseController(System.Web.Mvc.IController controller)
        {
            Kernel.ReleaseComponent(controller);
        }
    }
}