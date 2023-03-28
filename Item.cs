using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Aid_Hospital_Management_System
{
    class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public bool isAvailable { get; private set; }

        public Item(string name, int count)
        {
            this.Name = name;
            this.Count = count;
        }
    }
}