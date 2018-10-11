using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hello_world.Controllers
{
    public class LinkController : Controller
    {
        // GET: Link
        public string Index(string id)
        {
			return HtmlHelper.GenerateLink(Request.RequestContext, RouteTable.Routes, "Mon lien", null, "Accueil", "Home", new RouteValueDictionary { { "id", id } }, null);
        }
    }
}