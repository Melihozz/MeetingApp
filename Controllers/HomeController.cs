using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    // GET
    public ActionResult Index()
    {
        int saat = DateTime.Now.Hour;

        // ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
        // ViewBag.UserName = "Sadık";
        ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
        ViewData["UserName"] = "Sadık";
        return View();
    }
}