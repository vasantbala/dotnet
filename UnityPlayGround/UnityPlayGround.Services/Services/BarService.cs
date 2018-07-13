using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityPlayGround.Services.Repository;

namespace UnityPlayGround.Services.Services
{
    public class BarService : BaseService, IBarService
    {
        public BarService(string connectionString) : base(connectionString) { }

        public string GetBar()
        {
           return RepositoryDependencyResolver.Instance.GetDependency<IBarRepository>(_connectionString).GetBar();
        }
    }
}
