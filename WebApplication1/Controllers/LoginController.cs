using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Business;
using System;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            Response.AddHeader("cache-control","no-cache");
            Response.AddHeader("pragma", "no-cache");
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            return View();
        }

        [HttpPost]
        public ContentResult setToken()
        {
            string result = "2407c26e-e207-4fca-a858-4be392019a23";
            Session["tokenId"] = result;
            return Content(result);
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "UsuarioSup, PasswordSup, tokenId")] EntLoginVm loginVm)
        {
            bool proceed = false;
            if(ModelState.IsValid)
            {
                if(Session["tokenId"]!=null)
                {
                    string tI = Convert.ToString(Session["tokenId"]);
                    if(tI == loginVm.tokenId.ToString())
                    {
                        CtrlLogin ctrlLogin = new CtrlLogin();
                        if(ctrlLogin.isValidLogin(loginVm.UsuarioSup, loginVm.PasswordSup))
                        {
                            proceed = true;
                            FormsAuthentication.SetAuthCookie(loginVm.UsuarioSup, false);
                        }
                    }
                }
            }

            if(!proceed)
            {
                ModelState.AddModelError("generalError", "Error general, verifica datos");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Inicio");
            }
        }
    } 
}