using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioControl
{
    class Song
    {
        string artist { set; get; }
        string name { set; get; }
        int year { set; get; }
        List<String> tags { set; get; }
        public Song(string artist, string name, int year, List<String> tags)
        {
            this.artist = artist;
            this.name = name;
            this.year = year;
            this.tags = tags;
        }
        public string returnArtist()
        {
            return artist;
        }
        public string returnName()
        {
            return name;
        }
        public int returnYear()
        {
            return year;
        }
        public List<String> returnTags()
        {
            return tags;
        }
        public override string ToString()
        {
            return artist+" "+name+" "+year+" "+tags.ToString();
        }
    }
}
