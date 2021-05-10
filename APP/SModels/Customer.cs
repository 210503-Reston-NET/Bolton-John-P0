using System.Collections.Generic;

namespace StoreModels
{
    /// <summary>
    /// This class holds the customer info
    /// </summary>
    public class Customer
    {
        public Customer (string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }

    }
}
