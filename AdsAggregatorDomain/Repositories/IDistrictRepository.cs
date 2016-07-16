using System.Collections.Generic;

namespace AdsAggregatorDomain.Repositories
{
    public interface IDistrictRepository
    {
        void Insert(District city);

        void Delete(District city);

        void Update(District city);

        IEnumerable<District> GetAll();

        District Find(int id);
    }
}
