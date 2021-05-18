using System.Collections.Generic;

namespace SMdodels
{
///<summary>
///This structure has the product data type.
///</summary>
public class Product
{
  public string Name {get;set;}
  public double Price {get; set;}

  
  public Prodcut(string name, double price)
  {
    this.Name= name;
    this.Description =description;
    this.Price=price;
    this.IDNumber=idnumber;
 }
 

 
 public override string ToString()
 {
 return$:"Name:{this.Name}\n \n Price: {this.Price}}";
 }
 

}
