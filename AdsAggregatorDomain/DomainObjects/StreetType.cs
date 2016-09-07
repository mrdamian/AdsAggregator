namespace AdsAggregatorDomain.DomainObjects
{
    public class StreetType
    {
        private int _streetTypeId;
        private string _name;
        private Language _language;

        public StreetType(int streetTypeId, string name, Language language)
        {
            _streetTypeId = streetTypeId;
            _name = name;
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
    }
}
