using Rotativa;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntBank.Reportes.Controllers
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

        public ActionResult ContratoAsesoria()
        {
            
            return new ViewAsPdf()
            {
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(11,9,11,9)          
            };
        }
        public ActionResult AltaClienteDigital()
        {

            return new ViewAsPdf()
            {
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(10, 10, 10, 10)
            };
        }
    }
}