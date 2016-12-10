using AdsAggregatorSqlDataAccess.Entities;
using System.Data.Entity;

namespace AdsAggregatorSqlDataAccess
{
    internal class DummyDataDbInitializer : DropCreateDatabaseAlways<AdsAggregatorDbContext>
    {
        protected override void Seed(AdsAggregatorDbContext context)
        {
            var kiev = new City { Name = "Киев" };
            //context.Cities.Add(kiev);
            context.Cities.Add(new City { Name = "Мюнхен" });

            District districtObolonskiy = new District { Name = "Оболонский", City = kiev };
            context.Districts.Add(districtObolonskiy);
            context.Districts.Add(new District { Name = "Подольский", City = kiev });

            var russian = new Language { Name = "Русский", Code = "ru-RU" };
            context.Languages.Add(russian);
            var ukrainian = new Language { Name = "Українська", Code = "uk-UK" };
            context.Languages.Add(ukrainian);
            var english = new Language { Name = "English", Code = "en-US" };
            context.Languages.Add(english);

            StreetType strTypeStreet = new StreetType();
            context.StreetTypes.Add(strTypeStreet);

            Street streetHeroivDnipra = new Street { District = districtObolonskiy, StreetType = strTypeStreet };
            context.Streets.Add(streetHeroivDnipra);

            StreetTypeTranslation strTypeTranslationUkrainian = new StreetTypeTranslation
            {
                ShortName = "вул.",
                FullName = "вулиця",
                Language = ukrainian,
                StreetType = strTypeStreet
            };
            context.StreetTypeTranslations.Add(strTypeTranslationUkrainian);
            StreetTypeTranslation strTypeTranslationRussian = new StreetTypeTranslation
            {
                ShortName = "ул.",
                FullName = "улица",
                Language = russian,
                StreetType = strTypeStreet
            };
            context.StreetTypeTranslations.Add(strTypeTranslationRussian);

            StreetTypeTranslation strTypeTranslationEng = new StreetTypeTranslation
            {
                ShortName = "St.",
                FullName = "Street",
                Language = english,
                StreetType = strTypeStreet
            };
            context.StreetTypeTranslations.Add(strTypeTranslationEng);

            StreetTranslation strTranslationUkrainian = new StreetTranslation
            {
                Street = streetHeroivDnipra,

                Name = "Героїв Дніпра",
                Language = ukrainian
            };
            context.StreetTranslations.Add(strTranslationUkrainian);

            StreetTranslation strTranslationRussian = new StreetTranslation
            {
                Street = streetHeroivDnipra,
                Name = "Героев Днепра",
                Language = russian
            };
            context.StreetTranslations.Add(strTranslationRussian);
            base.Seed(context);
        }
    }
}
