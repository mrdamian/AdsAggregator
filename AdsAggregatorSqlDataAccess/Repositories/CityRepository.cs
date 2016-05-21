using System;
using AdsAggregatorDomain.Repositories;

namespace AdsAggregatorSqlDataAccess.Repositories
{
    public class CityRepository : ICityRepository, IDisposable
    {
        private readonly AdsAggregatorDbContext _context;

        public CityRepository(string connString)
        {
            _context = new AdsAggregatorDbContext(connString);
        }

        public void Insert(AdsAggregatorDomain.City city)
        {
            City newCity = new City()
            {
                CityId = city.CityId,
                Name = city.Name
            };

            _context.Cities.Add(newCity);
        }

        public void Update(AdsAggregatorDomain.City city)
        {
            var entityCity =_context.Cities.Find(city.CityId);
            entityCity.Name = city.Name;
            _context.SaveChanges();
        }

        public void Delete(AdsAggregatorDomain.City city)
        {
            var entityCity = _context.Cities.Find(city.CityId);
            _context.Cities.Remove(entityCity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
