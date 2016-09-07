namespace AdsAggregatorDomain.DomainObjects
{
    public class Street
    {
        private int _streetId;
        private string _name;
        private Language _language;
        private District _district;
        private StreetType _streetType;

        public Street(int id, string name, Language language, District district, StreetType streetType)
        {
            _streetId = id;
            _name = name;
            _district = district;
            _language = language;
            _streetType = streetType;
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

        public Language Language
        {
            get
            {
                return _language;
            }

            set
            {
                _language = value;
            }
        }

        public StreetType StreetType
        {
            get
            {
                return _streetType;
            }

            set
            {
                _streetType = value;
            }
        }
    }
}
