using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swappa.ApplicationCore.Utilities;
using Swappa.ApplicationCore.Models;
using Swappa.Infrastructure.Interfaces;
using Swappa.ApplicationCore.ParamModels;
using Swappa.ApplicationCore.ViewModels;
using Swappa.ApplicationCore.DtoModels;

namespace Swappa.Web.Controllers;
[Area("Admin")]
[Authorize(Roles = WebsiteRole.Admin)]
    public class DashboardController : BaseController
    {
        #region Constructors
        public DashboardController(IUnitOfWork uow) : base(uow)
        {
        }
        #endregion
        // GET: Admin/Movies
        public IActionResult Index()
        {   
            return View();
        }
        
        public IActionResult ManageUsers(int id = 1){
            UserParam userParam = new UserParam{
                PageIndex = id, PageSize = 10
            };
            Task<UserVM> users = _uow.ApplicationUsers.GetUsersByPaging(userParam);
            return View(users.Result);
        }
        public IActionResult ManageCategories(){
            var categories = _uow.Categories.GetAll();
            return View(categories);
        }
        public IActionResult CreateUser(){
            return View();
        }
    }
