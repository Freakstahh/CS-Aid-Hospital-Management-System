using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Aid_Hospital_Management_System
{
    class Inventory
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Inventory(string name)
        {
            this.Name = name;
            this.Items = new List<Item>();
        }

        //adds an object to the invetory list
        public void addItem(Item obj)
        {
            Items.Add(obj);
        }

        //asks the program if a particular object is existing or not
        public bool isAvailable(Item obj)
        {
            if (obj.Count == 0)
            {
                removeItem(obj);
                return false;
            }
            return true;
        }

        //returns the count of items
        //for example, it returns the count of syringes and masks in your inventory
        public int objectCounter(Item obj)
        {
            return obj.Count;
        }

        //method to add the count in one of your objects
        //for example you want to add 500 to an existing 200 syringes
        public void addCount(Item obj, int num)
        {
            if (obj == null || num < 0)
                return;
            obj.Count += num;
        }

        //method to remove the count in one of your objects
        //for example you want to remove 500 to an existing 2000 mask
        public void removeCount(Item obj, int num)
        {
            if (obj == null || num > obj.Count || num < 0)
                return;
            obj.Count -= obj.Count;
        }

        //removes item from your inventory
        public void removeItem(Item obj)
        {
            if (obj == null)
                return;
            Items.Remove(obj);
        }

        //basically cleans your inventory
        public void cleanInventory()
        {
            foreach (Item item in Items)
            {
                if (item.Count == 0)
                    Items.Remove(item);
            }
        }
    }
}