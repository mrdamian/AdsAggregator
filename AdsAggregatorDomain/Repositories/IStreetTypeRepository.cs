using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;

namespace AdsAggregatorDomain.Repositories
{
    public interface IStreetTypeRepository
    {
        void Insert(StreetType streetType);

        void Delete(StreetType streetType);

        void Update(StreetType streetType);

        IEnumerable<StreetType> GetAll(int languageId);

        StreetType Find(int id, int languageId);
    }
}
