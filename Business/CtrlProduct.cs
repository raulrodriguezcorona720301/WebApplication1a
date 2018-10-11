using System;
using System.Web;
using System.Collections.Generic;
using WebApplication1.Entities;
using WebApplication1.Data;

namespace WebApplication1.Business
{
    public class CtrlProduct
    {
        public List<EntProduct> getCatalog(List<EntProduct> l)
        {
            WebApplication1.Data.ProductADO adop = new WebApplication1.Data.ProductADO();
            return adop.getCatalog(l);
        }

        public List<EntProduct> addProduct(List<EntProduct> l, EntProduct p)
        {
            WebApplication1.Data.ProductADO adop = new WebApplication1.Data.ProductADO();
            return adop.addProduct(l, p);
        }

        public EntProduct getProductById(List<EntProduct> l, string id)
        {
            WebApplication1.Data.ProductADO adop = new WebApplication1.Data.ProductADO();
            return adop.getProductById(l, id);
        }
    }
}
