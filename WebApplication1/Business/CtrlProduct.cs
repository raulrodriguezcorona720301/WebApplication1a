using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Business
{
    public class CtrlProduct
    {
        public List<EntProduct> getCatalog(List<EntProduct> l)
        {
            ADOProduct adop = new ADOProduct();
            return adop.getCatalog(l);
        }

        public List<EntProduct> addProduct(List<EntProduct> l, EntProduct p)
        {
            ADOProduct adop = new ADOProduct();
            return adop.addProduct(l, p);
        }

        public EntProduct getProductById(List<EntProduct> l, string id)
        {
            ADOProduct adop = new ADOProduct();
            return adop.getProductById(l, id);
        }
    }
}