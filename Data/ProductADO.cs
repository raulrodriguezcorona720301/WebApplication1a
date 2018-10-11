using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class ProductADO
    {
        public List<EntProduct> getCatalog(List<EntProduct> l)
        {
            if (l == null)
            {
                l = new List<EntProduct>() { };
                l.Add(new EntProduct { id = Guid.NewGuid().ToString(), descripcion = "primero", price = 100 });
                l.Add(new EntProduct { id = Guid.NewGuid().ToString(), descripcion = "segundo", price = 200 });
                l.Add(new EntProduct { id = Guid.NewGuid().ToString(), descripcion = "tercero", price = 300 });
            }
            return l;
        }

        public List<EntProduct> addProduct(List<EntProduct> l, EntProduct p)
        {
            var xx = l.Where(x => x.id == p.id);
            if (xx == null)
            {
                l.Add(p);
            }
            return l;
        }

        public EntProduct getProductById(List<EntProduct> l, string id)
        {
            if (l == null)
            {
                return null;
            }
            else
            {
                EntProduct r = l.Where(x => x.id == id).FirstOrDefault();
                return r;
            }
        }
    }
}
