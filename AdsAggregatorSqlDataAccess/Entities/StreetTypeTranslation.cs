namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class StreetTypeTranslation
    {
        internal virtual int StreetTypeTranslationId { get; set; }
        internal virtual StreetType StreetType { get; set; }
        internal virtual string ShortName { get; set; }
        internal virtual string FullName { get; set; }
        internal virtual int LanguageId { get; set; }
        internal virtual Language Language { get; set; }
    }
}
