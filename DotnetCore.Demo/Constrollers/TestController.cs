using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Demo.Constrollers
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        public string GetData()
        {
            return "HELLO";
        }
    }
}