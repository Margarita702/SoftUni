using System;
using System.Collections.Generic;
using System.Text;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        public IReadOnlyCollection<IDecoration> Models => throw new NotImplementedException();

        public void Add(IDecoration model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IDecoration model)
        {
            throw new NotImplementedException();
        }

        public IDecoration FindByType(string type)
        {
            throw new NotImplementedException();
        }
    }
}
