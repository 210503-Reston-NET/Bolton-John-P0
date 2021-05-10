
using System.Collections.Generic;

namespace SModels
{
    /// <summary>
    /// Class defines a location
    /// </summary>
    public class Location
    {   
        public Location(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }

       // need to add inventory for location.

        public override string ToString()
        {
            return $"Name: {this.Name} \nAddress: {this.Address}";
        }

    }
}
