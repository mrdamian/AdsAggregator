namespace AdsAggregatorSqlDataAccess.Entities
{
    public class StreetTypeTranslation
    {
        public virtual int StreetTypeTranslationId { get; set; }
        public virtual StreetType StreetType { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string FullName { get; set; }
        public virtual int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public AdsAggregatorDomain.DomainObjects.StreetType ToDomainStreetType()
        {
            return new AdsAggregatorDomain.DomainObjects.StreetType(StreetType.StreetTypeId, ShortName, FullName, Language.ToDomainLanguage());
        }
    }
}
