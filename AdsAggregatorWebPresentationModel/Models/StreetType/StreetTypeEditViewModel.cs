using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AdsAggregatorWebPresentationModel.Models.StreetType
{
    public class StreetTypeEditViewModel : StreetTypeViewModel
    {
        public StreetTypeEditViewModel()
        {
        }

        public StreetTypeEditViewModel(IEnumerable<Language> languages)
        {
            InitializeLanguage(languages);
        }

        public StreetTypeEditViewModel(IEnumerable<Language> languages, AdsAggregatorDomain.DomainObjects.StreetType streetType) : base(streetType)
        {
            InitializeLanguage(languages);
        }

        private void InitializeLanguage(IEnumerable<Language> languages)
        {
            OriginalLanguageId = LanguageId;
            Languages = languages.Select(c => new SelectListItem { Text = c.Name, Value = c.LanguageId.ToString(), Selected = false });
        }

        public IEnumerable<SelectListItem> Languages { get; private set; }
        public int OriginalLanguageId { get; set; }
    }
}