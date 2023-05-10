using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Swappa.Infarstructure.Data;
using Swappa.Web.Models;

namespace Swappa.Web.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly SwappaContext _context;

        public HomeController(SwappaContext context)
        {
            _context = context;
        }

    public IActionResult Index()
    {
        if(User.IsInRole("Customer")){
        return View();
        }else if(User.IsInRole("Admin")){
            return View("~/Areas/Admin/Views/Dashboard/Index.cshtml");
        }else{
            return View();
        }
    }

    public IActionResult Enter_Email()
    {
        return View();
    }

[HttpPost]
    public IActionResult CheckEmail(string email)
    {
        bool dataExists = _context.ApplicationUsers.Any(u => u.Email == email);
         var cookieOptions = new CookieOptions
        {
        Expires = DateTime.Now.AddDays(1) // Set cookie expiration time
        };
        Response.Cookies.Append("UserEmail", email, cookieOptions);

        if (dataExists)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        else
        {
            return RedirectToPage("/Account/Register", new { area = "Identity" });
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
