using AdsAggregatorSqlDataAccess.Entities;
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

        public DbSet<District> Districts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<StreetType> StreetTypes { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<StreetTranslation> StreetTranslations { get; set; }

        public DbSet<StreetTypeTranslation> StreetTypeTranslations { get; set; }
    }
}
