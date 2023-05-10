using Microsoft.AspNetCore.Mvc;
using Swappa.Infrastructure.Interfaces;

namespace Swappa.Web.Controllers
{
    // This controller contains the uow class containing our SwappaContext. 
    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;
        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
