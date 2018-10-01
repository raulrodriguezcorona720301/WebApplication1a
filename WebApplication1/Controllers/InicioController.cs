using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Business;

namespace WebApplication1.Controllers
{
    public class InicioController : Controller
    {
        public ActionResult Index()
        {
            CtrlProduct ctrlProduct = new CtrlProduct();
            List<EntProduct> l = null;
            if(Session["l"] == null)
            {
                l = ctrlProduct.getCatalog(l);
                Session["l"] = l;
            }
            else
            {
                l = (List<EntProduct>)Session["l"];
            }
            return View(l);
        }
    }
}