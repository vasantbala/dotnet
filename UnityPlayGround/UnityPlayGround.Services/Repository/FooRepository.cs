using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPlayGround.Services.Repository
{
    public class FooRepository : DBContext.DBContext, IFooRepository
    {
        public FooRepository(string connectionString) : base(connectionString) { }

        public string GetFoo()
        {
            return string.Format("Foo from {0}", base.GetConnectionString());
        }
    }
}
