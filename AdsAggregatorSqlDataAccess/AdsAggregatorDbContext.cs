using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    public class AdsAggregatorDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
    }
}
