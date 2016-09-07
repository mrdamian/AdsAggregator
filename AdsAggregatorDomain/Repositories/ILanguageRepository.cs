using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;

namespace AdsAggregatorDomain.Repositories
{
    public interface ILanguageRepository
    {
        void Insert(Language language);

        void Delete(Language language);

        void Update(Language language);

        IEnumerable<Language> GetAll();

        Language Find(int id);
    }
}
