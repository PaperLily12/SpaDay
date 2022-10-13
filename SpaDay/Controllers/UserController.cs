using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            if (newUser.Password != verify)
            {
                ViewBag.password = newUser.Password;
                ViewBag.error = "Your passwords must match!";
                return Redirect("/user/add");
            }
            return View("Index");
        }
    }
}
