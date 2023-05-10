using Microsoft.AspNetCore.Identity;

namespace Swappa.ApplicationCore.Models;

public class OrderDetail
{
    public int OrderDetailId { get; set; }
    public int Order_Id { get; set; }
    public string? Product_Name { get; set; }
    public decimal Product_Price { get; set; }
    public string FormattedPrice
        {
            get { return String.Format("{0:C}", Product_Price); }
        }
    public int Product_Quantity { get; set; }
    public string? Product_Image { get; set; }

    public Order? Order { get; set; }
    public Product? product { get; set; }
}