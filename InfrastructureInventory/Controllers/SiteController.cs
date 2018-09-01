using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfrastructureInventory.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public string Index()
        {
            return "This is the Site Index Page";
            //return View();
        }

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("This is the Site Welcome Page: " + name + ", ID is: " + ID);

        }
    }
}



//https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-controller