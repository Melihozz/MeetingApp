using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag yerine ViewData kullanıyoruz.
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where (info=> info.WillAttend == true) . Count();
            //ViewData["UserName"] = "Ömer";

            var meetingInfo = new Meetinginfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount

            };
        
            return View(meetingInfo);
        }
    }
} 