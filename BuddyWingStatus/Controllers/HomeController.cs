using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using BuddyWingStatus.Models;
using BuddyWingStatus.PathServiceClient;

namespace BuddyWingStatus.Controllers
{
    public class HomeController : Controller
    {
        public static List<IPlanet> Planets = new List<IPlanet>()
        {
            new Alderaan(),
            new BalmorraEmpire(),
            new BalmorraRepublic(),
            new Belsavis(),
            new Corellia(),
            new Coruscant(),
            new DromundKaas(),
            new Hoth(),
            new Hutta(),
            new Ilum(),
            new ImperialFleet(),
            new Korriban(),
            new NarShaddaa(),
            new OrdMantell(),
            new Quesh(),
            new RepublicFleet(),
            new TarisEmpire(),
            new TarisRepublic(),
            new Tatooine(),
            new Tython(),
            new Voss(),
        };

        public ActionResult Index()
        {
            var client = new PathServiceClient.PathServiceClient();
            var planets = new List<PlanetStatus>();

            foreach (var p in Planets)
            {
                var planet = new PlanetStatus();

                planet.Name = p.Name;
                planet.AreaName = p.AreaName;
                planet.Description = p.Description;

                try
                {
                    var resp = client.GetPath("STATUS", (ulong) p.AreaID, p.StartEnd);
                    planet.Status = resp.Message;
                    planet.HopsReturned = resp.PathHops != null ? resp.PathHops.Count() : 0;
                }
                catch (Exception e)
                {
                    planet.Status = e.Message;
                }

                planets.Add(planet);
            }

            return View("Index", planets);
        }
    }
}
