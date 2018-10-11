using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Business;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult AddProduct()
        {
            return View("~/Views/Product/EditProduct.cshtml", null);
        }

        public ActionResult EditProduct(EntProductVm p)
        {
            return View("~/Views/Product/EditProduct.cshtml", p);
        }

        public ActionResult EditProductById(string guidId)
        {
            List<EntProduct> l = null;
            if (Session["l"] != null)
            {
                l = (List<EntProduct>)Session["l"];
            }
            CtrlProduct ctrlProduct = new CtrlProduct();
            EntProductVm p = Tools.Tools.factoryModel(ctrlProduct.getProductById(l, guidId));
            return View("~/Views/Product/EditProduct.cshtml", p);
        }

        [HttpPost]
        public ActionResult SaveProduct([Bind(Include = "id,descripcion,price")] EntProductVm p)
        {
            List<EntProduct> l = null;
            if (Session["l"] != null)
            {
                l = (List<EntProduct>)Session["l"];
            }
            else
            {
                CtrlProduct ctrlProduct = new CtrlProduct();
                l = ctrlProduct.getCatalog(null);
            }
            if (ModelState.IsValid)
            {
                EntProduct r = l.Where(x => x.id == p.id).FirstOrDefault();
                if (r == null)
                {
                    l.Add(Tools.Tools.factoryEntity(p));
                }
                else
                {
                    l.Remove(r);
                    l.Add(Tools.Tools.factoryEntity(p));
                }
                Session["l"] = l;
                return RedirectToAction("Index", "Inicio");
            }
            else
            {
                ModelState.AddModelError("general", "verificar");
                return RedirectToAction("EditProduct", p);
            }
        }
    }
}