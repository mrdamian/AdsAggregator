using AdsAggregatorDomain.DomainObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace AdsAggregatorWebPresentationModel.Models.StreetType
{
    public class StreetTypeListViewModel
    {
        public StreetTypeListViewModel(IEnumerable<StreetTypeViewModel> streetTypes, IEnumerable<Language> languages, int selectedLanguageId)
        {
            StreetTypes = streetTypes;
            LanguageId = selectedLanguageId;
            Languages = languages.Select(c => new SelectListItem { Text = c.Name, Value = c.LanguageId.ToString() });
        }

        [Display(Name = "Language")]
        public int LanguageId { get; set; }

        public IEnumerable<SelectListItem> Languages { get; private set; }
        public IEnumerable<StreetTypeViewModel> StreetTypes { get; private set; }
    }
}
