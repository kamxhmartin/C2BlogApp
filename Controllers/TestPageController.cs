using System;
using System.Net;
using System.Web.Mvc;
using C2EpiserverBlog.Models.Pages;
using EPiServer.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace C2EpiserverBlog.Controllers
{
    public class TestPageController : PageController<TestPage>
    {
        public ActionResult Index(TestPage currentPage)
        {
            return View(currentPage);
        }

        [HttpPost]
        public ActionResult Index(TestPage random, string submit)
        {
            Random rnd = new Random();
            int spellNum = rnd.Next(1, 320);
            var url = $"http://dnd5eapi.co/api/spells/{spellNum}";
            try
            {
                using (WebClient wc = new System.Net.WebClient())
                {
                    var json = wc.DownloadString(url);
                    var cleanedJson = JObject.Parse(json);

                    var something = new TestPage {  };

                    foreach (JProperty property in cleanedJson.Properties())
                    {
                        if(property.Name == "name")
                        {
                            something.SpellName = property.Value.ToString();
                        }
                        if(property.Name == "desc")
                        {
                            something.SpellDescription = property.Value.ToString();
                        }
                    }

                    return View(something);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}