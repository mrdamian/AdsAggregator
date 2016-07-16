using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    internal class DummyDataDbInitializer : DropCreateDatabaseAlways<AdsAggregatorDbContext>
    {
        protected override void Seed(AdsAggregatorDbContext context)
        {
            var kiev = new City { Name = "Kiev" };
            context.Cities.Add(kiev);
            context.Cities.Add(new City { Name = "Munich" });

            context.Districts.Add(new District { Name = "Obolonskiy", City = kiev });
            context.Districts.Add(new District { Name = "Podolskiy", City = kiev });
            base.Seed(context);
        }
    }
}
