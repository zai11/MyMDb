
using System.Collections.Generic;

namespace MyMDb
{
    class SearchResults
    {
        private readonly List<SearchResult> search = new List<SearchResult>();

        public List<SearchResult> Search 
        {
            get { return search; }
        }
    }
}
