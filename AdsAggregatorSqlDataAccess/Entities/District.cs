namespace AdsAggregatorSqlDataAccess.Entities
{
    public class District
    {
        public virtual int DistrictId { get; set; }
        public virtual string Name { get; set; }
        public virtual City City { get; set; }
        public virtual int CityId { get; set; }

        public AdsAggregatorDomain.DomainObjects.District ToDomainDistrict()
        {
            return new AdsAggregatorDomain.DomainObjects.District(DistrictId, Name, new AdsAggregatorDomain.DomainObjects.City(City.CityId, City.Name));
        }
    }
}
