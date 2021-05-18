namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public List<Item> Items { get; set; }
        public double Total { get; set; }
        
        public Order(Customer customer, Location location, List<Item> items)
        {
            this.Customer = customer;
            this.Location = location;
            this.Items = items;
            this._date = DateTime.Now;

        }

        //TODO: add a property for the order items
    }
}
