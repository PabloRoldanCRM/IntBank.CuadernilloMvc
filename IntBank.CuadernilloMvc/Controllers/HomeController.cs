using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntBank.CuadernilloMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return new ViewAsPdf() {
                PageSize =Rotativa.Options.Size.A4
            };
        }
    }
}