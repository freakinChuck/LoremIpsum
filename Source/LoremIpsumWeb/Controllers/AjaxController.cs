using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoremIpsumWeb.Controllers
{
    public class AjaxController : ApiController
    {
        [HttpGet]
        public string Test(int id)
        {
            return string.Format("Test Nr. {0}", id);
        }
    }
}
