namespace AdsAggregatorDomain.DomainObjects
{
    public class City
    {
        private int _cityId;
        private string _name;

        public City(int cityId, string name)
        {
            _cityId = cityId;
            _name = name;
        }

        public int CityId
        {
            get
            {
                return _cityId;
            }

            set
            {
                _cityId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
