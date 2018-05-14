using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public static class ProductExtended
    {
        public static List<Product> PodzielNaStrony(this List<Product> products, int rozmiar, int nrStrony)
        {
            // todo : zaimplementować przypadek dla strony mniejszej od rozmiar
            int poczatek = rozmiar * (nrStrony - 1);
            int ileRekordow = products.Count;
            if (ileRekordow + rozmiar < rozmiar * nrStrony)
            {
                throw new Exception("Przekroczono zakres wyników");
            }
            else
            {
                List<Product> outProducts = products.GetRange(poczatek, rozmiar);
                return outProducts;
            }

        }

        public static List<Product> GetProductsWithoutCategory(this List<Product> products)
        {
            var productsWithoutCategory = products.Where(p => p.ProductSubcategoryID is null).ToList();
            return productsWithoutCategory;
        }
    }
}
