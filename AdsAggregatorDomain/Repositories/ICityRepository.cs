using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;

namespace AdsAggregatorDomain.Repositories
{
    public interface ICityRepository
    {
        void Insert(City city);

        void Delete(City city);

        void Update(City city);

        IEnumerable<City> GetAll();

        City Find(int id);
    }
}
