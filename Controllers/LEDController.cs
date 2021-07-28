using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LEDServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LEDController : ControllerBase
    {

        private readonly ILogger<LEDController> _logger;

        public LEDController(ILogger<LEDController> logger)
        {
            _logger = logger;
        }
        private static LEDData json;
        [HttpGet]
        public IEnumerable<DataItem> Get()
        {
            Console.WriteLine("接收到请求");
            if (json == null)
            {
                return new List<DataItem>(256);
            }
            else
                return json.Data;
        }
        [HttpPost]
        public void Post(LEDData data)
        {
            json = data;

            Console.WriteLine(data.Data.Count);
        }
    }
}
