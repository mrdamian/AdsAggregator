namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class City
    {
        internal virtual int CityId { get; set; }
        internal virtual string Name { get; set; }

        internal AdsAggregatorDomain.DomainObjects.City ToDomainCity()
        {
            return new AdsAggregatorDomain.DomainObjects.City(CityId, Name);
        }
    }
}
