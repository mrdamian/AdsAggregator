using AdsAggregatorDomain;
using System.ComponentModel.DataAnnotations;

namespace AdsAggregatorWebPresentationModel.Models
{
    public class DistrictViewModel
    {
        public DistrictViewModel()
        {
        }

        public DistrictViewModel(District district)
        {
            DistrictId = district.DistrictId;
            Name = district.Name;
            CityName = district.City.Name;
        }

        public int DistrictId { get; set; }

        [Display(Name="Name")]
        [MinLength(3)]
        public string Name { get; set; }

        public string CityName { get; private set; }
    }
}