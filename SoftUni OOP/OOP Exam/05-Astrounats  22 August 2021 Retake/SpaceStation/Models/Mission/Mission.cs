using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {

            if (astronauts.All(x => x.Oxygen < 0))
            {

            }
            foreach (var astro in astronauts)
            {
                while (astro.CanBreath && planet.Items.Any())
                {
                    var item = planet.Items.FirstOrDefault();
                    astro.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                    astro.Breath();
                }
                if (!planet.Items.Any())
                {
                    break;
                }
            }
        }
    }
}
