using WebApplication1.Entities;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Tools
{
    public static class Tools
    {
        public static EntProductVm factoryModel(EntProduct p)
        {
            EntProductVm r = null;
            if (p != null)
            {
                r = new EntProductVm { price = p.price, descripcion = p.descripcion, id = p.id };
            }
            return r;
        }

        public static List<EntProductVm> factoryList(List<EntProduct> p)
        {
            List<EntProductVm> r = null;
            if(p!=null)
            {
                r = new List<EntProductVm>() { };
                foreach(EntProduct prod in p)
                {
                    EntProductVm x = new EntProductVm { price = prod.price, descripcion = prod.descripcion, id = prod.id };
                    r.Add(x);
                }
            }
            return r;
        }

        public static EntProduct factoryEntity(EntProductVm p)
        {
            EntProduct r = null;
            if (p != null)
            {
                r = new EntProduct { price = p.price, descripcion = p.descripcion, id = p.id };
            }
            return r;
        }
    }
}