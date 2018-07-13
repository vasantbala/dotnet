using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnityPlayGround.Services;
using UnityPlayGround.Services.Services;

namespace UnityPlayGround.Web.Controllers
{
    [RoutePrefix("api/foo")]
    public class FooController : ApiController
    {
        public FooController()
        {
        }

        [Route("GetFoo")]
        public string GetFoo()
        {
            return ServiceDependencyResolver.Instance.GetDependency<IFooService>(GetConnectionString()).GetFoo();
        }

        private string GetConnectionString()
        {
            return "connection string from http context";
        }
    }
}
