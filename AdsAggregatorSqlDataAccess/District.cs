namespace AdsAggregatorSqlDataAccess
{
    public class District
    {
        public virtual int DistrictId { get; set; }
        public virtual string Name { get; set; }
        public virtual City City { get; set; }
        public virtual int CityId { get; set; }

        internal AdsAggregatorDomain.District ToDomainDistrict()
        {
            return new AdsAggregatorDomain.District(DistrictId, Name, new AdsAggregatorDomain.City(City.CityId, City.Name));
        }
    }
}
