using AdsAggregatorDomain;
using System.ComponentModel.DataAnnotations;

namespace AdsAggregatorWebPresentationModel.Models
{
    public class CityViewModel
    {
        private readonly int _cityId;

        public CityViewModel(City city)
        {
            _cityId = city.CityId;
            Name = city.Name;
        }

        public int CityId
        {
            get
            {
                return _cityId;
            }
        }

        [Display(Name="Name")]
        public string Name { get; set; }
    }
}