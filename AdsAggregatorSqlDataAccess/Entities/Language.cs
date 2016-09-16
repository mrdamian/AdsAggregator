namespace AdsAggregatorSqlDataAccess.Entities
{
    public class Language
    {
        public virtual int LanguageId { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }

        public AdsAggregatorDomain.DomainObjects.Language ToDomainLanguage()
        {
            return new AdsAggregatorDomain.DomainObjects.Language(LanguageId, Code, Name);
        }
    }
}
