using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;

namespace AdsAggregatorDomain.Repositories
{
    public interface IStreetRepository
    {
        void Insert(Street city);

        void Delete(Street city);

        void Update(Street city);

        IEnumerable<Street> GetAll(string LangCode = null);

        Street Find(int id);
    }
}
