using System.Web.Mvc;

namespace EliseMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View("Register");
        }
    }
}