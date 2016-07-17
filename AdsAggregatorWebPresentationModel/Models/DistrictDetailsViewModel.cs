using AdsAggregatorDomain;
using System.ComponentModel.DataAnnotations;

namespace AdsAggregatorWebPresentationModel.Models
{
    public class DistrictDetailsViewModel
    {
        public DistrictDetailsViewModel()
        {
        }

        public DistrictDetailsViewModel(District district)
        {
            DistrictId = district.DistrictId;
            Name = district.Name;
            CityName = district.City.Name;
        }

        public int DistrictId { get; set; }

        [Display(Name="Name")]
        [MinLength(3)]
        public string Name { get; set; }

        [Display(Name = "City")]
        public string CityName { get; private set; }
    }
}