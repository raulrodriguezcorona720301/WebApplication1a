using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Business;
using WebApplication1.Models;
using WebApplication1.Entities;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{
    public class InicioController : Controller
    {
        public ActionResult Index()
        {
            CtrlProduct ctrlProduct = new CtrlProduct();
            List<EntProduct> l = null;
            if (Session["l"] == null)
            {
                l = ctrlProduct.getCatalog(l);
                Session["l"] = l;
            }
            else
            {
                l = (List<EntProduct>)Session["l"];
            }
            return View(Tools.Tools.factoryList(l));
        }
    }
}