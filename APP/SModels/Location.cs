
using System;

namespace SModels
{
    /// <summary>
    /// Class defines a location
    /// </summary>
    public class Location
    {   
        public Location(string name, string address, List<Item> inventory)
        {
            this.Name = name;
            this.Address = address;
            Inventory = new List<Item>();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Item> Inventory { get; set; }

       // need to add inventory for location.

        public override string ToString()
        {
            return $"Name: {this.Name} \nAddress: {this.Address}";
        }

    }
}
