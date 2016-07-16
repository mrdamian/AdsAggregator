using System;
using AdsAggregatorDomain;
using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    public class DatabaseInitializer : IObjectsInitializer
    {
        public void Initialize()
        {
            Database.SetInitializer(new DummyDataDbInitializer());
        }
    }
}
