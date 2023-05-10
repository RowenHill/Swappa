
using Swappa.ApplicationCore.Models;
using Swappa.ApplicationCore.ViewModels;
using Swappa.ApplicationCore.ParamModels;
using Swappa.ApplicationCore.DtoModels;
using Microsoft.EntityFrameworkCore;
using Swappa.Infarstructure.Data;
using Swappa.Infrastructure.Interfaces;

#nullable disable

namespace Swappa.Infarstructure.Data
{
    public class CategoryRepository : Repository<ApplicationUser>, ICategoryRepository
    {

    // private new SwappaContext _context;

        public CategoryRepository(SwappaContext context) : base(context)
        {
        }

       
    }
}