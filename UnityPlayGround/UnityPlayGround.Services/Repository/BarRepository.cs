using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPlayGround.Services.Repository
{
    public class BarRepository : DBContext.DBContext, IBarRepository
    {
        public BarRepository(string connectionString) : base(connectionString) { }

        public string GetBar()
        {
            return string.Format("Bar from {0}", base.GetConnectionString());
        }
    }
}
