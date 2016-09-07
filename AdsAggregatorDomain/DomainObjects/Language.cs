namespace AdsAggregatorDomain.DomainObjects
{
    public class Language
    {
        private int _languageId;
        private string _code;
        private string _name;

        public Language(int languateId, string code, string name)
        {
            _languageId = languateId;
            _code = code;
            _name = name;
        }

        public int LanguageId
        {
            get
            {
                return _languageId;
            }

            set
            {
                _languageId = value;
            }
        }

        public string Code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
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
