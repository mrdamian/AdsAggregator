namespace AdsAggregatorDomain.DomainObjects
{
    public class StreetType
    {
        private int _streetTypeId;
        private string _shortName;
        private string _fullName;
        private Language _language;

        public StreetType(int streetTypeId, string shortName, string fullName, Language language)
        {
            _streetTypeId = streetTypeId;
            _shortName = shortName;
            _fullName = fullName;
            _language = language;
        }

        public int StreetTypeId
        {
            get
            {
                return _streetTypeId;
            }

            set
            {
                _streetTypeId = value;
            }
        }

        public string ShortName
        {
            get
            {
                return _shortName;
            }

            set
            {
                _shortName = value;
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

        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                _fullName = value;
            }
        }
    }
}
