using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Business;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult AddProduct()
        {
            return View("~/Views/Product/EditProduct.cshtml", null);
        }

        public ActionResult EditProduct(EntProduct p)
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
            EntProduct p = ctrlProduct.getProductById(l, guidId);
            return View("~/Views/Product/EditProduct.cshtml", p);
        }

        [HttpPost]
        public ActionResult SaveProduct([Bind(Include ="id,descripcion,price")] EntProduct p)
        {
            List<EntProduct> l = null;
            if(Session["l"]!=null)
            {
                l = (List<EntProduct>)Session["l"];
            }
            else
            {
                CtrlProduct ctrlProduct = new CtrlProduct();
                l = ctrlProduct.getCatalog(null);
            }
            if(ModelState.IsValid)
            {
                EntProduct r = l.Where(x => x.id == p.id).FirstOrDefault();
                if (r == null)
                {
                    l.Add(p);
                }
                else
                {
                    l.Remove(r);
                    l.Add(p);
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