using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orleans;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IClusterClient _clusterClient;

        public EmployeeController(IClusterClient clusterClient)
        {
            _clusterClient = clusterClient;
        }

        [HttpGet("{id}")]
        public Task<int> Get(Guid id)
        {
            var employee = _clusterClient.GetGrain<IEmployee>(id);
            return employee.GetLevel();
        }
    }
}