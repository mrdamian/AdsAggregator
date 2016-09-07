namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class District
    {
        internal virtual int DistrictId { get; set; }
        internal virtual string Name { get; set; }
        internal virtual City City { get; set; }
        internal virtual int CityId { get; set; }

        internal AdsAggregatorDomain.DomainObjects.District ToDomainDistrict()
        {
            return new AdsAggregatorDomain.DomainObjects.District(DistrictId, Name, new AdsAggregatorDomain.DomainObjects.City(City.CityId, City.Name));
        }
    }
}
