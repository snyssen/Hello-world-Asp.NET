using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hello_world
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				 name: "Ajouter",
				 url: "Ajouter/{valeur1}/{valeur2}",
				 defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 0, valeur2 = 0 });

			routes.MapRoute(
				name: "Meteo",
				url: "Meteo/{jour}/{mois}/{annee}",
				defaults: new { controller = "Meteo", action = "Afficher" },
				constraints: new { jour = @"\d+", mois = @"\d+", annee = @"\d{4}" }); // On utilise ici des expressions régulières

			routes.MapRoute(
				name: "Link",
				url: "Link/{id}",
				defaults: new { controller = "Link", action = "Index", id = UrlParameter.Optional });

			routes.MapRoute(
				 name: "Default",
				 url: "{controller}/{action}/{id}",
				 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

			routes.MapRoute(
				 name: "RouteAttrapeTout",
				 url: "{controller}/{action}/{*id}",
				 defaults: new { controller = "Accueil", action = "Index", id = UrlParameter.Optional });
		}
	}
}
