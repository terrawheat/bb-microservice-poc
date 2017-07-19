using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BBMicroservicePOC.Controllers
{
    [Route("api/[controller]")]
    public class DirectoryController : Controller
    {
        [HttpGet]
        public IDictionary<ServiceType, IEnumerable<Uri>> Get()
        {
            return new Dictionary<ServiceType, IEnumerable<Uri>>()
            {
                { ServiceType.SampleService, new List<Uri>()
                {
                    new Uri("http://localhost:29777")
                } }
            };
        }

    }

    public enum ServiceType
    {
        SampleService = 1
    }
}
