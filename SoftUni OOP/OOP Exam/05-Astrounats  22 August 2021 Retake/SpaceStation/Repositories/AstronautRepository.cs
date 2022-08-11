using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        public AstronautRepository()
        {
            this.astro = new List<IAstronaut>();
        }

        private readonly List<IAstronaut> astro;

        public IReadOnlyCollection<IAstronaut> Models
            => astro;

        public void Add(IAstronaut model)
      => this.astro.Add(model);

        public IAstronaut FindByName(string name)
        => this.astro.FirstOrDefault(x => x.Name == name);

        public bool Remove(IAstronaut model)
       => this.astro.Remove(model);
    }
}
