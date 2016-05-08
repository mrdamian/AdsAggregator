using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    public class AdsAggregatorDbContext : DbContext
    {
        public AdsAggregatorDbContext() : base("AdsAggregatorDb")
        {
        }

        public DbSet<City> Cities { get; set; }
    }
}
