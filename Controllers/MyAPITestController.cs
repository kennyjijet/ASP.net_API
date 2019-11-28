using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyAPITestController : ControllerBase
    {

        private readonly ILogger<MyAPITestController> _logger;

        public MyAPITestController(ILogger<MyAPITestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MyAPITest> Get()
        {
            /* 
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new MyAPITest
            {
                MyValue = "TEST"
            })
            .ToArray();
            */
            MyAPITest myAPITest = new MyAPITest();
            myAPITest.MyValue = "TEST";
            IEnumerable<MyAPITest> IElist = new List<MyAPITest>();
            IElist.Append(myAPITest);

            return IElist;
        }
    }
}
