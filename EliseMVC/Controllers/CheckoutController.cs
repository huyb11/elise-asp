using EliseMVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace EliseMVC.Controllers
{
    public class CheckoutController: Controller
    {
        DBEliseStoreEntitiess db = new DBEliseStoreEntitiess();

        // GET: products
        public ActionResult Cart()
        {
            return View(db.tblProducts.ToList());
        }
    }
}