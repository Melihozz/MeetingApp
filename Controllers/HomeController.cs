using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    // GET
    public String Index()
    {
        return "home/index";
    }
}