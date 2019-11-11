using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using C2EpiserverBlog.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace C2EpiserverBlog.Controllers
{
    public class ContactPageController : PageController<ContactPage>
    {
        public ActionResult Index(ContactPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}