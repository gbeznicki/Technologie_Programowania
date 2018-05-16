using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// todo dodatkowa metoda jak w tools

namespace Program
{
    public class MyTools
    {
        private static BazaDanychDataContext dataContext;

        public static BazaDanychDataContext DataContext { get => dataContext; set => dataContext = value; }

        public static List<MyProduct> GetProductByName(List<MyProduct> myProducts, string namePart)
        {
            return myProducts.Where(p => p.Name.Contains(namePart)).ToList();
        }

        public static List<MyProduct> GetProductsByVendorName(List<MyProduct> myProducts, string vendorName)
        {
            var vendorId = dataContext.Vendor.Where(v => v.Name.Equals(vendorName)).Select(v => v.BusinessEntityID)
                .First();

            var productIdsForVendor = dataContext.ProductVendor.Where(pv => pv.BusinessEntityID == vendorId)
                .Select(pv => pv.ProductID).ToList();

            var myProductsForVendor = myProducts.Where(mp => productIdsForVendor.Contains(mp.ProductID)).ToList();

            return myProductsForVendor;
        }


    }
}
