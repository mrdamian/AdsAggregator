using System;
using System.Collections.Generic;
using AdsAggregatorDomain.Repositories;
using System.Linq;
using AdsAggregatorSqlDataAccess.Entities;

namespace AdsAggregatorSqlDataAccess.Repositories
{
    //public class StreetRepository : IStreetRepository, IDisposable
    //{
    //    private readonly AdsAggregatorDbContext _context;

    //    public StreetRepository(string connString)
    //    {
    //        _context = new AdsAggregatorDbContext(connString);
    //    }
        
    //    public void Insert(AdsAggregatorDomain.DomainObjects.Street street)
    //    {
    //        var language = _context.Languages.First(l => l.LanguageId == street.Language.LanguageId);
    //        Street newStreet = new Street()
    //        {
    //            StreetId = street.StreetId,
    //            District = new District
    //            {
    //               Name = street.District.Name,
    //               City = new City
    //               {
    //                   Name = street.District.City.Name
    //               }
    //            }
    //        };

    //        var streetType = _context.StreetTypes.First(st => st.StreetTypeId == street.StreetType.StreetTypeId);

    //        StreetTranslation streetTranslation = new StreetTranslation
    //        {
    //            Street = newStreet,
    //            StreetType = streetType,
    //            Name = street.Name,
    //            Language = language
    //        };

    //        _context.Streets.Add(newStreet);
    //        _context.SaveChanges();
    //    }

    //    public void Update(AdsAggregatorDomain.DomainObjects.Street street)
    //    {
    //        var entityStreet =_context.Streets.Find(street.StreetId);
    //        entityStreet.Name = street.Name;
    //        _context.SaveChanges();
    //    }

    //    public void Delete(AdsAggregatorDomain.DomainObjects.Street Street)
    //    {
    //        var entityStreet = _context.Cities.Find(Street.StreetId);
    //        _context.Cities.Remove(entityStreet);
    //        _context.SaveChanges();
    //    }

    //    public IEnumerable<AdsAggregatorDomain.DomainObjects.Street> GetAll(string langCode = null)
    //    {
    //        return _context.Cities.AsEnumerable().Select(c => c.ToDomainStreet());
    //    }

    //    public AdsAggregatorDomain.DomainObjects.Street Find(int id)
    //    {
    //        Street Street = _context.Cities.Find(id);
    //        if (Street == null)
    //        {
    //            return null;
    //        }
    //        else
    //        {
    //            return Street.ToDomainStreet();
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            _context.Dispose();
    //        }
    //    }
    //}
}
