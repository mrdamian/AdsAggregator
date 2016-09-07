using AdsAggregatorSqlDataAccess.Entities;
using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    internal class AdsAggregatorDbContext : DbContext
    {
        public AdsAggregatorDbContext() : base("AdsAggregatorDb")
        {
        }

        public AdsAggregatorDbContext(string connString) : base(connString)
        {
        }

        internal DbSet<City> Cities { get; set; }

        internal DbSet<District> Districts { get; set; }

        internal DbSet<Language> Languages { get; set; }

        internal DbSet<Street> Streets { get; set; }

        internal DbSet<StreetTranslation> StreetTranslations { get; set; }

        internal DbSet<StreetType> StreetTypes { get; set; }

        internal DbSet<StreetTypeTranslation> StreetTypeTranslations { get; set; }
    }
}
