using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Entities;
using System.Collections.Generic;
using WebApplication1.Business;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.UnitTestProject1
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void CtrlProduct_getCatalogTest()
        {
            CtrlProduct ctrlProduct = new CtrlProduct();
            List<EntProduct> result = ctrlProduct.getCatalog(null);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 3);
        }
    }
}
