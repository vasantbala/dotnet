using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPlayGround.Services.Services
{
    public class BaseService
    {
        protected string _connectionString;

        public BaseService(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
