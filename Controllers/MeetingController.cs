using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Apply()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Apply(Userinfo model)
    {
        if (ModelState.IsValid)
        {
        Repository.CreateUser(model);
        ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
        return View("Thanks", model);
        }
        else
        {
            return View(model);
        }
    }
    [HttpGet]
    public IActionResult List()
    {
        return View(Repository.Users);
    }

    public IActionResult Details(int id)
    {
        return View(Repository.GetById(id));
    }
} 