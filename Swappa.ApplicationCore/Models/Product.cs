using Microsoft.AspNetCore.Identity;

namespace Swappa.ApplicationCore.Models;

public class Product
{
    public int ProductId { get; set; }
    public int Product_Number { get; set; }
    public string? Product_Name { get; set; }
    public string? Product_Description { get; set; }
    public decimal Product_Price { get; set; }
    public string? Product_Status { get; set; }
    public int Product_Quantity { get; set; }
    public string FormattedPrice
        {
            get { return String.Format("{0:C}", Product_Price); }
        }
    public SubCategory? SubCategory { get; set; }
    public ICollection<ProductPhoto>? Photos { get; set; }
}