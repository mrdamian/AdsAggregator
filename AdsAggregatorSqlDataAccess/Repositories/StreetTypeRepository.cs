using AdsAggregatorDomain.Repositories;
using AdsAggregatorSqlDataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdsAggregatorSqlDataAccess.Repositories
{
    public class StreetTypeRepository : IStreetTypeRepository, IDisposable
    {
        private readonly AdsAggregatorDbContext _context;

        public StreetTypeRepository(string connString)
        {
            _context = new AdsAggregatorDbContext(connString);
        }

        public AdsAggregatorDomain.DomainObjects.StreetType FindSingle(int id, int languageId)
        {
            var streetTypeTranslation = _context.StreetTypeTranslations.Where(stt => stt.StreetType.StreetTypeId == id && stt.LanguageId == languageId).FirstOrDefault();
            if (streetTypeTranslation == null)
            {
                return null;
            }
            else
            {
                return streetTypeTranslation.ToDomainStreetType();
            }
        }

        public IEnumerable<AdsAggregatorDomain.DomainObjects.StreetType> Find(int id)
        {
            var streetTypeTranslation = _context.StreetTypeTranslations.Where(stt => stt.StreetType.StreetTypeId == id);
            if (streetTypeTranslation == null)
            {
                return null;
            }
            else
            {
                return streetTypeTranslation.Include(stt => stt.Language).Include(stt => stt.StreetType).AsEnumerable().Select(stt => stt.ToDomainStreetType());
            }
        }

        public IEnumerable<AdsAggregatorDomain.DomainObjects.StreetType> GetAll(int languageId)
        {
            return _context.StreetTypeTranslations.Where(stt => stt.LanguageId == languageId).Include(stt => stt.Language).Include(stt => stt.StreetType).AsEnumerable().Select(c => c.ToDomainStreetType());
        }

        public void Insert(AdsAggregatorDomain.DomainObjects.StreetType streetType)
        {
            // TODO: Add test that ensures that it is possible to have only one item per language
            // Adding street type with existing languageId should return error/overwite existing item. Consider create complicated primary key in the table
            var entityStreetType =_context.StreetTypes.Find(streetType.StreetTypeId);
            if (entityStreetType == null)
            {
                entityStreetType = new StreetType();
            }

            StreetTypeTranslation stt = new StreetTypeTranslation()
            {
                StreetType = entityStreetType,
                ShortName = streetType.ShortName,
                FullName = streetType.FullName,
                LanguageId = streetType.Language.LanguageId
            };

            _context.StreetTypeTranslations.Add(stt);
            _context.SaveChanges();
        }

        public void Update(AdsAggregatorDomain.DomainObjects.StreetType streetType)
        {
            var entityStreetTypeTranslation = _context.StreetTypeTranslations.Where(stt => stt.StreetType.StreetTypeId == streetType.StreetTypeId && stt.LanguageId == streetType.Language.LanguageId).First();
            entityStreetTypeTranslation.ShortName = streetType.ShortName;
            entityStreetTypeTranslation.FullName = streetType.FullName;
            _context.SaveChanges();
        }

        public void Delete(AdsAggregatorDomain.DomainObjects.StreetType streetType)
        {
            var streetTypeTranslations = _context.StreetTypeTranslations.Where(stt => stt.StreetType.StreetTypeId == streetType.StreetTypeId).ToList();
            var sttToDelete = streetTypeTranslations.Where(stt => stt.LanguageId == streetType.Language.LanguageId).First();
            _context.StreetTypeTranslations.Remove(sttToDelete);
            if (streetTypeTranslations.Count == 1)
            {
                StreetType stToDelete = new StreetType() { StreetTypeId = streetType.StreetTypeId }; 
                _context.Entry(stToDelete).State = EntityState.Deleted;
                _context.SaveChanges();
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
