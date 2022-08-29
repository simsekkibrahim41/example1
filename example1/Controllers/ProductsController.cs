using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace example1.Controllers
{

    [Route("Products")]
    public class ProductsController:ControllerBase
    {
        [Route("Merhaba")]
        public string Merhaba()
        {
            return "merhaba";

        }

        [Route("Hello")]
        public string Hello()
        {
            return "hello";

        }

    }
}
