using System.Collections.Generic;

namespace SMdodels
{
///<summary>
///This structure has the product data type.
///</summary>
public class Product
{
  public string Name {get;set;}
  public string Description {get;set;}
  public double Price {get; set;}
  public int IDNumber {get;set;}
  
  public Prodcut(string name, string description, double price, int idnumber)
  {
    this.Name= name;
    this.Description =description;
    this.Price=price;
    this.IDNumber=idnumber;
 }
 
 public Product(){
 
 public override string ToString()
 {
 return$:"Name:{this.Name}\n Description: {this.Description}\n Price: {this.Price} \IDNumber: {this.IDNumber}";
 }
 
}
}
