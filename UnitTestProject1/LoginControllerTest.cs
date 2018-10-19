using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Entities;
using WebApplication1.Controllers;
using WebApplication1.Models;


namespace WebApplication1.UnitTestProject1
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void IndexText()
        {
            //Arrange
            LoginController lc = new LoginController();
            EntLoginVm loginVm = new EntLoginVm() { fn="x", PasswordSup="123", tokenId="12345", UsuarioSup="juan", yesNo="true" };
            //Session["tokenId"] = "12345";
            //Add
            var result = lc.Index(loginVm) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);
        }
    }
}
