using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;
using PSIMP.Infrastructure.IOC;
using PSIMP.Application.Interface;
using PSIMP.Business.Interface;
using PSIMP.Infrastructure.BasicRepository;
using PSIMP.Repository;
using PSIMP.Application.Implement;
using Microsoft.Practices.Unity.InterceptionExtension;
using Microsoft.Practices.Unity;

namespace PSIMP.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SetupConfig.Setup();
            IUnityContainer container = GetUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        private IUnityContainer GetUnityContainer()
        {
            //Create UnityContainer          
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container.RegisterType<IControllerActivator, CustomControllerActivator>();
            #region 应用层
            container.RegisterType<IDeptService, DeptService>(new HttpContextLifetimeManager<IDeptService>(), new Interceptor<InterfaceInterceptor>());
            #endregion 
            #region 底层业务
            container.RegisterType<IDeptRepository, DeptRepository>(new HttpContextLifetimeManager<IDeptRepository>())
            .RegisterType<IEmployeeRepository, EmployeeRepository>(new HttpContextLifetimeManager<IEmployeeRepository>());
            #endregion 
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HttpContextLifetimeManager<IUnitOfWork>())
            .RegisterType<IDBFactory, DBFactory>(new HttpContextLifetimeManager<IDBFactory>());

            return container;
        }
    }
}