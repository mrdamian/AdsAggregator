using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsAggregatorSqlDataAccess
{
    public class City
    {
        public virtual int CityId { get; set; }
        public virtual string Name { get; set; }

        internal AdsAggregatorDomain.City ToDomainCity()
        {
            return new AdsAggregatorDomain.City(CityId, Name);
        }
    }
}
