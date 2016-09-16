namespace AdsAggregatorSqlDataAccess.Entities
{
    public class StreetTranslation
    {
        public virtual int StreetTranslationId { get; set; }
        public virtual Street Street { get; set; }
        public virtual string Name { get; set; }
        public virtual Language Language { get; set; }
    }
}
