namespace AdsAggregatorWebPresentationModel.Models.StreetType
{
    public class StreetTypeViewModel
    {
        public StreetTypeViewModel()
        {
        }

        public StreetTypeViewModel(AdsAggregatorDomain.DomainObjects.StreetType streetType)
        {
            StreetTypeId = streetType.StreetTypeId;
            ShortName = streetType.ShortName;
            FullName = streetType.FullName;
            LanguageId = streetType.Language.LanguageId;
        }

        public int StreetTypeId { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public int LanguageId { get; set; }
    }
}