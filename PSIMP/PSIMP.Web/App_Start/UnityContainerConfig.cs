using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using PSIMP.Application.Implement;
using PSIMP.Application.Interface;
using PSIMP.Business.Interface;
using PSIMP.Infrastructure.BasicRepository;
using PSIMP.Infrastructure.IOC;
using PSIMP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using PSIMP.Application.Interface.Person;
using PSIMP.Business.Interface.Person;
using PSIMP.Repository.Person;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(PSIMP.Web.UnityContainerConfig), "Start")]
namespace PSIMP.Web
{
    public class UnityContainerConfig
    {
        public static void Start()
        {
            IUnityContainer container = GetUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer GetUnityContainer()
        {
            //Create UnityContainer          
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container.RegisterType<IControllerActivator, CustomControllerActivator>();

            #region 应用层
            //人员基础信息
            container.RegisterType<IPersonService, PersonService>(new HttpContextLifetimeManager<IPersonService>());
            container.Configure<Interception>()
                     .SetInterceptorFor<IPersonService>(new InterfaceInterceptor());
            #endregion

            #region 底层业务
            container.RegisterType<IPersonBaseRepository, PersonBaseRepository>(new HttpContextLifetimeManager<IPersonBaseRepository>());
            
            #endregion

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HttpContextLifetimeManager<IUnitOfWork>())
                     .RegisterType<IDBFactory, DBFactory>(new HttpContextLifetimeManager<IDBFactory>());

            return container;
        }
    }
}