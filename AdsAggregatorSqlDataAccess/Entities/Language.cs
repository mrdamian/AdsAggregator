namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class Language
    {
        internal virtual int LanguageId { get; set; }
        internal virtual string Code { get; set; }
        internal virtual string Name { get; set; }

        internal AdsAggregatorDomain.DomainObjects.Language ToDomainLanguage()
        {
            return new AdsAggregatorDomain.DomainObjects.Language(LanguageId, Code, Name);
        }
    }
}
