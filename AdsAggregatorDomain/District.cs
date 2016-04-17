namespace AdsAggregatorDomain
{
    public class District
    {
        private int _districtId;
        private string _name;
        private City _city;

        public District(int id, string name, City city)
        {
            _districtId = id;
            _name = name;
            _city = city;
        }

        public int DistrictId
        {
            get
            {
                return _districtId;
            }

            set
            {
                _districtId = value;
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

        public City City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }
    }
}
