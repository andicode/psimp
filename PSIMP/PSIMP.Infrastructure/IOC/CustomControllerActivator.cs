using System;
using System.Web.Mvc;
namespace PSIMP.Infrastructure.IOC
{
    public class CustomControllerActivator : IControllerActivator
    {        
        IController IControllerActivator.Create(
            System.Web.Routing.RequestContext requestContext,
            Type controllerType)
        {
            return DependencyResolver.Current
                .GetService(controllerType) as IController;
        }      
    }
}