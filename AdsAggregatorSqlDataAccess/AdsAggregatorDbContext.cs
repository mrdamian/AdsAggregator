using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    public class AdsAggregatorDbContext : DbContext
    {
        public AdsAggregatorDbContext() : base("AdsAggregatorDb")
        {
        }

        public AdsAggregatorDbContext(string connString) : base(connString)
        {
        }

        public DbSet<City> Cities { get; set; }
    }
}
