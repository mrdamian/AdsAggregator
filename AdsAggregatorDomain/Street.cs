namespace AdsAggregatorDomain
{
    public class Street
    {
        private int _streetId;
        private string _name;
        private District _district;

        public Street(int id, string name, District district)
        {
            _streetId = id;
            _name = name;
            _district = district;
        }

        public int StreetId
        {
            get
            {
                return _streetId;
            }

            set
            {
                _streetId = value;
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

        public District District
        {
            get
            {
                return _district;
            }

            set
            {
                _district = value;
            }
        }
    }
}
