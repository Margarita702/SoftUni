using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        public PlanetRepository()
        {
            this.planet = new List<IPlanet>();
        }

        private readonly List<IPlanet> planet;

        public IReadOnlyCollection<IPlanet> Models
            => planet;

        public void Add(IPlanet model)
      => this.planet.Add(model);

        public IPlanet FindByName(string name)
        => this.planet.FirstOrDefault(x => x.Name == name);

        public bool Remove(IPlanet model)
       => this.planet.Remove(model);
    }

}

