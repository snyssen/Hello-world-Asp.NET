using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hello_world.Models;

namespace Hello_world.Controllers
{
    public class HomeController : Controller
    {
			public ActionResult Index(string id)
			{
				if (string.IsNullOrWhiteSpace(id))
				    return View("Error");
				else
				{
					ViewData["Nom"] = id;
					return View();
				}
			}
			
			public string Accueil()
			{
				return "Ceci est l'accueil";
			}
			
			public ActionResult ListeClients()
			{
				Clients clients = new Clients();
				ViewData["Clients"] = clients.ObtenirListeClients();
				return View();
			}

			public ActionResult ChercheClient(string id)
			{
				ViewData["Nom"] = id;
				Clients clients = new Clients();
				Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
				if (client != null)
				{
					ViewData["Age"] = client.Age;
					return View("Trouve");
				}
				return View("NonTrouve");
			}

			public ActionResult About()
			{
				ViewBag.Message = "Your application description page.";

				return View();
			}

			public ActionResult Contact()
			{
				ViewBag.Message = "Your contact page.";

				return View();
			}
    }
}