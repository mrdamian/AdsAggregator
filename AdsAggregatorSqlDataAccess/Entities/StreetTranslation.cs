namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class StreetTranslation
    {
        internal virtual int StreetTranslationId { get; set; }
        internal virtual Street Street { get; set; }
        internal virtual string Name { get; set; }
        internal virtual Language Language { get; set; }
    }
}
