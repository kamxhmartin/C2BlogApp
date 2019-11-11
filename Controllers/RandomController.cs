using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace C2EpiserverBlog.Controllers
{
    public class RandomController : Controller
    {
        // GET: Random
        public ActionResult Index()
        {
            return View();
        }
    }

}