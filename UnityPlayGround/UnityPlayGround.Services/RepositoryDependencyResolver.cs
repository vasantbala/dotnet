using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using UnityPlayGround.Services.Repository;
using UnityPlayGround.Services.Services;

namespace UnityPlayGround.Services
{
    public class RepositoryDependencyResolver
    {
        private IUnityContainer container;

        private RepositoryDependencyResolver(IUnityContainer container)
        {
            this.container = container;
            BindDependencies();
        }

        private object _lockObject = new object();

        private static RepositoryDependencyResolver instance = null;

        public static RepositoryDependencyResolver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RepositoryDependencyResolver(new UnityContainer());
                }
                return instance;
            }
        }

        public IFooRepository GetFooRepository()
        {
            return container.Resolve<IFooRepository>();
        }

        public T GetDependency<T>(string connectionString)
        {
            return container.Resolve<T>(new ParameterOverride("connectionString", connectionString));
        }

        private void BindDependencies()
        {
            container.RegisterType<IFooRepository, FooRepository>(new InjectionConstructor(typeof(string)));
            container.RegisterType<IBarRepository, BarRepository>(new InjectionConstructor(typeof(string)));
        }
    }
}
