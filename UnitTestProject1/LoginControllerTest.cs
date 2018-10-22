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
        public void setFnTest()
        {
            LoginController lc = new LoginController();
            lc.ControllerContext = new ControllerContext();
            //Add
            var result = lc.setFn();
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Content.ToString(), "xyz");
        }

        [TestMethod]
        public void IndexTest()
        {
            //Arrange
            LoginController lc = new LoginController();
            lc.ControllerContext = new ControllerContext();
            //Add
            var result = lc.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexTestParam()
        {
            //Arrange
            LoginController lc = new LoginController();
            lc.ControllerContext = new ControllerContext();
            EntLoginVm loginVm = new EntLoginVm() { fn="x", PasswordSup="123", tokenId="12345", UsuarioSup="juan", yesNo="true" };
            //Add
            var result = lc.Index(loginVm) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);
        }
    }
}
