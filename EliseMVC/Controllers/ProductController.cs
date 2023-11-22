using EliseMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EliseMVC.Controllers
{
    public class ProductController : Controller
    {
        DBEliseStoreEntitiess db = new DBEliseStoreEntitiess();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.tblProducts.ToList());
        }
        public ActionResult Create()
        {
            tblProduct product = new tblProduct();
            return View(product);
        }
        [HttpPost]
        public ActionResult Create(tblProduct product)
        {
            try
            {
                if (product.imageProduct1 != null &&
                    product.imageProduct2 != null &&
                    product.imageProduct3 != null )
                {
                    string filename1 = Path.GetFileNameWithoutExtension(product.UploadImg1.FileName);
                    string filename2 = Path.GetFileNameWithoutExtension(product.UploadImg2.FileName);
                    string filename3 = Path.GetFileNameWithoutExtension(product.UploadImg3.FileName);                   



                    filename1 = filename1 + Path.GetExtension(product.UploadImg1.FileName);
                    product.imageProduct1 = "~/Content/Img/" + filename1;
                    filename2 = filename2 + Path.GetExtension(product.UploadImg2.FileName);
                    product.imageProduct2 = "~/Content/Img/" + filename2;
                    filename3 = filename3 + Path.GetExtension(product.UploadImg3.FileName);
                    product.imageProduct3 = "~/Content/Img/" + filename3;
                    


                    product.UploadImg1.SaveAs(Path.Combine(Server.MapPath("~/Content/Img/"), filename1));
                    product.UploadImg2.SaveAs(Path.Combine(Server.MapPath("~/Content/Img/"), filename2));
                    product.UploadImg3.SaveAs(Path.Combine(Server.MapPath("~/Content/Img/"), filename3));                
                    db.tblProducts.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    db.tblProducts.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View("Index");
            }
        }
    }
}