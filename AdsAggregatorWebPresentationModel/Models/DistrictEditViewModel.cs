using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using AdsAggregatorDomain.DomainObjects;

namespace AdsAggregatorWebPresentationModel.Models
{
    public class DistrictEditViewModel
    {
        public DistrictEditViewModel()
        {
        }

        public DistrictEditViewModel(IEnumerable<City> cities, District district = null)
        {
            if (district != null)
            {
                DistrictId = district.DistrictId;
                Name = district.Name;
                //TODO : Try to cover by test situation when line below is commented
                CityId = district.City.CityId;
            }
            Cities = cities.Select(c => new SelectListItem { Text = c.Name, Value = c.CityId.ToString(), Selected = false });
        }

        public IEnumerable<SelectListItem> Cities { get; private set; }

        public int DistrictId { get; set; }

        [Display(Name = "City")]
        public int CityId { get; set; }

        [Display(Name = "Name")]
        [MinLength(3)]
        public string Name { get; set; }
    }
}