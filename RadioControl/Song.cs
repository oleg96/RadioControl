using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioControl
{
    class Song
    {
        private string artist;
        public string Artist
        {
            get { return artist; }
            set
            {
                if (value != "")
                {
                    artist = value;
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
            }
        }
        private Tags tags;
        public Tags Tags
        {
            get { return tags; }
            set
            {
                tags = value;
            }
        }
        public Song(string artist, string name, int year, Tags tags)
        {
            this.Artist = artist;
            this.Name = name;
            this.Year = year;
            this.Tags = tags;
        }
        public override string ToString()
        {
            return artist+" "+name+" "+year+" "+tags.ToString();
        }
    }
}
