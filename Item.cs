using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital_Management
{
    class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Item(string name, int count)
        {
            this.Name = name;
            this.Count = count;
        }
    }
}