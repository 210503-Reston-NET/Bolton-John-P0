namespace SModels{
{
  ///<summary>
  ///This data model is for a product and its quantity, and location.  
  ///</summary>
  public class Item
  {
  public Product Product {get;set;}
  public int Quantity {get; set;}
  public string location {get; set;}
}
