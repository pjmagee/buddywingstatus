using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BuddyWingStatus.Models;

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

                var request = p.Requests.ElementAtOrDefault(new Random().Next(0, p.Requests.Count));
                planet.Description = request.Description;

                try
                {
                    var resp = client.GetPath("STATUS", (ulong)p.AreaID, request.StartEndCompositeType);
                    planet.Message = resp.Message;
                    planet.HopsReturned = resp.PathHops != null ? resp.PathHops.Count() : 0;
                }
                catch (Exception e)
                {
                    planet.Message = "BAD RESPONSE.";
                }

                planets.Add(planet);
            }

            return View("Index", planets);
        }
    }
}
