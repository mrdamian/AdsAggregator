using AdsAggregatorDomain.Repositories;
using AdsAggregatorSqlDataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Linq;

namespace AdsAggregatorSqlDataAccess.Repositories
{
    public class LanguageRepository : ILanguageRepository, IDisposable
    {
        private readonly AdsAggregatorDbContext _context;

        public LanguageRepository(string connString)
        {
            _context = new AdsAggregatorDbContext(connString);
        }

        public AdsAggregatorDomain.DomainObjects.Language Find(int id)
        {
            var language = _context.Languages.Find(id);
            if (language == null)
            {
                return null;
            }
            else
            {
                return language.ToDomainLanguage();
            }
        }

        public IEnumerable<AdsAggregatorDomain.DomainObjects.Language> GetAll()
        {
            return _context.Languages.AsEnumerable().Select(c => c.ToDomainLanguage());
        }

        public void Insert(AdsAggregatorDomain.DomainObjects.Language language)
        {
            Language newLanguage = new Language()
            {
                LanguageId = language.LanguageId,
                Code = language.Code,
                Name = language.Name
            };

            _context.Languages.Add(newLanguage);
            _context.SaveChanges();
        }

        public void Update(AdsAggregatorDomain.DomainObjects.Language language)
        {
            var entityLanguage = _context.Languages.Find(language.LanguageId);
            entityLanguage.Name = language.Name;
            entityLanguage.Code = language.Code;
            _context.SaveChanges();
        }

        public void Delete(AdsAggregatorDomain.DomainObjects.Language language)
        {
            var entityLanguage = _context.Languages.Find(language.LanguageId);
            _context.Languages.Remove(entityLanguage);
            _context.SaveChanges();
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
