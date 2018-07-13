using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPlayGround.Services.DBContext
{
    public class DBContext
    {
        private readonly string connectionString;
        public DBContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return this.connectionString;
        }
    }
}
