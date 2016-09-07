namespace AdsAggregatorSqlDataAccess.Entities
{
    internal class Street
    {
        internal virtual int StreetId { get; set; }
        internal virtual StreetType StreetType { get; set; }
        internal virtual int DistrictId { get; set; }
        internal virtual District District { get; set; }
    }
}
