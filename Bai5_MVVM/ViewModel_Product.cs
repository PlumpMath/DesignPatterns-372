using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_MVVM
{
    class ViewModel_Product : AbstrackViewModel<Product>
    {
        protected override bool isExits(Product t)
        {
            var ob = db.Products.Where(s => s.Name.Equals(t.Name)).ToList();
            if (ob.Count > 0)
                return true;
            else
                return false;
        }

        protected override void LoadObjectSet()
        {
            objectDbSet = db.Products;
        }

        protected override void setNewInfoFrom(Product o)
        {
            var old = db.Products.FirstOrDefault(s => s.ID == o.ID);
            old.Name = o.Name;
            old.Price = o.Price;
            old.Description = o.Description;
        }
        public ViewModel_Product() : base (){ }
    }
}
