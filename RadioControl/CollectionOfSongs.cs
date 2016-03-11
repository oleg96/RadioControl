using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioControl
{
    class CollectionOfSongs
    {
        List<Song> songCollection = new List<Song>();
        public void AddSong(string artist, string name, int year, List<String> tags)
        {
            songCollection.Add(new Song(artist, name, year, tags));
        }
        public override string ToString()
        {
            foreach (Song item in songCollection)
            {
                Console.WriteLine(item.ToString());
            }
            return songCollection.ToString();
        }
    }
}
