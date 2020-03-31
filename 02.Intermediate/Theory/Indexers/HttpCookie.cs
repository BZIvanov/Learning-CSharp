using System.Collections.Generic;

namespace IntermediateLevel
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // the key is whatever is provided to the class instance, in this example "name"
        public string this[string key]
        {
            get { return _dictionary[key]; }
            // value is keyword and provided to the set by c#, in this example it will be "Tony"
            set { _dictionary[key] = value; }
        }
    }
}
