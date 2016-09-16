namespace AdsAggregatorSqlDataAccess.Entities
{
    public class City
    {
        public virtual int CityId { get; set; }
        public virtual string Name { get; set; }

        public AdsAggregatorDomain.DomainObjects.City ToDomainCity()
        {
            return new AdsAggregatorDomain.DomainObjects.City(CityId, Name);
        }
    }
}
