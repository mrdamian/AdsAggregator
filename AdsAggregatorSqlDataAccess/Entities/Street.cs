namespace AdsAggregatorSqlDataAccess.Entities
{
    public class Street
    {
        public virtual int StreetId { get; set; }
        public virtual StreetType StreetType { get; set; }
        public virtual int DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}
