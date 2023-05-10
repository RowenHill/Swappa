using Microsoft.AspNetCore.Identity;

namespace Swappa.ApplicationCore.Models;

public class SubCategory
{
    public int SubCategoryId { get; set; }
    public int Category_Id { get; set; }
    public string? SubCategory_Name { get; set; }
    public int Product_Id { get; set; }
    public Category? Category { get; set; }
    public ICollection<Product>? Product { get; set; }
}