using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityPlayGround.Services.Repository;

namespace UnityPlayGround.Services.Services
{
    public class FooService : BaseService, IFooService
    {
        public FooService(string connectionString) : base(connectionString) { }

        public string GetFoo()
        {
            string fooValue = RepositoryDependencyResolver.Instance.GetDependency<IFooRepository>(_connectionString).GetFoo();
            string barValue = RepositoryDependencyResolver.Instance.GetDependency<IBarRepository>(_connectionString).GetBar();
            return fooValue + " & " + barValue;
        }

        public string GetBarViaFoo()
        {
            return RepositoryDependencyResolver.Instance.GetDependency<IBarRepository>(_connectionString).GetBar();
        }
    }
}
