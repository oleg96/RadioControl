using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioControl
{
    class Tags
    {
        private List<String> CollectionOfTags = new List<string>();
        public void AddTag(string tag)
        {
            this.CollectionOfTags.Add(tag);
        }
        public override string ToString()
        {
            foreach(string item in CollectionOfTags)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
