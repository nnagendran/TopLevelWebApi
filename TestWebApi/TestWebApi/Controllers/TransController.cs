using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApi.Controllers
{
    public class TransController : Controller
    {
        // GET: Trans
        public ActionResult Transaction()
        {
            return View("Transaction");
        }
    }
}