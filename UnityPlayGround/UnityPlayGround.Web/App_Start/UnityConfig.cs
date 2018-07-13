using System.Web.Http;
using Unity;
using Unity.WebApi;
using UnityPlayGround.Services.Repository;
using UnityPlayGround.Services.Services;

namespace UnityPlayGround.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IFooService, FooService>();
            container.RegisterType<IFooRepository, FooRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}