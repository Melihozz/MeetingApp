using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    // GET
    public ActionResult Index()
    {
        return View();
    }
}