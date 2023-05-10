using Microsoft.AspNetCore.Identity;

namespace Swappa.ApplicationCore.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? Category_Name { get; set; }
    public string? Category_Image { get; set; }
    public ICollection<SubCategory>? SubCategories { get; set; }
}