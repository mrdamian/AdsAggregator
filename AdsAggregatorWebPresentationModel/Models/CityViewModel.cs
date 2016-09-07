using AdsAggregatorDomain;
using AdsAggregatorDomain.DomainObjects;
using System.ComponentModel.DataAnnotations;

namespace AdsAggregatorWebPresentationModel.Models
{
    public class CityViewModel
    {
        public CityViewModel()
        {
        }

        public CityViewModel(City city)
        {
            CityId = city.CityId;
            Name = city.Name;
        }

        public int CityId { get; set; }

        [Display(Name="Name")]
        [MinLength(3)]
        public string Name { get; set; }
    }
}