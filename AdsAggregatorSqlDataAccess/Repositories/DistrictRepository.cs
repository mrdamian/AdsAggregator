using System;
using System.Collections.Generic;
using AdsAggregatorDomain.Repositories;
using System.Linq;
using System.Data;
using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess.Repositories
{
    public class DistrictRepository : IDistrictRepository, IDisposable
    {
        private readonly AdsAggregatorDbContext _context;

        public DistrictRepository(string connString)
        {
            _context = new AdsAggregatorDbContext(connString);
        }

        public void Insert(AdsAggregatorDomain.District district)
        {
            District newDistrict = new District()
            {
                DistrictId = district.DistrictId,
                Name = district.Name,
                City = new City()
                {
                    CityId = district.City.CityId,
                    Name = district.City.Name
                }
            };

            _context.Districts.Add(newDistrict);
            _context.SaveChanges();
        }

        public void Update(AdsAggregatorDomain.District district)
        {
            var entityDistrict =_context.Districts.Find(district.DistrictId);
            entityDistrict.Name = district.Name;
            entityDistrict.City = new City()
            {
                CityId = district.City.CityId,
                Name = district.City.Name
            };
            _context.SaveChanges();
        }

        public void Delete(AdsAggregatorDomain.District district)
        {
            var entityDistrict= _context.Districts.Find(district.DistrictId);
            _context.Districts.Remove(entityDistrict);
            _context.SaveChanges();
        }

        public IEnumerable<AdsAggregatorDomain.District> GetAll()
        {
            return _context.Districts.Include(f => f.City).AsEnumerable().Select(c => c.ToDomainDistrict());
        }

        public AdsAggregatorDomain.District Find(int id)
        {
            District district = _context.Districts.Find(id);
            if (district == null)
            {
                return null;
            }
            else
            {
                return district.ToDomainDistrict();
            }
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
