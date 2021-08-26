using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMDb
{
    class SearchResult
    {
        private string title;
        private string year;
        private string imdbId;
        private string type;
        private string poster;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string ImdbId
        {
            get { return imdbId; }
            set { imdbId = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }

        public SearchResult(string title, string year, string imdbId, string type, string poster)
        {
            this.title = title;
            this.year = year;
            this.imdbId = imdbId;
            this.type = type;
            this.poster = poster;
        }

    }
}
